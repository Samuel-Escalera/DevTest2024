using AutoMapper;
using Polls.Core.DTOs;
using Polls.Core.Models;
using Polls.DataAccess.Repository;

namespace Polls.Business.Service;

public class PollService : IPollService<PollDto, PollInsertDto, PollUpdateDto>
{
    private IPollRepository<Poll> _pollRepository;
    private IMapper _mapper;

    public PollService(IPollRepository<Poll> pollRepository, IMapper mapper)
    {
        _pollRepository = pollRepository;
        _mapper = mapper;
    }
    public async Task<IEnumerable<PollDto>> Get()
    {
       var polls = await _pollRepository.Get();

       var pollDtos = _mapper.Map<IEnumerable<PollDto>>(polls);

       return pollDtos;
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