using Polls.Core.Models;

namespace Polls.DataAccess.Repository;

public interface IPollRepository<TEntity> : IRepository<TEntity>
{
    Task<Vote> Vote( Vote vote );
}