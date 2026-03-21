using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RequestMe.Domain.Entities;

namespace RequestMe.Infrastructure.Persistence.Configurations;

public class SongRequestConfiguration : IEntityTypeConfiguration<SongRequest>
{
    public void Configure(EntityTypeBuilder<SongRequest> builder)
    {
        builder.ToTable("SongRequests");
        builder.HasKey(sr => sr.PartyId);
        builder.Property(sr => sr.Tip).HasPrecision(7, 2);
        
        builder
            .HasOne(sr => sr.User)
            .WithMany(u => u.SongRequests)
            .HasForeignKey(sr => sr.UserId);

        builder
            .HasOne(sr => sr.Party)
            .WithMany(p => p.SongRequests)
            .HasForeignKey(sr => sr.PartyId);;
    }
}