namespace Api.Dtos.Customer
{
    public class CreateCustomerDto
    {
        public string PhoneNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;
        public string Ward { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
    }
}
