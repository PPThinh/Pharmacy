using Api.Models;

namespace Api.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomerAsync();
        Task<Customer?> GetByIdAsync(int id);
        Task<Customer?> CreateAsync(Customer customerModel);
        Task<Customer?> UpdateAsync(int id, Customer customer);
        Task<Customer?> DeleteAsync(int id);
    }
}
