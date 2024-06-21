using Api.Helpers;
using Api.Models;

namespace Api.Interfaces
{
    public interface IAdminRepository
    {
        Task<User?> GetUserByIdAsync(string id);
        Task<User?> GetUserByUserNameAsync(string username);
        //Task<User?> DeleteUser(string id);
    }
}
