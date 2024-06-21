using Api.Helpers;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Api.Data;
using Api.Dtos.Product;
using Api.Interfaces;
using Api.Models;
using System.Linq;

namespace Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<List<Product>> GetAllAsync(QueryObject query)
        {
            var products = _context.Products.AsQueryable();
            if (!string.IsNullOrWhiteSpace(query.CompanyName))
            {
                products = products.Where(s => s.CompanyName.Contains(query.CompanyName));
            }

            var SkipNumber = (query.PageNumber - 1) * query.PageSize;

            return await products.Skip(SkipNumber).Take(query.PageSize).ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return  await _context.Products.FindAsync(id);
        }
        public async Task<Product?> CreateAsync(Product productModel)
        {
            await _context.Products.AddAsync(productModel);
            await _context.SaveChangesAsync();
            return productModel;
        }

        public async Task<Product?> UpdateAsync(int id, UpdateProductRequestDto productDto)
        {
            var existingProduct = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            if(existingProduct == null)
            {
                return null;
            }

            existingProduct.Name = productDto.Name;
            existingProduct.CompanyName = productDto.CompanyName;
            existingProduct.Price = productDto.Price;
            //existingProduct.ImagePath = productDto.ImagePath;
            existingProduct.Description = productDto.Description;

            await _context.SaveChangesAsync();
            return existingProduct;
        }

        public async Task<Product?> DeleteAsync(int id)
        {
            var productModel = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            if(productModel == null)
            { 
                return null;
            }
            _context.Products.Remove(productModel);
            await _context.SaveChangesAsync();
            return productModel;
        }

    }
}
