using Api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pharmacy.Api.Data;
using Pharmacy.Api.Dtos.Product;
using Pharmacy.Api.Interfaces;
using Pharmacy.Api.Mappers;

namespace Pharmacy.Api.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IProductRepository _repo;
        public ProductController(AppDbContext context, IProductRepository repo)
        {
            _context = context;
            _repo = repo;
        }
        
        // Read - doc du lieu
        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> GetAll([FromQuery] QueryObject query)
        {
            // hien thi tat ca product = json
            var products = await _repo.GetAllAsync(query);
            var productDto = products.Select(s => s.ToProductDto());
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var product = await _repo.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product.ToProductDto());
        }

        // Create - Tao du lieu
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create([FromBody] CreateProductRequestDto productDto)
        {
            var productModel = productDto.ToProductFromCreateDto();
            await _repo.CreateAsync(productModel);
            return CreatedAtAction(nameof(GetById), new { id = productModel.Id }, productModel.ToProductDto());
        }

        // Update - Cap nhat du lieu
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateProductRequestDto updateDto)
        {
            // tim id san pham
            var productModel = await _repo.UpdateAsync(id, updateDto);
            if (productModel == null)
            {
                return NotFound();
            }

            return Ok(productModel.ToProductDto());

        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var product = await _repo.DeleteAsync(id);
            if(product == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
