using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Type = RequestMe.Repository.Entities.Type;

namespace RequestMe.Repository.EntityConfigurations;

public class TypeConfiguration : IEntityTypeConfiguration<Type>
{
    public void Configure(EntityTypeBuilder<Type> builder)
    {
        
    }
}