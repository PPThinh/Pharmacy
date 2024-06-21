namespace Api.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
