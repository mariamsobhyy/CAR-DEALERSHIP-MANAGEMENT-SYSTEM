using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Models;
using System.ComponentModel.DataAnnotations;

namespace CAR_DEALERSHIP_MANAGEMENT_SYSTEM.DTOs.CustomerDTO
{
    public class CutomerDto
    {

        [Key]
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string FullName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, MaxLength(20)]
        public string Phone { get; set; }

        [Required, MaxLength(30)]
        public string DriverLicenseNumber { get; set; }


        public CustomerProfile? CustomerProfile { get; set; }
    }
}
