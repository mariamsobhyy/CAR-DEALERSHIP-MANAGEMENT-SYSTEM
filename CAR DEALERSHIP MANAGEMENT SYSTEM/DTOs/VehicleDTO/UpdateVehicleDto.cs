using System.ComponentModel.DataAnnotations;

namespace CAR_DEALERSHIP_MANAGEMENT_SYSTEM.DTOs.VehicleDTO
{
    public class UpdateVehicleDto
    {
        [Required, MaxLength(100)]
        public string Make { get; set; }
        [Required, MaxLength(100)]
        public string Model { get; set; }
        [Required]
        public int Year { get; set; }
        [Required, MaxLength(20)]
        public string VIN { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
