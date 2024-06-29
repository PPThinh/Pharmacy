namespace Api.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        // quận
        public string District { get; set; }
        // phường
        public string Ward { get; set; }
        public string Street { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
