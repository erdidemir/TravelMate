using System.Linq.Expressions;
using TravelMate.Domain.Entities.Commons;

namespace TravelMate.Application.Contracts.Repositories.Commons
{
    public interface IReadRepository<T> : IRepositoryBase<T> where T : EntityBase
    {
        #region Select

        Task<T> GetFirstAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includes);
        Task<T> GetFirstIncludeDeletedAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<IReadOnlyList<T>> GetAllDeletedAsync();
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null);
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includes);
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        string includeString = null,
                                        bool disableTracking = true);
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                       Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                       List<Expression<Func<T, object>>> includes = null,
                                       bool disableTracking = true);
        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetByIdsAsync(IEnumerable<int> ids);
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);

        #endregion
    }
}
