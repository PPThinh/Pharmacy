namespace Api.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        // fk
        public string City { get; set; }
        // quận
        public string District { get; set; }
        // phường
        public string Ward { get; set; }
        public string Street { get; set; }
        public List<Order> Orders { get; set; }
    }
}
