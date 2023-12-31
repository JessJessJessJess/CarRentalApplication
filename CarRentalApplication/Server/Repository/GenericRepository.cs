﻿using CarRentalApplication.Server.Data;
using CarRentalApplication.Server.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CarRentalApplication.Server.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task Delete(int id)
        {
            var record = await _dbSet.FindAsync(id);
            _dbSet.Remove(record);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public async Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null)
        {
            IQueryable<T> query = _dbSet;
            if(includes != null)
            {
                foreach(var property in includes) 
                {
                    query = query.Include(property); 
                   
                }
            } 
            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public async Task<IList<T>> GetAll(Expression<Func<T, bool>> expression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<string> includes = null)
        {
            IQueryable<T> query = _dbSet;

            if(expression != null)
            {
                query = query.Where(expression);
            }

            if(includes != null)
            {
                foreach(var property in includes)
                {
                    query = query.Include(property);
                }
            }

            if(orderBy != null)
            {
                query = orderBy(query);
            }

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task Insert(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task InsertRange(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public async void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
