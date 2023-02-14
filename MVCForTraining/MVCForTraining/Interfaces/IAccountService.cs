using Microsoft.AspNetCore.Mvc;
using MVCForTraining.Models;
using System.Security.Claims;

namespace MVCForTraining.Interfaces
{
    public interface IAccountService
    {

        public Task<IActionResult> Register(RegisterModel model, string role);

        public Task<IActionResult> Login(LoginModel model);

        public Task<bool> ChangePassword(ChangePasswordModel model);
    }
}
