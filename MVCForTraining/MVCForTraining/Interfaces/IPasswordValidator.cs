using Microsoft.AspNetCore.Identity;

namespace MVCForTraining.Interfaces
{
    public interface IPasswordValidator<T> where T : class
    {

        Task<IdentityResult> ValidateAsync(UserManager<T> manager, T user, string password);
    }
}
