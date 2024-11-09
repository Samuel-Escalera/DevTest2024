
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Polls.Business.Service;
using Polls.Core.DTOs;
using Polls.Core.DTOs.PollOptionDtos;
using Polls.Core.DTOs.VoteDto;

namespace Polls.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class PollsController
{
    private IPollService<PollDto, PollInsertDto, PollUpdateDto> _pollService;
    private IPollOptionService<PollOptionDto, PollOptionInsertDto, PollOptionUpdateDto> _optionService;

    public PollsController(IPollService<PollDto, PollInsertDto, PollUpdateDto> pollService,
        IPollOptionService<PollOptionDto, PollOptionInsertDto, PollOptionUpdateDto> pollOptionService)
    {
        _pollService = pollService;
        _optionService = pollOptionService;
    }
    
    [HttpGet]   
    public async Task<IEnumerable<PollDto>> Get()
    {
        var polls = await _pollService.Get();
        
        return polls;
    }

    [HttpPost]
    public async Task<ActionResult<PollDto>> Add(PollInsertDto pollInsertDto)
    {
        var pollDto = await _pollService.Add(pollInsertDto);
        
        return pollDto;
    }

    [HttpPost("{id}/votes")]
    public async Task<ActionResult<VoteDto>> Vote(int id, VoteInsertDto voteInsertDto)
    {
        var voteDto = await _pollService.Vote(voteInsertDto);
        
        return voteDto;
    }
}