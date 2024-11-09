using Microsoft.EntityFrameworkCore;
using Polls.Core.Models;

namespace Polls.DataAccess;

public class PollDbContext : DbContext
{
    public PollDbContext(DbContextOptions<PollDbContext> options) 
        : base(options)
    {}
    
    public DbSet<Poll> Polls { get; set; }
    public DbSet<PollOption> PollOptions { get; set; }
    public DbSet<Vote> Votes { get; set; }

}