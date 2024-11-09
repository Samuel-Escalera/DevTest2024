using Polls.Core.Models;

namespace Polls.Core.MemoriStorage;

public class PollsList
{
    public IEnumerable<Poll> Polls { get; set; }
}