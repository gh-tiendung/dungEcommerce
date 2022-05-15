namespace dungEcommerce.DAL.Models
{
    public class Cart:BaseModel
    {
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
        public Promotion Promotion { get; set; }
    }
}