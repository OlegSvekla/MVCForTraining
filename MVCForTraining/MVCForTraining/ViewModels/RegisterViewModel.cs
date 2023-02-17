using System.ComponentModel.DataAnnotations;

namespace MVCForTraining.ViewModels
{
    public class RegisterViewModel
    {

        

        [Required(ErrorMessage = "Enter a name")]
        [MaxLength(20, ErrorMessage = "The name must be less than 20 characters long")]
        [MinLength(3, ErrorMessage = "The name must be longer than 3 characters")]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }



        [Required(ErrorMessage = "Enter a name")]
        [MaxLength(20, ErrorMessage = "The name must be less than 20 characters long")]
        [MinLength(3, ErrorMessage = "The name must be longer than 3 characters")]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$",
            ErrorMessage = "E-mail is not valid")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Phone]
        //[StringLength(13, MinimumLength = 13)]
        //[RegularExpression(@"^\+[1-9]\d{3}-\d{3}-\d{4}$")]
        public string PhoneNumber { get; set; }
        
        
        //[CreditCard]
        //public int CreditCard { get; set; }

        [Required]
        [Display(Name = "Age")]
        [Range(1, 100)]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Поле {0} должно иметь минимум {2} и максимум {1} символов.", MinimumLength = 5)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "PasswordConfirm")]
        public string PasswordConfirm { get; set; }
    }
}
