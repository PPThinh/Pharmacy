using Api.Dtos.Customer;
using Api.Models;

namespace Api.Mappers
{
    public static class CustomerMappers
    {
        public static CustomerDto ToCustomerDto(this Customer customer)
        {
            return new CustomerDto
            {
                Id = customer.Id,
                Name = customer.Name,
                City = customer.City,
                Street = customer.Street,
                District = customer.District,
                PhoneNumber = customer.PhoneNumber,
                Ward = customer.Ward
            };
        }

        public static Customer ToCustomerFromCreateDto(this CreateCustomerDto customerDto)
        {
            return new Customer
            {
                Name = customerDto.Name,
                City = customerDto.City,
                Street = customerDto.Street,
                District = customerDto.District,
                PhoneNumber = customerDto.PhoneNumber,
                Ward = customerDto.Ward
            };
        }
    }
}
