namespace Polls.Core.DTOs.VoteDto;

public class VoteDto
{
    public int VoteId { get; set; }
    public int PollId { get; set; }
    public int PollOptionId { get; set; }
    public string VoterEmail { get; set; }
    
}