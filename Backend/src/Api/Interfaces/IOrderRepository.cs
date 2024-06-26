﻿using Api.Helpers;
using Api.Models;

namespace Api.Interfaces
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAllAsync(QueryObject query);
        Task<Order?> GetByIdAsync(int id);
        Task<IEnumerable<Order>?> GetByCustomerNameAsync(string customerName);
        Task<IEnumerable<Order>?> GetBySellerNameAsync(string employeeName);
        Task<Order?> CreateAsync(Order OrderModel);
        Task<Order?> DeleteAsync(int id);
    }
}
