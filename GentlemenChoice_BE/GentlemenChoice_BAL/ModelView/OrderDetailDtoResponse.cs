namespace GentlemenChoice_BE.Controllers
{
    public class OrderDetailDtoResponse
    {
        public string? ProductName { get; set; }
        public decimal PricePerUnit { get; set; }
        public int Quantity { get; set; }
    }
}
