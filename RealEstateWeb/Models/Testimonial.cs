using System.ComponentModel.DataAnnotations;

namespace RealEstateWeb.Models
{
    public class Testimonial
    {
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }
        public string Rating { get; set; }

    }
}
