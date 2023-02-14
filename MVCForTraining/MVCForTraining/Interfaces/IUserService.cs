using MVCForTraining.Models;

namespace MVCForTraining.Interfaces
{
    public interface IUserService<T>
    {
        Task<T> Create(T model);

        Task<Dictionary<int, string>> GetRoles();

        Task<IEnumerable<T>> GetUsers();

        Task<bool> DeleteUser(long id);
    }
}
