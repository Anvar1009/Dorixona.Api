using Dorixona.Domain.Models.EmployeModel;
using Dorixona.Domain.Models.EmployeModel.Proporties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.Infrastructure.Configuration
{
    internal class EmployeConfiguration : IEntityTypeConfiguration<Employe>
    {
        public void Configure(EntityTypeBuilder<Employe> builder)
        {
            builder.ToTable("employe");

            builder.HasKey(key => key.Id);



            builder.Property(emp => emp.Salary)
            .HasMaxLength(200)
            .HasConversion(quantity => quantity.salary, value => new Salary(value));

            builder.Property(emp => emp.FirstName)
           .HasMaxLength(200)
           .HasConversion(customerName => customerName.name, value => new FirstName(value));

            builder.Property(emp => emp.LastName)
           .HasMaxLength(200)
           .HasConversion(customerPhone => customerPhone.lastname, value => new LastName(value));

            builder.Property(emp => emp.PhoneNumber)
           .HasMaxLength(200)
           .HasConversion(deliveryAddress => deliveryAddress.phone, value => new PhoneNumber(value));

            builder.Property(emp => emp.Email)
           .HasMaxLength(200)
           .HasConversion(status => status.email, value => new Email(value));

            builder.Property(emp => emp.DateOfBirth)
           .HasMaxLength(200)
           .HasConversion(empDate => empDate.date, value => new DateOfBirth(value));

            //builder.Property(employee => employee.ShopId)
            //    .HasConversion(shopId => shopId.id, value => new ShopId(value));


            //builder.HasOne<Shop>()
            //    .WithMany()
            //    .HasForeignKey(employee => employee.ShopId)
            //    .IsRequired();


        }
    }
}
