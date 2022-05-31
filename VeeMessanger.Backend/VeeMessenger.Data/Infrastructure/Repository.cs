using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VeeMessenger.Data.Context;
using VeeMessenger.Data.Entities;

namespace VeeMessenger.Data.Infrastructure
{
    public sealed class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly VeeMessengerContext context;
        private readonly DbSet<TEntity> dbEntities;

        public Repository(VeeMessengerContext context)
        {
            this.context = context;
            dbEntities = this.context.Set<TEntity>();
        }

        public IQueryable<TEntity> Query(params Expression<Func<TEntity, object>>[] includes)
        {
            var dbSet = context.Set<TEntity>();
            var query = includes
                .Aggregate<Expression<Func<TEntity, object>>, IQueryable<TEntity>>(dbSet, (current, include) => current.Include(include));

            return query ?? dbSet;
        }

        public ValueTask<TEntity> GetByIdAsync(params object[] keys)
        {
            return dbEntities.FindAsync(keys);
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            CheckEntityForNull(entity);

            return (await dbEntities.AddAsync(entity)).Entity;
        }

        public Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            return dbEntities.AddRangeAsync(entities);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            return await Task.Run(() => dbEntities.Update(entity).Entity);
        }

        public async Task UpdateRangeAsync(IEnumerable<TEntity> entities)
        {
            await Task.Run(() => dbEntities.UpdateRange(entities));
        }

        public async Task DeleteRangeAsync(IEnumerable<TEntity> entities)
        {
            await Task.Run(() => entities.ToList().ForEach(item => context.Entry(item).State = EntityState.Deleted));
        }

        public async Task<int> SaveChangesAsync()
        {
            try
            {
                return await context.SaveChangesAsync();
            }
            catch
            {
                if (context.Database.CurrentTransaction != null)
                {
                    context.Database.CurrentTransaction.Rollback();
                }

                throw;
            }
        }

        public void Delete(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
        }

        public void Detach(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Detached;
        }

        private static void CheckEntityForNull(TEntity entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity), "The entity to add cannot be null.");
            }
        }
    }
}
