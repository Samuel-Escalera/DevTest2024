using Polls.Core.Models;

namespace Polls.Core.MemoriStorage;

public class PollsMemoryStorageContext
{
    public IEnumerable<Poll> Polls { get; set; }

    public PollsMemoryStorageContext()
    {
        Polls = new List<Poll>();
    }
}