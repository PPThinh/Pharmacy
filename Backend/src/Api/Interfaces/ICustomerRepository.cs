using Api.Dtos.Customer;
using Api.Models;

namespace Api.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllAsync();
        Task<Customer?> GetByIdAsync(int id);
        Task<Customer?> CreateAsync(Customer customerModel);
        Task<Customer?> UpdateAsync(int id, UpdateCustomerRequestDto customer);
        Task<Customer?> DeleteAsync(int id);
        Task<Customer?> GetByPhoneNumberAsync(string phoneNumber);
    }
}
