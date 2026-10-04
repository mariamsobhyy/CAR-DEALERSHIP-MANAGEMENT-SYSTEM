using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Models;
using Microsoft.EntityFrameworkCore;

namespace CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Data
{
    public class AppDbContext : DbContext
    {
        

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
                .HasForeignKey(v => v.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Customer)
                .WithMany(c => c.Sales)
                .HasForeignKey(s => s.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Employee)
                .WithMany(e => e.Sales)
                .HasForeignKey(s => s.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Vehicle)
                .WithOne(v => v.Sale)
                .HasForeignKey<Sale>(s => s.VehicleId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CustomerProfile>()
                .HasOne(cp => cp.Customer)
                .WithOne(c => c.CustomerProfile)
                .HasForeignKey<CustomerProfile>(cp => cp.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);


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
                    new Vehicle { Id = 1, Make = "Toyota", Model = "Corolla", Year = 2024, Color = "White" , Mileage = 12000, VIN = "1HGCM82633A123456", Price = 650000, FuelType = "Petrol" , Transmission = "Automatic" , Status = "Available" ,CategoryId = 1 },
                    new Vehicle { Id = 2, Make = "Hyundai", Model = "Elantra", Year = 2023, Color = "Black", Mileage = 18000, VIN = "1HGCM82633A654321", Price = 590000, FuelType = "Petrol", Transmission = "Automatic", Status = "Available", CategoryId = 2 },
                    new Vehicle { Id = 3, Make = "Kia", Model = "Sportag", Year = 2024, Color = "Gray", Mileage = 9000, VIN = "1HGCM82633A987654", Price = 980000, FuelType = "Petrol", Transmission = "Automatic", Status = "Available",CategoryId = 3 }

                );

            modelBuilder.Entity<Customer>()
                .HasData
                (
                    new Customer { Id = 1, FullName = "Ahmed Hassan", Email = "ahmed.hassan@example.com" , Phone = "01010000001", DriverLicenseNumber = "DL100001" },
                    new Customer { Id = 2, FullName = "Mona Adel", Email = "mona.adel@example.com" , Phone = "01010000002", DriverLicenseNumber = "DL100002" },
                    new Customer { Id = 3, FullName = "Omar Khaled", Email = "omar.khaled@example.com" , Phone = "01010000003", DriverLicenseNumber = "DL100003" }
                );

               modelBuilder.Entity<CustomerProfile>()

                .HasData
                   (
                   new CustomerProfile { Id = 1, CustomerId = 1, Address = "12 Nile St. " , City =" Cairo", Nationality = "Egyptian" , DateOfBirth = new DateTime(1992 , 03 , 12) },
                   new CustomerProfile { Id = 2, CustomerId = 2, Address = "34 Tahrir St. " , City =" Cairo", Nationality = "Egyptian" , DateOfBirth = new DateTime(1990 , 07 , 22) },
                   new CustomerProfile { Id = 3, CustomerId = 3, Address = "18 El Nasr  St. ", City =" Cairo", Nationality = "Egyptian" , DateOfBirth = new DateTime(1995 , 11 , 05) }
                   );


            modelBuilder.Entity<Employee>()
                .HasData
                (
                    new Employee { Id = 1, FullName = "Mostafa Nabil" , Position = "Sales Manager", Email = "mostafa.nabil@autodrive.com", Phone = "01010000004", HireDate = new DateTime(2021 ,01 , 10) },
                    new Employee { Id = 2, FullName = "Aya Emad" , Position = "Sales Consultant" , Email = "aya.emad@autodrive.com" , Phone = "01010000005", HireDate = new DateTime(2022 , 03 , 15) },
                    new Employee { Id = 3, FullName = " Hassan Ali", Position = "Sales Consultant" , Email = "hassan.ali@autodrive.com" , Phone = "01010000006", HireDate = new DateTime(2023 , 05 , 20) }
                );

              modelBuilder.Entity<Sale>()
                .HasData
                (
                    new Sale { Id = 1, CustomerId = 1, EmployeeId = 1, VehicleId = 1, SaleDate = new DateTime(2026 - 08 - 15), SalePrice = 1750000 ,PaymentMethod = "Bank Transfer"  ,  Notes = "Completed sale" },
                    new Sale { Id = 2, CustomerId = 2, EmployeeId = 2, VehicleId = 2, SaleDate = new DateTime(2026 - 08 - 22), SalePrice = 1850000 , PaymentMethod = "Bank Transfer", Notes = "Completed sale" },
                    new Sale { Id = 3, CustomerId = 3, EmployeeId = 3, VehicleId = 3, SaleDate = new DateTime(2026 - 08 - 30), SalePrice = 1950000 , PaymentMethod = " Cash", Notes = "Completed sale" }
                );




























        }
    }
}
