using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Data;
using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Models;
using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Repos.Interface;

namespace CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Repos.Implemntation
{
    public class UnitOfWork : IUnitOfWork
    {
        
        private readonly AppDbContext _context;
        public IGenaricRepo<Employee> Employees { get; }
        public IGenaricRepo<CustomerProfile> CustomerProfiles { get; }
        public IGenaricRepo<Vehicle> Vehicles { get; }
        public IGenaricRepo<Category> Categories { get; }
        public IGenaricRepo<Sale> Sales { get; }
        public IGenaricRepo<Customer> Customers { get; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;

            Employees = new GenaricRepo<Employee>(_context);

            CustomerProfiles = new GenaricRepo<CustomerProfile>(_context);

            Vehicles = new GenaricRepo<Vehicle>(_context);

            Categories = new GenaricRepo<Category>(_context);

            Sales = new GenaricRepo<Sale>(_context);

            Customers = new GenaricRepo<Customer>(_context);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
