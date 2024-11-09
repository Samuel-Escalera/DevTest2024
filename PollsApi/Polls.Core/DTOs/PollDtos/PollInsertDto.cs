using Polls.Core.DTOs.PollOptionDtos;
using Polls.Core.Models;

namespace Polls.Core.DTOs;

public class PollInsertDto
{
    public string Name { get; set; }

    public ICollection<PollOptionInsertDto> options { get; set; }
}