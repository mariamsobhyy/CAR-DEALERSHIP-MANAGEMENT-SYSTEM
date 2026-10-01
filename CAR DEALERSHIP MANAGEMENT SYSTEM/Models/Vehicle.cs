using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string Make { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string Model { get; set; } = string.Empty;

        [Required]
        public int Year { get; set; }

        [MaxLength(50)]
        public string? Color { get; set; }

        [Required ,Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Required, Range(0, int.MaxValue)]
        public int Mileage { get; set; }

        [Required, MaxLength(17)]
        public string VIN { get; set; } = string.Empty;

        [MaxLength(30)]
        public string? FuelType { get; set; }

        [MaxLength(30)]
        public string? Transmission { get; set; }

        // public string Status { get; set; } = "Available";

        [Required]
        public string Status { get; set; }

        [ForeignKey("Sale")]
        public int SaleId { get; set; }

        public Sale? Sale { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }

       


    }
}     




