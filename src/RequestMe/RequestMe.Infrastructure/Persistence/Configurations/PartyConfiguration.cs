using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RequestMe.Domain.Entities;

namespace RequestMe.Infrastructure.Persistence.Configurations;

public class PartyConfiguration : IEntityTypeConfiguration<Party>
{
    public void Configure(EntityTypeBuilder<Party> builder)
    {
        builder.ToTable("Parties");
        builder.HasKey(x => x.Id);
        
        builder
            .HasOne(p => p.Club)
            .WithMany(c => c.Parties)
            .HasForeignKey(c => c.ClubId);;
    }
}