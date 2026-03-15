using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RequestMe.Repository.Entities;

namespace RequestMe.Repository.EntityConfigurations;

public class SongRequestConfiguration : IEntityTypeConfiguration<SongRequest>
{
    public void Configure(EntityTypeBuilder<SongRequest> builder)
    {
        
    }
}