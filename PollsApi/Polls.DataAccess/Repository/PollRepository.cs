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
        => await _context.Polls.ToListAsync();

    public async Task<Poll> Add(Poll poll)
    {
        _context.Polls.Add(poll);
        _context.SaveChanges();

        return poll;
    }

    public Task Save()
    => _context.SaveChangesAsync();
    

    public async Task<Vote> Vote(Vote vote)
    {
        _context.Votes.Add(vote);
        _context.SaveChanges();
        
        return vote;
        
    }
}