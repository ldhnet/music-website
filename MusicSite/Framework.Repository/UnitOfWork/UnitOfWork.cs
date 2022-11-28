using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Framework.Repository
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly MyDBContext _context;
        /// <summary>
        /// The contructor requires an open DbContext to work with
        /// </summary>
        /// <param name="context">An open DataContext</param>
        public UnitOfWork(MyDBContext context)
        {
            _context = context;
        }
        /// <summary>
        ///  获取 当前单元操作对象
        /// </summary>
        public MyDBContext CurrentDBContext
        {
            get
            {
                return _context;
            }
        }

       
        /// <summary>
        /// 获取 是否开启事务提交
        /// </summary>
        public bool TransactionEnabled => CurrentDBContext.Database.CurrentTransaction != null;

        /// <summary>
        /// 显式开启数据上下文事务
        /// </summary>
        /// <param name="isolationLevel"></param>
        public void BeginTransaction()
        {
            if (CurrentDBContext.Database.CurrentTransaction == null)
            {
                CurrentDBContext.Database.BeginTransaction();
            }
        }
        /// <summary>
        /// 提交事务的更改
        /// </summary>
        /// <returns></returns>
        public int Commit()
        {
            IDbContextTransaction transaction = CurrentDBContext.Database.CurrentTransaction;
            if (transaction != null)
            {
                try
                {
                    transaction.Commit();
                    return 1;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }

            return 0;
        }


        /// <summary>
        /// 显式回滚事务，仅在显式开启事务后有用
        /// </summary>
        public void Rollback()
        {
            if (CurrentDBContext.Database.CurrentTransaction != null)
            {
                CurrentDBContext.Database.CurrentTransaction.Rollback();
            }
        }

        /// <summary>
        /// 提交当前单元操作的更改
        /// </summary>
        /// <returns></returns>
        public int SaveChanges()
        {
            try
            {
                int count = CurrentDBContext.SaveChanges();
                return count;
            }
            catch (DbUpdateException e)
            {
                Rollback();
                throw;
            }
        }
    }
}
