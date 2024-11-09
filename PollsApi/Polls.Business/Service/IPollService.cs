namespace Polls.Business.Service;

public interface IPollService<TDto, TInput, TUpdate> : IService<TDto, TInput, TUpdate>
{
    Task<TDto> Vote(int id);
}