using System.ComponentModel.DataAnnotations;

namespace MVCForTraining.ViewModels
{
    public class LoginViewModel
    {

        
        [EmailAddress]
        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$",
            ErrorMessage = "E-mail is not valid")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Поле {0} должно иметь минимум {2} и максимум {1} символов.", MinimumLength = 5)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "RememberMe?")]
        public bool RememberMe { get; set; }

        public string? ReturnUrl { get; set; }
    }
}
