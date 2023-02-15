using Microsoft.AspNetCore.Identity;

namespace MVCForTraining.Interfaces
{
    public interface IUserValidator<TUser> where TUser : class
    {
        Task<IdentityResult> ValidateAsync(UserManager<TUser> manager, TUser user);
    }
}
