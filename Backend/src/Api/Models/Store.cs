namespace Api.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        // fk
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public List<Order> Orders { get; set; }
    }
}
