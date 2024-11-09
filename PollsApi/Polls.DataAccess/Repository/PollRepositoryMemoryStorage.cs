using Polls.Core.MemoriStorage;
using Polls.Core.Models;

namespace Polls.DataAccess.Repository;

public class PollRepositoryMemoryStorage : IPollRepository<Poll>
{
    private PollsMemoryStorageContext _context;

    public PollRepositoryMemoryStorage(PollsMemoryStorageContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Poll>> Get()
    {
        var polls = _context.Polls.ToList();

        return polls;
    }

    public Task<Poll> Add(Poll entity)
    {
        throw new NotImplementedException();
    }

    public Task<Poll> Vote(int id)
    {
        throw new NotImplementedException();
    }
}