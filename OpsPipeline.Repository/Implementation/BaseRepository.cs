using Microsoft.EntityFrameworkCore.Storage;

using OpsPipelineAPI.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using OpsPipelineAPI.Repository.ExtensionMethods;

namespace OpsPipelineAPI.Repository.Implementation
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DbContext _dbContext;
        private DbSet<T> _dbSet;
        private IDbContextTransaction _transaction;

        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public void CloseConnection()
        {
            //  _dbContext.Database.Connection.Close();
        }

        public void DisposeConnection()
        {
            _dbContext.Dispose();
        }

        public Task<T> FirstAsync(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.AsNoTracking().FirstOrDefaultAsync(filter);
        }

        public IEnumerable<T> GetAllApplyFilters(Expression<Func<T, bool>> filter = null, string orderBy = null, bool asc = true, string includeProperties = null)
        {
            IQueryable<T> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }
            //include properties will be comma seperated
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            if (orderBy != null)
            {
                if (asc)
                    return DynamicOrderBy.OrderByDynamic(query, orderBy, ListSortDirection.Ascending).ToList();
                else
                    return DynamicOrderBy.OrderByDynamic(query, orderBy, ListSortDirection.Descending).ToList();
            }
            return query.ToList();
        }


        public async Task<IEnumerable<T>> GetAll()
        {
            return await Task.Run(() => _dbSet.AsEnumerable());
        }

        public T GetByID(object id)
        {
            return _dbSet.Find(id);
        }

        public async Task<T> GetByIdAsync<Tkey>(Tkey id)
        {
            return await _dbSet.FindAsync(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task AddRangeAsync(IEnumerable<T> entity)
        {
            await _dbSet.AddRangeAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            try
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
                await Task.Run(() => _dbSet.Update(entity));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task UpdateRangeAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveAsync(T entity)
        {
            try
            {
                await Task.Run(() => _dbSet.Remove(entity));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task RemoveRangeAsync(IEnumerable<T> entity)
        {
            try
            {

                await Task.Run(() => _dbSet.RemoveRange(entity));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            try
            {
                return await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void DisposeTransaction()
        {
            throw new NotImplementedException();
        }


    }
}
