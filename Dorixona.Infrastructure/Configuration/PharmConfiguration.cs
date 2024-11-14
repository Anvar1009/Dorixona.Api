using Dorixona.Domain.Models.PharmModel;
using Dorixona.Domain.Models.PharmModel.Proporties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.Infrastructure.Configuration
{
    public class PharmConfiguration : IEntityTypeConfiguration<Pharm>
    {
        public void Configure(EntityTypeBuilder<Pharm> builder)
        {
            builder.ToTable("pharm");

            // PharmId uchun konvertatsiya
            builder.HasKey(key => key.PharmId);
            builder.Property(emp => emp.PharmId)
                   .HasConversion(
                       id => id.ToString(),       // Saqlash uchun string sifatida o'zgartirish
                       id => new PharmId(Guid.NewGuid())      // Baza o'qilganda asl turga qaytarish
                   );

            // PharmAddress uchun konvertatsiya
            builder.Property(emp => emp.PharmAddress)
                   .HasMaxLength(200)
                   .HasConversion(
                       quantity => quantity.value,
                       value => new PharmAddress(value)
                   );

            // PharmPhoneNumber uchun konvertatsiya
            builder.Property(emp => emp.PharmPhoneNumber)
                   .HasMaxLength(200)
                   .HasConversion(
                       customerName => customerName.value,
                       value => new PharmPhoneNumber(value)
                   );

            // PharmName uchun konvertatsiya
            builder.Property(emp => emp.PharmName)
                   .HasMaxLength(200)
                   .HasConversion(
                       customerPhone => customerPhone.value,
                       value => new PharmName(value)
                   );
        }

    }
}
