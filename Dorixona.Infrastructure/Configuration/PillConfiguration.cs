using Dorixona.Domain.Models.PillModel;
using Dorixona.Domain.Models.PillModel.Proporties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dorixona.Infrastructure.Configuration;

internal class PillConfiguration : IEntityTypeConfiguration<Pill>
{
    public void Configure(EntityTypeBuilder<Pill> builder)
    {
        builder.ToTable("pills");

        builder.HasKey(pill => pill.Id);

        builder.Property(pill => pill.Name)
            .IsRequired()
            .HasMaxLength(200)
            .HasConversion(name => name.value, value => new Name(value));

        builder.Property(pill => pill.Price)
            .IsRequired()
            .HasMaxLength(200)
            .HasConversion(price => price.value, value => new Price(value));

        builder.Property(pill => pill.Count)
            .IsRequired()
            .HasMaxLength(200)
            .HasConversion(count => count.value, value => new Count(value));
    }
}
