using Dorixona.Domain.Models.OrderModel;
using Dorixona.Domain.Models.OrderModel.Proporties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dorixona.Infrastructure.Configuration;

internal class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("orders");

        builder.HasKey(order => order.Id);

        builder.Property(order => order.CustomerId)
            .IsRequired()
            .HasMaxLength(200)
            .HasConversion(customerId => customerId.value, value => new CustomerId(value));

        builder.Property(order => order.CustomerPhoneNumber)
            .IsRequired()
            .HasMaxLength(200)
            .HasConversion(customerPhoneNumber => customerPhoneNumber.value, value => new CustomerPhoneNumber(value));

        builder.Property(order => order.PillName)
            .IsRequired()
            .HasMaxLength(200)
            .HasConversion(pillName => pillName.value, value => new PillName(value));

        builder.Property(order => order.PillPrice)
            .IsRequired()
            .HasMaxLength(200)
            .HasConversion(pillPrice => pillPrice.value, value => new PillPrice(value));

        builder.Property(order => order.PillCount)
            .IsRequired()
            .HasMaxLength(200)
            .HasConversion(pillCount => pillCount.value, value => new PillCount(value));

        builder.Property(order => order.Address)
            .IsRequired()
            .HasMaxLength(200)
            .HasConversion(address => address.value, value => new Address(value));

        builder.Property(order => order.OrderTime)
            .IsRequired()
            .HasMaxLength(200)
            .HasConversion(orderTime => orderTime.value, value => new OrderTime(value));

        builder.Property(order => order.OrderType)
            .IsRequired()
            .HasMaxLength(200)
            .HasConversion(orderType => orderType.value, value => new OrderType(value));
    }
}
