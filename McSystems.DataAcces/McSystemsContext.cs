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
