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
    internal class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.ToTable("Reservation");
            builder.HasKey(res => res.Id);
            builder.HasOne(res=>res.Room).WithMany().HasForeignKey(res => res.RoomId);
            builder.HasOne(res=>res.Employee).WithMany().HasForeignKey(res => res.EmployeeId);
            builder.Property(res => res.StartDate).HasColumnType("date");
            builder.Property(res => res.EndDate).HasColumnType("date");
        }
    }
}
