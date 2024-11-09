namespace Polls.Core.DTOs.VoteDto;

public class VoteInsertDto
{
    public int PollId { get; set; }
    public int PollOptionId { get; set; }
    public string VoterEmail { get; set; }

}