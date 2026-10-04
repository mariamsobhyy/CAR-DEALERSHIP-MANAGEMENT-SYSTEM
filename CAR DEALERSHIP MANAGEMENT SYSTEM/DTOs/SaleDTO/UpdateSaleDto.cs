using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Models;
using System.ComponentModel.DataAnnotations;

namespace CAR_DEALERSHIP_MANAGEMENT_SYSTEM.DTOs.SaleDTO
{
    public class UpdateSaleDto
    {
        public DateTime SaleDate { get; set; }

        [Required, Range(0, double.MaxValue)]
        public decimal SalePrice { get; set; }

        [Required, MaxLength(30)]

        public string PaymentMethod { get; set; }

        [MaxLength(30)]
        public string Notes { get; set; }

        public int CustomerId { get; set; }

        public Customer? Customer { get; set; }

        public int EmployeeId { get; set; }

        public Employee? Employee { get; set; }

        public int VehicleId { get; set; }

        public Vehicle? Vehicle { get; set; }
    }
}
