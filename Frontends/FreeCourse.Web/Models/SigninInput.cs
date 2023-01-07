using System.ComponentModel.DataAnnotations;

namespace FreeCourse.Web.Models
{
    public class SigninInput
    {
        [Required]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Display(Name = "Password")]
        [Required]
        public string Password { get; set; }
        [Display(Name = "Remember Me")]
        [Required]
        public bool IsRemember { get; set; }
    }
}
