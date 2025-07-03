using System.ComponentModel.DataAnnotations;

namespace AspNetDevNetwork.Models
{
    public class Developer
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Only letters and spaces allowed")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [StringLength(254, ErrorMessage = "Email cannot be longer than 254 characters")]
        public string Email { get; set; }
    }
}
