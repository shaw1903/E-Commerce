using E_Commerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using E_Commerce.Models;
using E_Commerce.Controllers;

namespace E_Commerce.Data
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly JumaContext db;
        public EntityBaseRepository(JumaContext injectedContext)
        {
            db = injectedContext;
        }

        public async Task AddAsync(T entity)
        {
            await db.Set<T>().AddAsync(entity);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int ItemNumber)
        {
            var entity = await db.Set<T>().FirstOrDefaultAsync(n => n.ItemNumber == ItemNumber);
            EntityEntry entityEntry = db.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;

            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await db.Set<T>().ToListAsync();

        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = db.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return await query.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int ItemNumber) => await db.Set<T>().FirstOrDefaultAsync(n => n.ItemNumber == ItemNumber);

        public async Task<T> GetByIdAsync(int ItemNumber, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = db.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return await query.FirstOrDefaultAsync(n => n.ItemNumber == ItemNumber);
        }

        public async Task UpdateAsync(int ItemNumber, T entity)
        {
            EntityEntry entityEntry =  db.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;

            await db.SaveChangesAsync();
        }
    }
}