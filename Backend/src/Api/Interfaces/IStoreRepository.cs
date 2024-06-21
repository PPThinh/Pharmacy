using Api.Dtos.Store;
using Api.Helpers;
using Api.Models;
using Microsoft.AspNetCore.DataProtection;

namespace Api.Interfaces
{
    public interface IStoreRepository
    {
        Task<List<Store>> GetAllAsync();
        Task<Store?> GetByIdAsync(int id);
        Task<Store?> CreateAsync(Store storeModel);
        Task<Store?> UpdateAsync(int id, UpdateStoreDto storeDto);
        Task<Store?> DeleteAsync(int id);
    }
}
