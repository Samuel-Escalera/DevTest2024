using Polls.Core.Models;

namespace Polls.Core.MemoriStorage;

public class PollsMemoryStorageContext
{
    public List<Poll> Polls { get; set; }

    public PollsMemoryStorageContext()
    {
        Polls = new List<Poll>();
    }
}