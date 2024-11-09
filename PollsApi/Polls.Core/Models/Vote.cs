using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Polls.Core.Models;

public class Vote
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int VoteId { get; set; }
    
    
    public int PollId { get; set; }
    public int PollOptionId { get; set; }
    public string VoterEmail { get; set; }
    
    [ForeignKey("PollId")]
    public virtual Poll Poll { get; set; }
    [ForeignKey("PollOptionId")]
    public virtual PollOption PollOption { get; set; }
    
}