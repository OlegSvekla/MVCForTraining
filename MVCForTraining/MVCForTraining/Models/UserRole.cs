using Microsoft.AspNetCore.Identity;

namespace MVCForTraining.Models
{
    public class UserRole : IdentityRole
    {
        public IdentityRole Role

        {
               // возвращаем значение свойства
            set
            {
                Name = "User";   // устанавливаем новое значение свойства
            }
        }

        public UserRole(IdentityRole role)
        {
            Role = role;
        }
    }
}
