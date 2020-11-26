using System.ComponentModel.DataAnnotations;

namespace RealEstateWeb.Models
{
    public class ContactUs
    {
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Phone]
        [StringLength(10)]

        public string PhoneNumber { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(500)]
        public string Message { get; set; }


    }
}
