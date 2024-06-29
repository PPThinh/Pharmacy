using Api.Dtos.Customer;
using Api.Interfaces;
using Api.Mappers;
using Api.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("customer")]
    [Authorize]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _repo;
        public CustomerController(ICustomerRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _repo.GetAllAsync();
            return Ok(customers);
        }

        [HttpGet("{phoneNumber}")]
        public async Task<IActionResult> GetByPhoneNumber([FromRoute] string phoneNumber)
        {
            var customer = await _repo.GetByPhoneNumberAsync(phoneNumber);
            if(customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] string id)
        {
            var customer = await _repo.GetByPhoneNumberAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCustomerDto customerDto)
        {
            var customerModel = customerDto.ToCustomerFromCreateDto();
            await _repo.CreateAsync(customerModel);
            return CreatedAtAction(nameof(GetById), new { id = customerModel.Id }, customerModel.ToCustomerDto());
        }
    }
}
