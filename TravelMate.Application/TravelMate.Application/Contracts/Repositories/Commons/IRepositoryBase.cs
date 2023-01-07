using TravelMate.Domain.Entities.Commons;

namespace TravelMate.Application.Contracts.Repositories.Commons
{
    public interface IRepositoryBase<T> where T : EntityBase
    {
        #region Properties

        /// <summary>
        /// Gets a table
        /// </summary>
        IQueryable<T> Table { get; }

        /// <summary>
        /// Gets a table with "no tracking" enabled (EF feature) Use it only when you load record(s) only for read-only operations
        /// </summary>
        IQueryable<T> TableNoTracking { get; }

        #endregion
    }
}
