using Api.Data;
using Api.Interfaces;
using Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly UserManager<User> _userManager;
        public AdminRepository(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<User?> GetUserByIdAsync(string id)
        {
            return await _userManager.FindByIdAsync(id);

        }

        public async Task<User?> GetUserByUserNameAsync(string username)
        {
            return await _userManager.FindByNameAsync(username);
        }

        //public async Task<User?> DeleteUser(string id)
        //{
        //    return await _userManager.De
        //}
    }
}
