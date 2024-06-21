using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Api.Data
{
    public class ProductDbContext
    {
        //public DbSet<Customer> Customers { get; set; }
        //public DbSet<OrderDetail> OrderDetails { get; set; }
        //public ProductDbContext(DbContextOptions options) : base(options)
        //{

        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<OrderDetail>()
        //        .HasKey(op => new { op.OrderId, op.ProductId });

        //    modelBuilder.Entity<OrderDetail>()
        //        .HasOne(op => op.Order)
        //        .WithMany(o => o.OrderDetails)
        //        .HasForeignKey(op => op.OrderId);

        //    modelBuilder.Entity<OrderDetail>()
        //        .HasOne(op => op.Product)
        //        .WithMany(p => p.OrderDetails)
        //        .HasForeignKey(op => op.ProductId);
        //}
    }
}
