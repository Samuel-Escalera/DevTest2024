using Polls.Core.DTOs.PollOptionDtos;
using Polls.Core.Models;

namespace Polls.Core.DTOs;

public class PollDto
{
    public int PollId { get; set; }
    public string Name { get; set; }

    private ICollection<PollOptionDto> options { get; set; }
}