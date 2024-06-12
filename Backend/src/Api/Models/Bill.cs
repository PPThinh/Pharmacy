namespace Pharmacy.Api.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public User Employee { get; set; }

        public int? EmployeeId { get; set; }
        public int? CustomerId { get; set; }
        
    }
}
