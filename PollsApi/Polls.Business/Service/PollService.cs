using AutoMapper;
using Polls.Core.DTOs;
using Polls.Core.DTOs.PollOptionDtos;
using Polls.Core.DTOs.VoteDto;
using Polls.Core.Models;
using Polls.DataAccess.Repository;

namespace Polls.Business.Service;

public class PollService : IPollService<PollDto, PollInsertDto, PollUpdateDto>
{
    private IPollRepository<Poll> _pollRepository;
    private IPollOptionService<PollOptionDto, PollOptionInsertDto, PollOptionUpdateDto> _pollOptionService;
    private IMapper _mapper;

    public PollService(IPollRepository<Poll> pollRepository, IMapper mapper,
        IPollOptionService<PollOptionDto, PollOptionInsertDto, PollOptionUpdateDto> pollOptionService)
    {
        _pollRepository = pollRepository;
        _pollOptionService = pollOptionService;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<PollDto>> Get()
    {
       var polls = await _pollRepository.Get();

       var pollDtos = _mapper.Map<IEnumerable<PollDto>>(polls);

       return pollDtos;
    }

    public async Task<PollDto> Add(PollInsertDto pollInsertDto)
    {
        var poll = _mapper.Map<Poll>(pollInsertDto);
        
        await _pollRepository.Add(poll);
        await _pollRepository.Save();
        
        var pollDto = _mapper.Map<PollDto>(poll);
        
        return pollDto;
    }

    public async Task<VoteDto> Vote(VoteInsertDto voteInsertDto)
    {
        var vote = _mapper.Map<Vote>(voteInsertDto);
        
         await _pollRepository.Vote(vote);
        
        var voteDto = _mapper.Map<VoteDto>(vote);

        return voteDto;
    }
}