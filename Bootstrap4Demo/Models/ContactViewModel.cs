using System.ComponentModel.DataAnnotations;

namespace Bootstrap4Demo.Models
{
    public class ContactViewModel
    {
        public ContactViewModel()
        {
            Favorite = string.Empty;
        }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Your Name")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Favorite { get; set; }
        public string Reason { get; set; }
        public string Message { get; set; }
    }
}
