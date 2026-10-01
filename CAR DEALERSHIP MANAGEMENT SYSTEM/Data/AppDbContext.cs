using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Models;
using Microsoft.EntityFrameworkCore;

namespace CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Data
{
    public class AppDbContext : DbContext
    {
        private readonly AppDbContext _context;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<CustomerProfile> CustomerProfiles { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Sale> Sales { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.Category)
                .WithMany(c => c.Vehicles)
                .HasForeignKey(v => v.CategoryId);


            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Customer)
                .WithMany(c => c.Sales)
                .HasForeignKey(s => s.CustomerId);

            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Employee)
                .WithMany(e => e.Sales)
                .HasForeignKey(s => s.EmployeeId);

            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Vehicle)
                .WithOne(v => v.Sale);

            modelBuilder.Entity<CustomerProfile>()
                .HasOne(cp => cp.Customer)
                .WithOne(c => c.CustomerProfile);


               modelBuilder.Entity<Category>()
                .HasIndex(c => c.Name)
                .IsUnique();

              modelBuilder.Entity<Vehicle>()
                .HasIndex(v => v.VIN)
                .IsUnique();

            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.Email)
                .IsUnique();

            modelBuilder.Entity<Customer>() 
                .HasIndex(c => c.DriverLicenseNumber)
                .IsUnique();

            modelBuilder.Entity<Employee>()
                .HasIndex(e => e.Email)
                .IsUnique();

            modelBuilder.Entity<Vehicle>()
                .Property(p => p.Price)
                .HasPrecision (12, 2);

            modelBuilder.Entity<Sale>()
                .Property(p => p.SalePrice)
                .HasPrecision(12, 2);

             modelBuilder.Entity<Vehicle>()
                .Property(v => v.Status)
                .HasDefaultValue("Available");

             
            modelBuilder.Entity<Category>()
                .HasData
                (
                    new Category { Id = 1, Name = "Sedan", Description = "Comfortable passenger cars" },
                    new Category { Id = 2, Name = "SUV", Description = "Sport utility vehicles" },
                    new Category { Id = 3, Name = "Hatchback", Description = "Compact practical cars" }
                  
                );

            modelBuilder.Entity<Vehicle>()
                .HasData
                (
                    new Vehicle { Id = 1, Make = "Toyota", Model = "Corolla", Year = 2024, Color = "White", Mileage = 12000, VIN = "1HGCM82633A123456", Price = 650000, CategoryId = 1 },
                    new Vehicle { Id = 2, Make = "Hyundai", Model = "Elantra", Year = 2023, Color = "Black", Mileage = 18000, VIN = "1HGCM82633A654321", Price = 590000, CategoryId = 2 },
                    new Vehicle { Id = 3, Make = "Kia", Model = "Sportag", Year = 2024, Color = "Gray", Mileage = 9000, VIN = "1HGCM82633A987654", Price = 980000, CategoryId = 3 }

                );




























        }
    }
}
