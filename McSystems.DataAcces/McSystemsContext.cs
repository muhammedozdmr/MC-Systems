using McSystems.DataAccess.Entities;
using McSystems.DataAccess.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace McSystems.DataAccess
{
    public class McSystemsContext : DbContext
    {
        private const string ConnectionString = "Server=.;Database=McSystems;Integrated Security=true";
        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Room>Rooms { get; set; }
        public DbSet<Reservation>Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Fluent API
            //Migrationdan önce bu şekilde özelliklerini belirtebilirim.
            modelBuilder.Entity<Country>().HasKey(entity => entity.Id);
            modelBuilder.Entity<Country>()
                .Property(c => c.Name) //Name propertysi kolonunu yapılandır
                .IsRequired() //NotNull gereklidir demek
                .HasColumnType("varchar(100)");
            //.IsUnicode(false)
            //.HasMaxLength(100);
            modelBuilder.Entity<Country>().ToTable("Country");

            //Dene amaçlı test verileri
            //Seed Data (Dummy Data)
            modelBuilder.Entity<Country>().HasData(
                new Country() { Id=1, Name="Türkiye"},
                new Country() { Id=2, Name="Amerika"},
                new Country() { Id=3, Name="Arjantin"},
                new Country() { Id=4, Name="Fransa"},
                new Country() { Id=5, Name="İtalya"},
                new Country() { Id=6, Name="Almanya"},
                new Country() { Id=7, Name="Rusya"},
                new Country() { Id=8, Name="İngiltere"},
                new Country() { Id=9, Name="İsveç"},
                new Country() { Id=10, Name="Danimarka"}
               );

            //1. Yöntem
            //Customer -> Country arasındaki FK tanımı için gerekli
            //yapılandırmayı Country tarafından bakarak yapsaydım.
            //modelBuilder.Entity<Country>()
            //    .HasMany(country => country.Customers)
            //    .WithOne(customer => customer.Country)
            //    .HasForeignKey(customer => customer.CountryId)
            //    .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
        }
    }
}
