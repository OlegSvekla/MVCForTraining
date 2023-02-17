using Microsoft.AspNetCore.Identity;

namespace MVCForTraining.Models
{
    public class User : IdentityUser
    {
        public int Age { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        //public int CreditCard { get; set; }

        
    }
}
