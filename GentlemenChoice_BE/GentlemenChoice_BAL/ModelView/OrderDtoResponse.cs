namespace GentlemenChoice_BE.Controllers
{
    public class OrderDtoResponse
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal? TotalPrice { get; set; }
        public int Status { get; set; }

        public List<OrderDetailDtoResponse> OrderDetails { get; set; } = new List<OrderDetailDtoResponse>();
    }
}
