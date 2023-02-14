using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVCForTraining.Models
{
    public class ChangePasswordModel
    {
        [Required(ErrorMessage = "Enter a name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Enter a password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [MinLength(5, ErrorMessage = "Password must be greater than or equal to 5 characters")]
        public string NewPassword { get; set; }
    }
}
