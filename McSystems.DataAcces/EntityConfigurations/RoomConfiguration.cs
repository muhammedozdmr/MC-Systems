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
            builder.HasData(
                new Room() { Id = 1, Floor = 1, Number = 1, Capacity = 2, Description = "2 kişilik çift yataklı oda", RoomType = RoomType.DoubleRoom },
                new Room() { Id = 2, Floor = 1, Number = 2, Capacity = 2, Description = "2 kişilik çift yataklı oda", RoomType = RoomType.DoubleRoom },
                new Room() { Id = 3, Floor = 1, Number = 3, Capacity = 2, Description = "2 kişilik tek yataklı oda", RoomType = RoomType.SingleRoom },
                new Room() { Id = 4, Floor = 2, Number = 1, Capacity = 4, Description = "2 kişilik 2 adet çift yataklı oda", RoomType = RoomType.CornerRoom },
                new Room() { Id = 5, Floor = 2, Number = 2, Capacity = 5, Description = "deniz manzaralı 5 kişilik çift yataklı oda", RoomType = RoomType.JuniorSuite },
                new Room() { Id = 6, Floor = 2, Number = 3, Capacity = 6, Description = "çift yataklı aile odası", RoomType = RoomType.FamilyRoom },
                new Room() { Id = 7, Floor = 3, Number = 1, Capacity = 6, Description = "çift yataklı oda suite", RoomType = RoomType.KingSuite },
                new Room() { Id = 8, Floor = 3, Number = 2, Capacity = 4, Description = "4 kişilik çift yataklı oda", RoomType = RoomType.QuadRoom },
                new Room() { Id = 9, Floor = 3, Number = 3, Capacity = 4, Description = "4 kişilik çift yataklı oda", RoomType = RoomType.TripleRoom },
                new Room() { Id = 10, Floor = 4, Number = 1, Capacity = 10, Description = "10 kişilik çift yataklı oda", RoomType = RoomType.KingSuite },
                new Room() { Id = 11, Floor = 4, Number = 2, Capacity = 4, Description = "4 kişilik çift yataklı oda", RoomType = RoomType.DublexRoom },
                new Room() { Id = 12, Floor = 4, Number = 3, Capacity = 8, Description = "8 kişilik çift yataklı oda", RoomType = RoomType.FamilyRoom },
                new Room() { Id = 13, Floor = 5, Number = 1, Capacity = 2, Description = "2 kişilik çift yataklı oda", RoomType = RoomType.KingSuite },
                new Room() { Id = 14, Floor = 5, Number = 2, Capacity = 3, Description = "3 kişilik çift yataklı juniorsuite oda", RoomType = RoomType.JuniorSuite },
                new Room() { Id = 15, Floor = 5, Number = 3, Capacity = 6, Description = "6 kişilik çift yataklı kingsuite oda", RoomType = RoomType.KingSuite }
                );

        }
    }
}
