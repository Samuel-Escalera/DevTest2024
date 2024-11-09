using Polls.Core.Models;

namespace Polls.DataAccess.Repository;

public class PollRepository : IPollRepository<Poll>
{
    private PollDbContext _context;

    public PollRepository(PollDbContext context)
    {
        _context = context;
    }
    public Task<IEnumerable<Poll>> Get()
    {
        throw new NotImplementedException();
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