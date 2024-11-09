namespace Polls.Business.Service;

public interface IService<TDto, TInsertDto, TUpdateDto>
{
    Task<IEnumerable<TDto>> Get();
    Task<TDto> Add(TInsertDto entity);
}