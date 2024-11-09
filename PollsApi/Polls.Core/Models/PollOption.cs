using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Polls.Core.Models;

public class PollOption
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PollOptionId { get; set; }
    
    public string Name { get; set; }
    
    [DeniedValues(0)]
    public int Votes { get; set; }
}