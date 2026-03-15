using Microsoft.EntityFrameworkCore;
using RequestMe.Repository.Entities;
using RequestMe.Repository.EntityConfigurations;
using Type = System.Type;

namespace RequestMe.Repository;

public class RequestMeDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    
    public DbSet<Club> Clubs { get; set; }

    public DbSet<Party> Parties { get; set; }
    
    public DbSet<SongRequest> SongRequests { get; set; }
    
    public DbSet<Type> Types { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClubConfiguration());
        modelBuilder.ApplyConfiguration(new PartyConfiguration());
        modelBuilder.ApplyConfiguration(new SongRequestConfiguration());
        modelBuilder.ApplyConfiguration(new TypeConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        
        base.OnModelCreating(modelBuilder);
    }
}