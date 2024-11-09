
using Microsoft.AspNetCore.Mvc;
using Polls.Business.Service;
using Polls.Core.DTOs;

namespace Polls.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class PollsController
{
    private IPollService<PollDto, PollInsertDto, PollUpdateDto> _pollService;

    public PollsController(IPollService<PollDto, PollInsertDto, PollUpdateDto> pollService)
    {
        _pollService = pollService;
    }
    
    [HttpGet]
    public async Task<IEnumerable<PollDto>> Get()
    {
        var polls = await _pollService.Get();
        
        return polls;
    }
}