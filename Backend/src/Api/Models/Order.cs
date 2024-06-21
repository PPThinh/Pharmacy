﻿namespace Api.Models
{
    public class Order
    {
        public int Id { get; set; } 
        public DateTime Date { get; set; } = DateTime.Now;
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }

        
    }
}
