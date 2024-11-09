namespace Polls.DataAccess.Repository;

public interface IPollOptionRepository<TEntity> : IRepository<TEntity>
{
    Task<TEntity> sumAVote (TEntity pollOption);
}