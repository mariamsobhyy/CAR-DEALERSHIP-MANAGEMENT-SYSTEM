using System.ComponentModel.DataAnnotations;

namespace CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Models
{
    public class CustomerProfile
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(250)]
        public string Address { get; set; }

        [MaxLength(100)]
        public string City { get; set; }

        [MaxLength(50)]
        public string Nationality { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int CustomerId { get; set; }

        public Customer? Customer { get; set; }


    }
}
