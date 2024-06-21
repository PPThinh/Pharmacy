namespace Api.Helpers
{
    public class QueryObject
    {
        // product
        public string? CompanyName { get; set; } = null;

        // order
        public string? CustomerName {  get; set; } = null;
        public string? EmployeeName { get; set; } = null;
        public string? StoreId { get; set; } = null;
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}
