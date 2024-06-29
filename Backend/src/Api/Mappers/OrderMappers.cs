using Api.Dtos.Order;
using Api.Models;

namespace Api.Mappers
{
    public static class OrderMappers
    {
        public static OrderDto ToOrderDto(this Order order)
        {
            return new OrderDto
            {
                Id = order.Id,
                Date = order.Date,
                CustomerPhoneNumber = order.Customer.PhoneNumber,
                EmployeeName = order.Employee.Name,
                StoreName = order.Store.Name
            };
        }

        public static Order ToOrderFromCreateDto(this CreateOrderDto orderDto)
        {
            return new Order
            {
                Date = orderDto.Date,
                CustomerPhoneNumber = orderDto.CustomerPhoneNumber,
                EmployeeId = orderDto.EmployeeId,
                //OrderDetails = orderDto.OrderDetails.
                
            };
        }
    }
}
