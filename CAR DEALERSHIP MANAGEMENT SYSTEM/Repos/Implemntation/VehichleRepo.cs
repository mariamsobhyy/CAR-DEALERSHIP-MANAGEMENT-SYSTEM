using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Data;
using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Models;
using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Repos.Interface;
using Microsoft.EntityFrameworkCore;

namespace CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Repos.Implemntation
{
    public class VehichleRepo : GenaricRepo<Vehicle> , IVehichleRepo
    {
        private readonly AppDbContext _context;
        public VehichleRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public ICollection<Vehicle> GetAvailableVehicles()
        {
            throw new NotImplementedException();
        }
    }
}
