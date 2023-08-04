using System.ComponentModel.DataAnnotations;

namespace BlazorNetAzure2.Models
{
    public class ContactForm
    {
        
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(10)]
        public string Phone { get; set; }

        [Required]
        [MinLength(25)]
        public string Message { get; set; }

        [Required]
        [StringLength(7)]
        public string Color { get; set; }

    }
}
