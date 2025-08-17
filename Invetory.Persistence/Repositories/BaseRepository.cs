using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Invetory.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Invetory.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>, IDisposable
    where T : class
    {
        private readonly DataContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(DataContext context)
        {
            //  this.context = context;
            _context = context;
            _dbSet = _context.Set<T>();
        }

        // Implementación de los métodos de IBaseRepository<T>

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var items = await _dbSet.ToListAsync();
            // return await _dbSet.ToListAsync();
            return items;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var item = await _dbSet.FindAsync(id);
            return item;
            
        }

        public async Task<T> AddASync(T entity)
        {
            //await _dbSet.AddAsync(entity);
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<IEnumerable<T>> AddAll(IEnumerable<T> entities)
        {

            await _context.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
            return entities;
        }

        /* public async Task<IEnumerable<T>> AddAllAsync(IEnumerable<T> entities)
       {
           await _dbSet.AddRangeAsync(entities);
           await _context.SaveChangesAsync();
           return entities;
       }
       */
        public async Task<bool> UpdateAsync(int id, T entity)
        {
            //  _dbSet.Update(entity);
            // var affectedRows = await _context.SaveChangesAsync();
            //return affectedRows > 0;
            var item = await _dbSet.FindAsync(id);
            if (item is not null)
            {
                _context.Update(item);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
          
        }


        public async Task<bool> DeleteAsync(int id)
        {
            /*  var entity = await GetByIdAsync(id);
              if (entity == null) return false;

              _dbSet.Remove(entity);
              var affectedRows = await _context.SaveChangesAsync();
              return affectedRows > 0;*/
              var item = await _dbSet.FindAsync(id);
            if (item is not null)
            {
                _context.Remove(item);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            /*_dbSet.Remove(entity);
            var affectedRows = await _context.SaveChangesAsync();
            return affectedRows > 0;*/
            _context.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public void Dispose()
        {
            _context?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}