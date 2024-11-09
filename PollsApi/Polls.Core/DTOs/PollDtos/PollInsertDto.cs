using Polls.Core.DTOs.PollOptionDtos;

namespace Polls.Core.DTOs;

public class PollInsertDto
{
    public string Name { get; set; }

    private ICollection<PollOptionInsertDto> options { get; set; }
}