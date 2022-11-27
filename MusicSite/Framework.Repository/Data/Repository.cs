using Framework.Utility.Extensions;
using Framework.Utility.Helper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Framework.Repository.Data
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class
    {
        private readonly DbSet<TEntity> _dbSet;
        private readonly IUnitOfWork _unitOfWork;
        public Repository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _dbSet = unitOfWork.CurrentDBContext.Set<TEntity>();

            LogHelper.Info("myguid=====" + unitOfWork.CurrentDBContext.myguid);
        }
        #region  Property
        /// <summary>
        /// 获取 当前单元操作对象
        /// </summary>
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _unitOfWork;
            }
        }

        /// <summary>
        /// 获取 当前实体类型的查询数据集
        /// </summary>
        public IQueryable<TEntity> Entities { get { return _dbSet; } }

        /// <summary>
        /// 获取 当前实体类型的查询数据集AsNoTracking
        /// </summary>
        public IQueryable<TEntity> EntitiesAsNoTracking { get { return _dbSet.AsNoTracking(); } }

        #endregion

        #region Query 
        /// <summary>
        /// 查找指定主键的实体
        /// </summary>
        /// <param name="key">实体主键</param>
        /// <returns>符合主键的实体，不存在时返回null</returns>
        public TEntity GetByKey(TKey key)
        {
            return _dbSet.Find(key);
        }
        /// <summary>
        /// 查找指定主键的实体
        /// </summary>
        /// <param name="key">实体主键</param>
        /// <returns>符合主键的实体，不存在时返回null</returns>
        public async Task<TEntity> GetByKeyAsync(TKey key)
        {
            return await _dbSet.FindAsync(key);
        }
        ///<summary>
        ///检查实体是否存在
        ///</summary>
        ///<param name="predicate">查询条件谓语表达式</param> 
        ///<returns>是否存在</returns>
        public bool CheckExists(Expression<Func<TEntity, bool>> predicate)
        {
            var count = _dbSet.Where(predicate).Count();
            return count > 0;
        }

        /// <summary>
        /// 查找第一个符合条件的数据
        /// </summary>
        /// <param name="predicate">数据查询谓语表达式</param>
        /// <returns>符合条件的实体，不存在时返回null</returns>
        public TEntity GetFirst(Expression<Func<TEntity, bool>> predicate)
        {
            return Query(predicate).First();
        }
        /// <summary>
        /// 获取<typeparamref name="TEntity"/>跟踪数据更改（Tracking）的查询数据源
        /// </summary>
        /// <param name="predicate">数据过滤表达式</param>
        /// <returns>符合条件的数据集</returns>
        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query = _dbSet.AsQueryable();
            if (predicate == null)
            {
                return query;
            }
            return query.Where(predicate);
        }
        /// <summary>
        /// 查找第一个符合条件的数据
        /// </summary>
        /// <param name="predicate">数据查询谓语表达式</param>
        /// <returns>符合条件的实体，不存在时返回null</returns>
        public TEntity GetFirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Query(predicate).FirstOrDefault();
        }
        /// <summary>
        /// 获取<typeparamref name="TEntity"/>不跟踪数据更改（NoTracking）的查询数据源
        /// </summary>
        /// <param name="predicate">数据查询谓语表达式</param>
        /// <returns>符合条件的数据集</returns>
        public IQueryable<TEntity> QueryAsNoTracking(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query = _dbSet.AsQueryable();
            if (predicate == null)
            {
                return query;
            }
            return query.Where(predicate).AsNoTracking();
        }

        /// <summary>
        /// 获取贪婪加载导航属性的查询数据集
        /// </summary>
        /// <param name="path">属性表达式，表示要贪婪加载的导航属性</param>
        /// <returns>查询数据集</returns>
        public IQueryable<TEntity> GetInclude<TProperty>(Expression<Func<TEntity, TProperty>> path)
        {
            return _dbSet.Include(path);
        }

        /// <summary>
        /// 获取贪婪加载多个导航属性的查询数据集
        /// </summary>
        /// <param name="paths">要贪婪加载的导航属性名称数组</param>
        /// <returns>查询数据集</returns>
        public IQueryable<TEntity> GetIncludes(params string[] paths)
        {
            IQueryable<TEntity> source = _dbSet;
            foreach (string path in paths)
            {
                source = source.Include(path);
            }
            return source;
        }


        #region async query
    
        public async Task<IEnumerable<TEntity>> FindListAsync<T>(Expression<Func<TEntity, bool>> predicate) where T : class, new()
        { 
            return await _dbSet.Where(predicate).ToListAsync(); 
        } 
        #endregion

        #endregion

        #region Insert
        /// <summary>
        /// 插入实体
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns>操作影响的行数</returns>
        public int Insert(TEntity entity)
        {
            AssignCreateProperty(entity);
            _dbSet.Add(entity);
            return SaveChanges();
        }
        /// <summary>
        /// 批量插入实体
        /// </summary>
        /// <param name="entities">实体对象集合</param>
        /// <returns>操作影响的行数</returns>
        public int Insert(IEnumerable<TEntity> entities)
        {
            entities = entities as TEntity[] ?? entities.ToArray();
            foreach (var item in entities)
            {
                AssignCreateProperty(item);
            }
            _dbSet.AddRange(entities);
            return SaveChanges();
        }
        #endregion

        #region Delete
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns>操作影响的行数</returns>
        public int Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            return SaveChanges();
        }

        /// <summary>
        /// 删除指定编号的实体
        /// </summary>
        /// <param name="key">实体编号</param>
        /// <returns>操作影响的行数</returns>
        public int Delete(TKey key)
        {
            TEntity entity = _dbSet.Find(key);
            return entity == null ? 0 : Delete(entity);
        }

        /// <summary>
        /// 删除所有符合特定条件的实体
        /// </summary>
        /// <param name="predicate">查询条件谓语表达式</param>
        /// <returns>操作影响的行数</returns>
        public int Delete(Expression<Func<TEntity, bool>> predicate)
        {
            TEntity[] entities = _dbSet.Where(predicate).ToArray();
            return entities.Length == 0 ? 0 : Delete(entities);
        }

        /// <summary>
        /// 批量删除删除实体
        /// </summary>
        /// <param name="entities">实体对象集合</param>
        /// <returns>操作影响的行数</returns>
        public int Delete(IEnumerable<TEntity> entities)
        {
            entities = entities as TEntity[] ?? entities.ToArray();
            _dbSet.RemoveRange(entities);
            return SaveChanges();
        }

        #endregion

        #region Update

        /// <summary>
        /// 更新实体对象
        /// </summary>
        /// <param name="entity">更新后的实体对象</param>
        /// <returns>操作影响的行数</returns>
        public int Update(TEntity entity)
        {
            AssignModifyProperty(entity);
            _unitOfWork.CurrentDBContext.Update(entity);
            return SaveChanges();
        }

        #endregion

        #region 私有方法

        private int SaveChanges()
        {
            return _unitOfWork.SaveChanges();
        }
        /// <summary>
        /// 赋值CreateBy和CreateTime
        /// </summary>
        /// <param name="entity"></param>
        private void AssignCreateProperty(TEntity entity)
        {
            var createByProp = typeof(TEntity).GetProperty("CreateBy");
            var createTimeProp = typeof(TEntity).GetProperty("CreateTime");
            //var createBy = entity.GetType().GetProperties().FirstOrDefault(c => c.Name == createByProp?.Name)?.GetValue(entity)?.ToString();
            //createByProp?.SetValue(entity, string.IsNullOrEmpty(createBy) ? _principal?.Identity?.Name : createBy);
            createTimeProp?.SetValue(entity, DateTime.Now);
        }
        /// <summary>
        /// 赋值ModifyBy和ModifyTime
        /// </summary>
        /// <param name="entity"></param>
        private void AssignModifyProperty(TEntity entity)
        {
            var modifyByProp = typeof(TEntity).GetProperty("ModifyBy");
            var modifyTimeProp = typeof(TEntity).GetProperty("ModifyTime");
            //var modifyBy = entity.GetType().GetProperties().FirstOrDefault(c => c.Name == modifyByProp?.Name)?.GetValue(entity)?.ToString();
            //modifyByProp?.SetValue(entity, string.IsNullOrEmpty(modifyBy) ? _principal?.Identity?.Name : modifyBy);
            modifyTimeProp?.SetValue(entity, DateTime.Now);//DateTime.UtcNow.ToJsTimestamp()
        }
        #endregion
    }
}
