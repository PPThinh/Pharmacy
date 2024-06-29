using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Api.Models;
using System.Reflection.Emit;

namespace Api.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Chi tiết đơn hàng
            builder.Entity<OrderDetail>()
                .HasKey(od => new { od.OrderId, od.ProductId });

            // Quan hệ 1 - n (Order - OrderDetail)
            builder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId);
            // Quan hệ 1 - n (Product - OrderDetail)
            builder.Entity<OrderDetail>()
                .HasOne(od => od.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(od => od.ProductId);

            builder.Entity<User>()
                .HasOne(em => em.Employee)
                .WithOne(e => e.User)
                .HasForeignKey<Employee>(e => e.UserId);

            builder.Entity<Order>()
                .HasOne(o => o.Store)
                .WithMany(s => s.Orders)
                .HasForeignKey(o => o.StoreId)
                .OnDelete(DeleteBehavior.Cascade);


            // Role seeder của employee
            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "Staff",
                    NormalizedName = "STAFF"
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);

            ProductSeeder(builder);
            //UserSeeder(builder);
            //AddressSeeder(builder);
            //EmployeeSeeder(builder);
        }

        private void ProductSeeder(ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 9,
                    Name = "Viên uống DHC Calcium + CBP 120 viên",
                    CompanyName = "DHC",

                    Price = 210000,
                    ImagePath = "./Pics/dhc-1.jpg",
                    Description = "Hỗ trợ bổ sung calci, hỗ trợ hệ xương răng chắc khỏe, hỗ trợ phát triển chiều cao cho trẻ. Hỗ trợ làm giảm nguy cơ loãng xương ở người cao tuổi, còi xương ở trẻ em."
                },
                new Product
                {
                    Id = 10,
                    Name = "Viên uống DHC Multi-Vitamin",
                    CompanyName = "DHC",
                    Price = 100000,
                    ImagePath = "./Pics/dhc-1.jpg",
                    Description = "\r\nDHC Multi Vitamins bổ sung các vitamin cho cơ thể, giúp hỗ trợ bồi bổ sức khỏe.",
                }

                );
        }
        //private void AddressSeeder(ModelBuilder builder)
        //{
        //    builder.Entity<Address>().HasData(
        //        new Address
        //        {
        //            AddressId = 1,
        //            City = "Can Tho",
        //            District = "Ninh Kieu",
        //            Ward = "Tan An",
        //            Street = "Nguyen Trai",
        //            HouseNumber = "02"
        //        }
        //    );
        //}
        //private void UserSeeder(ModelBuilder builder)
        //{
        //    builder.Entity<Address>().HasData(
        //        new User
        //        {
        //            Id = "1",
        //            UserName = "admin",
        //            Email = "admin@example.com",
        //            NormalizedUserName = "ADMIN@EXAMPLE.COM",
        //            PasswordHash = new PasswordHasher<User>().HashPassword(null, "Admin123@")
        //        }
        //    );
        //}
        //private void EmployeeSeeder(ModelBuilder builder)
        //{
        //    builder.Entity<Employee>().HasData(

        //        new Employee
        //        {
        //            Id = 1,
        //            Name = "Admin",
        //            AddressId = 1,
        //            UserId = "1",
        //        }
        //        );
        //}

    }
}
