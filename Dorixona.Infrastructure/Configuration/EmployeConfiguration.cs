using Dorixona.Domain.Models.EmployeModel;
using Dorixona.Domain.Models.EmployeModel.Proporties;
using Dorixona.Domain.Models.PharmModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.Infrastructure.Configuration
{
    internal class EmployeConfiguration : IEntityTypeConfiguration<Employe>
    {
        public void Configure(EntityTypeBuilder<Employe> builder)
        {
            builder.ToTable("employe");


            builder.HasKey(key => key.Id).HasName("Id");
            builder.Property(e => e.Id)
                .HasColumnName("Id"); // Ma'lumotlar bazasidagi ustun nomiga mos keltirish


            builder.Property(emp => emp.Salary)
                .HasColumnName("Salary")
                .HasMaxLength(200)
                .HasConversion(quantity => quantity.salary, value => new Salary(value));

            builder.Property(emp => emp.FirstName)
                .HasColumnName("FirstName")
                .HasMaxLength(200)
                .HasConversion(customerName => customerName.name, value => new FirstName(value));

            builder.Property(emp => emp.LastName)
                .HasColumnName("LastName")
                .HasMaxLength(200)
                .HasConversion(customerPhone => customerPhone.lastname, value => new LastName(value));

            builder.Property(emp => emp.PhoneNumber)
                .HasColumnName("PhoneNumber")
                .HasMaxLength(200)
                .HasConversion(deliveryAddress => deliveryAddress.phone, value => new PhoneNumber(value));

            builder.Property(emp => emp.Email)
                .HasMaxLength(200)
                .HasColumnName("Email")
                .HasConversion(status => status.email, value => new Email(value));

            builder.Property(emp => emp.DateOfBirth)
                .HasMaxLength(200)
                .HasConversion(empDate => empDate.date, value => new DateOfBirth(value));
            builder.Property(e => e.DateOfBirth)
                .HasColumnName("DateOfBirth");

            builder.Property(employee => employee.PharmId)
                .HasColumnName("PharmId")
             .HasConversion(
                 pharm => pharm.ToString(), // Murakkab turdan oddiy turga aylantirish (masalan, string)
                 value => new PharmId(Guid.NewGuid()) // Oddiy turdan murakkab turga qayta aylantirish
             );

        }
    }
}
