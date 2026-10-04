using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Models;

namespace CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Repos.Interface
{
    public interface IVehichleRepo : IGenaricRepo<Vehicle>
    {

        ICollection<Vehicle> GetAvailableVehicles();

       
    }
}
