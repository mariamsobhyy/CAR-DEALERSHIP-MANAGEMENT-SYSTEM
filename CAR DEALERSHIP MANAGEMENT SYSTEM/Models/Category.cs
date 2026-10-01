using System.ComponentModel.DataAnnotations;

namespace CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        public int vehicleId { get; set; }

        public Vehicle? Vehicle { get; set; }



        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
}
