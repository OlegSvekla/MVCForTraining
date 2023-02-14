using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVCForTraining.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Enter your name")]
        
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter a password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
