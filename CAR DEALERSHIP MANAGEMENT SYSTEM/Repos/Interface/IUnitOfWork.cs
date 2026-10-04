using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Models;

namespace CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Repos.Interface
{
    public interface IUnitOfWork
    {
        IGenaricRepo<Employee> Employees { get; }
        IGenaricRepo<CustomerProfile> CustomerProfiles { get; }
        IGenaricRepo<Vehicle> Vehicles { get; }
        IGenaricRepo<Category> Categories { get; }

        IGenaricRepo<Sale> Sales { get; }

        IGenaricRepo<Customer> Customers { get; }
        void Save();
    }
}
