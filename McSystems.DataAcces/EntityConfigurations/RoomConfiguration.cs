using McSystems.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSystems.DataAccess.EntityConfigurations
{
    internal class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            //builder.ToTable(nameof(Room)); // sınf adnıda doğru yazdysan Table ismini bu şekilde nameof helpkey ile yazmak
            //daha düzgün hardcode string aşağıdaki gibi yazma hoş değil
            builder.ToTable("Room"); 
            builder.HasKey(r => r.Id);
            //İkili Unique Key oluşturmak
            builder.HasIndex(room => new
            {
                room.Floor,
                room.Number
            }).IsUnique();
            //builder.Property(r => r.Number).IsRequired().HasColumnType("tinyint");
            //builder.Property(r => r.Floor).IsRequired().HasColumnType("tinyint");

            //Eğer FK kurgulanacak Entity sınıflarn her ikisinde de Navigation
            //property tanımlanmamışsa
            builder.HasMany<Reservation>().WithOne().HasForeignKey(res => res.RoomId);
            
            builder.Property(r => r.Description).IsRequired().HasMaxLength(250);
            builder.Property(r => r.Capacity).IsRequired().HasColumnType("tinyint");
        }
    }
}
