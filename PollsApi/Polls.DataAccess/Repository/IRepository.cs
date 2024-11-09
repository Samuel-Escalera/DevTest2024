namespace Polls.DataAccess.Repository;

public interface IRepository<TEntity>
{
    Task<IEnumerable<TEntity>> Get();
    Task<TEntity> Add(TEntity entity);

    Task Save();
}