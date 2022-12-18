﻿// <auto-generated />
using System;
using McSystems.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace McSystems.DataAccess.Migrations
{
    [DbContext(typeof(McSystemsContext))]
    [Migration("20221218090946_EntityOptimisations")]
    partial class EntityOptimisations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CustomerReservation", b =>
                {
                    b.Property<int>("CustomersId")
                        .HasColumnType("int");

                    b.Property<int>("ReservationsId")
                        .HasColumnType("int");

                    b.HasKey("CustomersId", "ReservationsId");

                    b.HasIndex("ReservationsId");

                    b.ToTable("CustomerReservation");
                });

            modelBuilder.Entity("McSystems.DataAccess.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Country", (string)null);
                });

            modelBuilder.Entity("McSystems.DataAccess.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("varchar(120)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("IdNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("IdNumber")
                        .IsUnique();

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("McSystems.DataAccess.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("date");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("McSystems.DataAccess.Entities.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("McSystems.DataAccess.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte>("Capacity")
                        .HasColumnType("tinyint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<byte>("Floor")
                        .HasColumnType("tinyint");

                    b.Property<bool>("InMaintenance")
                        .HasColumnType("bit");

                    b.Property<byte>("Number")
                        .HasColumnType("tinyint");

                    b.Property<int>("RoomType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Floor", "Number")
                        .IsUnique();

                    b.ToTable("Room", (string)null);
                });

            modelBuilder.Entity("CustomerReservation", b =>
                {
                    b.HasOne("McSystems.DataAccess.Entities.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("McSystems.DataAccess.Entities.Reservation", null)
                        .WithMany()
                        .HasForeignKey("ReservationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("McSystems.DataAccess.Entities.Customer", b =>
                {
                    b.HasOne("McSystems.DataAccess.Entities.Country", "Country")
                        .WithMany("Customers")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("McSystems.DataAccess.Entities.Reservation", b =>
                {
                    b.HasOne("McSystems.DataAccess.Entities.Room", null)
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("McSystems.DataAccess.Entities.Country", b =>
                {
                    b.Navigation("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
