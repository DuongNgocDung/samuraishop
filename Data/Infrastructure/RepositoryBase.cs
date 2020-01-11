using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Data.Infrastructure
{
    /// <summary>
    /// thực thi những class đã định nghĩa trong IRepository
    /// </summary>
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        #region Properties

        private SamuraiShopDbContext dataContext;
        private readonly IDbSet<T> dbSet;

        /// <summary>
        /// Create and Dispose SamuraiShopDbContext
        /// </summary>
        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        /// <summary>
        /// just get no set
        /// </summary>
        protected SamuraiShopDbContext DbContext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init()); }
        }

        #endregion Properties

        /// <summary>
        /// cái repo base này cần 1 cái dbFactory truyền vô
        /// </summary>
        /// <param name="dbFactory"></param>
        protected RepositoryBase(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            dbSet = DbContext.Set<T>();
        }

        #region Implementation

        public virtual T Add(T entity)
        {
            return dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual T Delete(T entity)
        {
            return dbSet.Remove(entity);
        }

        public virtual int DeleteMulti(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            int count = 0;
            foreach (T obj in objects)
            {
                T rs = dbSet.Remove(obj);
                if (rs != null)
                    count++;
            }
            if (count != objects.Count())
                return -1;
            return 1;
        }

        public virtual T GetSingleById(object[] keyValues)
        {
            return dbSet.Find(keyValues);
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where, string includes)
        {
            return dbSet.Where(where).ToList();
        }
        
        public virtual int Count(Expression<Func<T, bool>> where)
        {
            return dbSet.Count(where);
        }

        public IEnumerable<T> GetAll(string[] includes = null)
        {
            if (includes != null && includes.Count() > 0)
            {
                var query = dataContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query;
            }

            return dataContext.Set<T>();
        }

        public T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null)
        {
            if (includes != null && includes.Count() > 0)
            {
                var query = dataContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query.FirstOrDefault(expression);
            }

            return dataContext.Set<T>().FirstOrDefault(expression);
        }

        public virtual IEnumerable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes)
        {
            if (includes != null && includes.Count() > 0)
            {
                var query = dataContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query.Where<T>(predicate);
            }

            return dataContext.Set<T>().Where<T>(predicate);
        }

        public virtual IEnumerable<T> GetMultiPaging(Expression<Func<T, bool>> predicate, out int total, int index = 0, int size = 50, string[] includes = null)
        {
            int skipCount = index * size;
            IEnumerable<T> _resetSet;

            if (includes != null && includes.Count() > 0)
            {
                var query = dataContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                _resetSet = predicate != null ? query.Where<T>(predicate) : query;
            }
            else
            {
                _resetSet = predicate != null ? dataContext.Set<T>().Where<T>(predicate) : dataContext.Set<T>();
            }
            total = _resetSet.Count();
            _resetSet = skipCount == 0 ? _resetSet.Take(size) : _resetSet.Skip(skipCount).Take(size);
            return _resetSet;
        }

        public bool CheckContains(Expression<Func<T, bool>> predicate)
        {
            return dataContext.Set<T>().Count<T>(predicate) > 0;
        }

        #endregion Implementation
    }
}