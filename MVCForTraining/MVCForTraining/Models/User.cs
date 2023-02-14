using Microsoft.AspNetCore.Identity;

namespace MVCForTraining.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
