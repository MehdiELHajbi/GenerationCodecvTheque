using Application;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace InfrastructurePersistence
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _dbContext;
        protected readonly DbSet<T> _dbSet;
        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        #region CREATE
        public async Task<T> AddAsync(T entity, CancellationToken cancellationToken)
        {
            await _dbSet.AddAsync(entity, cancellationToken);
            await _dbContext.SaveChangesAsync();

            return entity;
        }
        public virtual void Add(IEnumerable<T> entities) => _dbSet.AddRange(entities);
        #endregion

        #region READ

        public virtual T GetById(params object[] keyValues) => _dbSet.Find(keyValues);
        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }
        public virtual async Task<T> GetByIdsAsync(params object[] keyValues) => await _dbSet.FindAsync(keyValues);

        public virtual async Task<IReadOnlyList<T>> GetMulipleAsync(
                                       Expression<Func<T, bool>> predicate = null,
                                       Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                       bool disableTracking = true
                                    )
        {
            IQueryable<T> query = _dbSet;
            if (disableTracking)
            {
                query = query.AsNoTracking();
            }
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }

        public virtual IEnumerable<T> GetMuliple(
                                               Expression<Func<T, bool>> predicate = null,
                                               Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                               bool disableTracking = true
                                            )
        {
            IQueryable<T> query = _dbSet;
            if (disableTracking)
            {
                query = query.AsNoTracking();
            }
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async virtual Task<IReadOnlyList<T>> GetPagedReponseAsync(int page, int size)
        {
            return await _dbSet.Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
        }

        public Task<T> GetFirstOrDefault(Expression<Func<T, bool>> predicate = null
                                 , Func<IQueryable<T>
                                 , IOrderedQueryable<T>> orderBy = null
                                 , bool disableTracking = true)
        {
            IQueryable<T> query = _dbSet;
            if (disableTracking)
            {
                query = query.AsNoTracking();
            }
            if (predicate != null)
            {
                query = query.Where(predicate);
            }



            if (orderBy != null)
            {
                return Task.FromResult(orderBy(query).FirstOrDefault());
            }
            else
            {
                return Task.FromResult(query.FirstOrDefault());
            }
        }


        #endregion

        #region  Update
        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
        #endregion

        #region Delete
        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
        #endregion

        #region OTHER
        public async Task ExecuteTransactionAsync(Func<Task> operation)
        {
            using (var transaction = await _dbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    // Exécute l'opération passée en paramètre
                    await operation();

                    // Valide la transaction si tout s'est bien passé
                    await transaction.CommitAsync();
                }
                catch
                {
                    // Annule la transaction en cas d'erreur
                    await transaction.RollbackAsync();
                    throw; // Renvoie l'exception pour une gestion externe
                }
            }
        }

        public virtual int Count(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate == null)
            {
                return _dbSet.Count();
            }
            else
            {
                return _dbSet.Count(predicate);
            }
        }
        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate == null)
            {
                return await _dbSet.CountAsync();
            }
            else
            {
                return await _dbSet.CountAsync(predicate);
            }
        }
        public virtual bool Exists(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Any(predicate);
        }
        #endregion
    }
}
