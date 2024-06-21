using Api.Data;
using Api.Helpers;
using Api.Interfaces;
using Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Api.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;
        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }
        public Task<Order?> CreateAsync(Order OrderModel)
        {
            throw new NotImplementedException();
        }

        public Task<Order?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Order>> GetAllAsync(QueryObject query)
        {
            var orders = _context.Orders.AsQueryable();
            if (!string.IsNullOrWhiteSpace(query.StoreId))
            {
                // doi string sang int
                if (int.TryParse(query.StoreId, out int store))
                {
                    orders = orders.Where(s => s.StoreId == store);
                }
                else
                    Console.WriteLine("Gía trị nhập vào phải là số nguyên");
            }
            

            var SkipNumber = (query.PageNumber - 1) * query.PageSize;

            return await orders.Skip(SkipNumber).Take(query.PageSize).ToListAsync();
        }

        public async Task<IEnumerable<Order>?> GetByCustomerNameAsync(string customerName)
        {
            return await _context.Orders
                .Include(o => o.Customer)
                .Where(o => o.Customer.Name == customerName)
                .ToListAsync();
        }

        public async Task<Order?> GetByIdAsync(int id)
        {
            return await _context.Orders.FindAsync(id);
        }

        public async Task<IEnumerable<Order>?> GetBySellerNameAsync(string employeeName)
        {
            return await _context.Orders
                .Include(o => o.Employee)
                .Where(o => o.Customer.Name == employeeName)
                .ToListAsync();
        }
    }
}
