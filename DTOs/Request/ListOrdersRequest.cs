namespace Orders.DTOs.Request
{
    public class ListOrdersRequest
    {
        public int PageNumber { get; set; } = 0;
        public int PageSize { get; set; } = 10;
    }
}
