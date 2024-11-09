using AutoMapper;
using Polls.Core.DTOs.PollOptionDtos;
using Polls.Core.Models;
using Polls.DataAccess.Repository;

namespace Polls.Business.Service;

public class PollOptionService : IPollOptionService<PollOptionDto, PollOptionInsertDto, PollOptionUpdateDto>
{
    private IPollOptionRepository<PollOption> _repository;
    private IMapper _mapper;

    public PollOptionService(IPollOptionRepository<PollOption> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    public Task<IEnumerable<PollOptionDto>> Get()
    {
        throw new NotImplementedException();
    }

    public async Task<PollOptionDto> Add(PollOptionInsertDto pollOptionInsertDto)
    {
        
        var pollOption = _mapper.Map<PollOption>(pollOptionInsertDto);
        
        await _repository.Add(pollOption);
        await _repository.Save();
        
        var pollOptionDto = _mapper.Map<PollOptionDto>(pollOption);
        
        return pollOptionDto;
    }
}