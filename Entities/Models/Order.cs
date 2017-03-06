using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Order
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int ID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public int Zip { get; set; }

        [Required]
        public int Phone { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        public int CardNumber { get; set; }

        [Required]
        public int CardExpirationMonth { get; set; }

        [Required]
        public int CardExpirationYear { get; set; }

        [Required]
        public int CardSecurityCode { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Price { get; set; }

        public int Status { get; set; }
    }
}
