using Api.Helpers;
using Api.Models;

namespace Api.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<IEnumerable<Order>> GetAllAsync(ProductQueryObject query);
        Task<Order?> GetByIdAsync(int id);
        Task<IEnumerable<Order>?> GetByCustomerPhoneNumberAsync(string phoneNumber);
        Task<IEnumerable<Order>?> GetBySellerNameAsync(string employeeName);
        Task<Order?> CreateAsync(Order OrderModel);
        Task<Order?> DeleteAsync(int id);
    }
}
