using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Polls.Core.Models;

public class Poll
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PollId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<PollOption> options { get; set; }
}