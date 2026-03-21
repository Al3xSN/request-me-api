using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RequestMe.Domain.Entities;

namespace RequestMe.Infrastructure.Persistence.Configurations;

public class ClubConfiguration : IEntityTypeConfiguration<Club>
{
    public void Configure(EntityTypeBuilder<Club> builder)
    {
        builder.ToTable("Clubs");
        builder.HasKey(x => x.Id);
        
        builder
            .HasMany(c => c.Parties)
            .WithOne(c => c.Club)
            .HasForeignKey(c => c.ClubId);;
    }
}