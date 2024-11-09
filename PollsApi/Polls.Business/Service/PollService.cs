using Polls.Core.DTOs;

namespace Polls.Business.Service;

public class PollService : IPollService<PollDto, PollInsertDto, PollUpdateDto>
{
    public Task<IEnumerable<PollDto>> Get()
    {
        throw new NotImplementedException();
    }

    public Task<PollDto> Add(PollDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<PollDto> Vote(int id)
    {
        throw new NotImplementedException();
    }
}