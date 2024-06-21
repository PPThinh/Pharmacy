namespace Api.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string City { get; set; }
        // quận
        public string District { get; set; }
        // phường
        public string Ward { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }

        // navigation
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public Store Store { get; set; }

    }
}
