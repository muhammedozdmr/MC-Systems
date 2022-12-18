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
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.FirstName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);

            builder.Property(e=>e.LastName)
                .IsRequired()
                .IsUnicode().HasMaxLength(50);

            builder.Property(e => e.DateOfBirth).IsRequired().HasColumnType("date");
            builder.Property(e => e.HireDate).IsRequired().HasColumnType("date");
        }
    }
}
