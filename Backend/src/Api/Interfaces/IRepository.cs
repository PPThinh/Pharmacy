using Api.Models;
namespace Api.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> CreateAsync(T model);
        Task<T> UpdateAsync(int id, T updateModelDto);
        Task<T> DeleteAsync(int id);

    }

}
