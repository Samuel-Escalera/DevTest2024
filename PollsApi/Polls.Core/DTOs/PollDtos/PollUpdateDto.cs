using Polls.Core.DTOs.PollOptionDtos;

namespace Polls.Core.DTOs;

public class PollUpdateDto
{
    public int PollId { get; set; }
    public string Name { get; set; }

    private ICollection<PollOptionUpdateDto> options { get; set; }
}