using Framework.EF.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Repository
{
    public interface IUnitOfWork
    {
        #region 属性

        MyDBContext CurrentDBContext { get; }

        /// <summary>
        /// 获取 是否开启事务提交
        /// </summary>
        bool TransactionEnabled { get; }

        #endregion

        #region 方法

        /// <summary>
        /// 显式开启数据上下文事务
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// 提交当前上下文的事务更改
        /// </summary>
        int Commit();

        /// <summary>
        /// 显式回滚事务，仅在显式开启事务后有用
        /// </summary>
        void Rollback();


        /// <summary>
        /// 提交当前单元操作的更改。
        /// </summary>
        /// <returns>操作影响的行数</returns>
        int SaveChanges();
        #endregion

    }
}
