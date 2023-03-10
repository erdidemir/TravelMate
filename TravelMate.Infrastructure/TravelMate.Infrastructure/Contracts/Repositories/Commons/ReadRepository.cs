using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Application.Contracts.Repositories.Commons;
using TravelMate.Domain.Entities.Commons;

namespace TravelMate.Infrastructure.Contracts.Repositories.Commons
{
    public class ReadRepository<T> : IReadRepository<T> where T : EntityBase
    {
        private readonly ApplicationDbContext _context;
        public ReadRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        #region Properties

        public virtual IQueryable<T> Table
        {
            get
            {
                return _context.Set<T>().Where(x => x.IsDeleted == false);
            }
        }

        /// <summary>
        /// Gets a table with "no tracking" enabled (EF feature) Use it only when you load record(s) only for read-only operations
        /// </summary>
        public virtual IQueryable<T> TableNoTracking
        {
            get
            {
                return _context.Set<T>().Where(x => x.IsDeleted == false).AsNoTracking();
            }
        }

        #endregion


        #region Select

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await TableNoTracking.OrderByDescending(x => x.Id).ToListAsync();
        }
        public async Task<IReadOnlyList<T>> GetAllDeletedAsync()
        {
            return await _context.Set<T>().Where(x => x.IsDeleted == true).AsNoTracking().OrderByDescending(x => x.Id).ToListAsync();
        }
        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await TableNoTracking.Where(predicate).OrderByDescending(x => x.Id).ToListAsync();
        }
        public async Task<T> GetFirstAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = Table;

            if (includes != null) query = includes.Aggregate(query, (current, include) => current.Include(include));

            if (predicate != null) query = query.Where(predicate);

            return await query.AsNoTracking().FirstOrDefaultAsync();
        }
        public async Task<T> GetFirstIncludeDeletedAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _context.Set<T>();

            if (includes != null) query = includes.Aggregate(query, (current, include) => current.Include(include));

            if (predicate != null) query = query.Where(predicate);

            return await query.AsNoTracking().FirstOrDefaultAsync();
        }
        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = TableNoTracking;

            if (includes != null) query = includes.Aggregate(query, (current, include) => current.Include(include));

            if (predicate != null) query = query.Where(predicate);

            return await query.AsNoTracking().OrderByDescending(x => x.Id).ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeString = null, bool disableTracking = true)
        {
            IQueryable<T> query = TableNoTracking;
            if (disableTracking) query = query.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(includeString)) query = query.Include(includeString);

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return await orderBy(query).ToListAsync();
            return await query.OrderByDescending(x => x.Id).ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<Expression<Func<T, object>>> includes = null, bool disableTracking = true)
        {
            IQueryable<T> query = TableNoTracking;
            if (disableTracking) query = query.AsNoTracking();

            if (includes != null) query = includes.Aggregate(query, (current, include) => current.Include(include));

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return await orderBy(query).ToListAsync();

            return await query.OrderByDescending(x => x.Id).ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity != null)
            {
                if (entity.IsDeleted == false)
                {
                    return entity;
                }
            }

            return null;
        }

        public virtual async Task<IEnumerable<T>> GetByIdsAsync(IEnumerable<int> ids)
        {
            return await _context.Set<IEnumerable<T>>().FindAsync(ids);
        }

        public virtual async Task<int> CountAsync()
        {
            return await _context.Set<T>().CountAsync();
        }

        public virtual async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            return await _context.Set<T>().CountAsync(predicate);
        }


        #endregion

    }
}
