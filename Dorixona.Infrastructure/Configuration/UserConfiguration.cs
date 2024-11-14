using Dorixona.Domain.Models.UserModel;
using Dorixona.Domain.Models.UserModel.Proporties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dorixona.Infrastructure.Configuration;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");

        builder.HasKey(user => user.Id);

        builder.Property(user => user.FullName)
            .HasMaxLength(200)
            .HasConversion(fullName => fullName.value, value => new FullName(value));

        builder.Property(user => user.PhoneNumber)
            .HasMaxLength(200)
            .HasConversion(phoneNumber => phoneNumber.value, value => new PhoneNumber(value));

        builder.Property(user => user.Username)
            .HasMaxLength(200)
            .HasConversion(username => username.value, value => new Username(value));

        builder.Property(user => user.Password)
            .HasMaxLength(200)
            .HasConversion(password => password.value, value => new Password(value));

        builder.Property(user => user.UserType)
            .HasMaxLength(200)
            .HasConversion(userType => userType.value, value => new UserType(value));
    }
}
