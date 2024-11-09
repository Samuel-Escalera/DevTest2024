using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Polls.Core.Models;

public class PollOption
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PollOptionId { get; set; }
    public string Name { get; set; }
    public int Votes { get; set; }
    
    
    public int PollId { get; set; }
    
    [ForeignKey("PollId")]
    public virtual Poll Poll { get; set; }
}