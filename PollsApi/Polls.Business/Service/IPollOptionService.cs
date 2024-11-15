namespace Polls.Business.Service;

public interface IPollOptionService<TDto, TInsertDto, TUpdateDto> : IService<TDto, TInsertDto, TUpdateDto>
{
    Task<TDto> sumAVote (TUpdateDto pollOptionUpdate);
}