using Microsoft.EntityFrameworkCore;
using Polls.Core.Models;

namespace Polls.DataAccess.Repository;

public class PollRepository : IPollRepository<Poll>
{
    private PollDbContext _context;

    public PollRepository(PollDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Poll>> Get()
    {
        var polls = await _context.Polls.ToListAsync();
        
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