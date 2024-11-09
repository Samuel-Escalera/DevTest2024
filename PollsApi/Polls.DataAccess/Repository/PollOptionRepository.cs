

using Polls.Core.Models;

namespace Polls.DataAccess.Repository;

public class PollOptionRepository : IPollOptionRepository<PollOption>
{
    private PollDbContext _context;

    public PollOptionRepository(PollDbContext context)
    {
        _context = context;
    }

    public Task<IEnumerable<PollOption>> Get()
    {
        throw new NotImplementedException();
    }

    public async Task<PollOption> Add(PollOption pollOption)
    { 
        _context.PollOptions.Add(pollOption);

        return pollOption;
    }

    public Task Save()
    => _context.SaveChangesAsync();
    
}
