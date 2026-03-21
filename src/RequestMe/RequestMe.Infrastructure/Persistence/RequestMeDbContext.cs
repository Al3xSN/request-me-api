using Microsoft.EntityFrameworkCore;

namespace RequestMe.Infrastructure.Persistence;

public class RequestMeDbContext(DbContextOptions<RequestMeDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(RequestMeDbContext).Assembly);
        
        base.OnModelCreating(modelBuilder);
    }
}