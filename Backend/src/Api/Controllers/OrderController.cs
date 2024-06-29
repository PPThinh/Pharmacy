using Api.Dtos.Product;
using Api.Helpers;
using Api.Interfaces;
using Api.Mappers;
using Api.Models;
using Api.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/order")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _repo;
        public OrderController(IOrderRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] ProductQueryObject query) 
        {
            var orders = await _repo.GetAllAsync(query);
            var orderDto = orders.Select(o => o.ToOrderDto());
            return Ok(orders);
        }

        [HttpGet("customer")]
        public async Task<IActionResult> GetByCustomer([FromBody] string customerName)
        {
            var orders = await _repo.GetByCustomerPhoneNumberAsync(customerName);
            return Ok();
        }
    }
}
