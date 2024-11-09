namespace Polls.Core.Models;

public class Vote
{
    public int VoteId { get; set; }
    public int PollId { get; set; }
    public int PollOptionId { get; set; }
    public string VoterEmail { get; set; }
    
}