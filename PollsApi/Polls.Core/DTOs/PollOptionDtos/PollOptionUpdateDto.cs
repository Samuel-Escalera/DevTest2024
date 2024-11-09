namespace Polls.Core.DTOs.PollOptionDtos;

public class PollOptionUpdateDto
{
    public int PollOptionId { get; set; }
    public string Name { get; set; }
    public int Votes { get; set; }
}