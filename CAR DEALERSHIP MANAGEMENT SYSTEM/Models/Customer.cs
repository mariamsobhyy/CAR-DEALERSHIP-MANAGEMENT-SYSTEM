using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string FullName { get; set; }

        [Required ,EmailAddress]
        public string Email { get; set; }

        [Required, MaxLength(20)]
        public string Phone { get; set; }

        [Required, MaxLength(30)]
        public string DriverLicenseNumber { get; set; }

        [ForeignKey ("CustomerProfile")]
        public int CustomerProfileId { get; set; }

        public CustomerProfile? CustomerProfile { get; set; }

        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }
}
