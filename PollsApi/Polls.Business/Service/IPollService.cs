using Polls.Core.DTOs.VoteDto;

namespace Polls.Business.Service;

public interface IPollService<TDto, TInputDto, TUpdateDto> : IService<TDto, TInputDto, TUpdateDto>
{
    Task<VoteDto> Vote(VoteInsertDto voteInsertDto);
}