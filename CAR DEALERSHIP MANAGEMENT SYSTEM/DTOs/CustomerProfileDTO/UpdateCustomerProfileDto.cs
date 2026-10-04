using System.ComponentModel.DataAnnotations;

namespace CAR_DEALERSHIP_MANAGEMENT_SYSTEM.DTOs.CustomerProfileDTO
{
    public class UpdateCustomerProfileDto
    {
        [Required, MaxLength(250)]
        public string Address { get; set; }

        [MaxLength(100)]
        public string City { get; set; }

        [MaxLength(50)]
        public string Nationality { get; set; }

        public DateTime? DateOfBirth { get; set; }

    }
}
