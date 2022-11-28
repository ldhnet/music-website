using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Microsoft.EntityFrameworkCore;

namespace Framework.Repository
{
    public static class PagedListExtensions
    { 
        /// <summary>
        /// PagedList
        /// </summary>
        /// <param name="query"></param>
        /// <param name="pageIndex">1为起始页</param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken"></param>
        public static async Task<Page<T>> ToPagedListAsync<T>(
            this IQueryable<T> query,
            int pageIndex,
            int pageSize,
            CancellationToken cancellationToken = default)
        {
            if (pageIndex < 1) throw new ArgumentOutOfRangeException(nameof(pageIndex));
            int realIndex = pageIndex - 1;
            int count = await query.CountAsync(cancellationToken).ConfigureAwait(false);
            var items = await query.Skip(realIndex * pageSize)
                                   .Take(pageSize)
                                   .ToListAsync(cancellationToken)
                                   .ConfigureAwait(false);
            return new Page<T>(items, pageIndex, pageSize, count);
        }

        public static Page<T> ToPagedList<T>(
            this IQueryable<T> query,
            int pageIndex,
            int pageSize)
        {
            if (pageIndex < 1) throw new ArgumentOutOfRangeException(nameof(pageIndex));
            int realIndex = pageIndex - 1;
            int count = query.Count();
            var items = query.Skip(realIndex * pageSize)
                             .Take(pageSize)
                             .ToList();
            return new Page<T>(items, pageIndex, pageSize, count);
        }
    }

    /// <summary>
    /// 分页列表
    /// </summary>
    public class Page<T>
    {
        public Page(){}

        public Page(List<T> items, int pageIndex, int pageSize, int totalCount)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            Total = totalCount;
            PageTotal = (int)Math.Ceiling(totalCount / (double)pageSize);
            Items = items;
        }

        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        public int PageTotal { get; set; }

        /// <summary>
        /// 分页数据
        /// </summary>
        public List<T> Items { get; set; }
    }
}
