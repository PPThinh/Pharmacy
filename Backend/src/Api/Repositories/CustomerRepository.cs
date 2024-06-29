using Api.Data;
using Api.Dtos.Customer;
using Api.Interfaces;
using Api.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;
        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Customer?> CreateAsync(Customer customerModel)
        {
            await _context.AddAsync(customerModel);
            await _context.SaveChangesAsync();
            return customerModel;
        }

        public async Task<Customer?> DeleteAsync(int id)
        {
            var customerModel = await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);
            if (customerModel == null)
            {
                return null;
            }
            _context.Customers.Remove(customerModel);
            await _context.SaveChangesAsync();
            return customerModel;
        }

        public async Task<Customer?> DeleteAsync(string phoneNumber)
        {
            var customerModel = await _context.Customers.FindAsync(phoneNumber);
            if (customerModel == null)
            {
                return null;
            }
            _context.Customers.Remove(customerModel);
            await _context.SaveChangesAsync();
            return customerModel;
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return ;
        }

        public async Task<Customer?> GetByIdAsync(int id)
        {
            return await _context.Customers.FindAsync(id);
        }
        public async Task<Customer?> UpdateAsync(int id, UpdateCustomerRequestDto customer)
        {
            var existCustomer = await _context.Customers.FirstOrDefaultAsync(c => c.Id == id);
            if(existCustomer == null)
            {
                return null;
            }

            existCustomer.Name = customer.Name;
            existCustomer.PhoneNumber = customer.PhoneNumber;

            return existCustomer;
        }
        public async Task<Customer?> GetByPhoneNumberAsync(string phoneNumber)
        {
            return await _context.Customers.FirstOrDefaultAsync(c => c.PhoneNumber == phoneNumber);
        }
    }
}
