namespace dungEcommerce.DAL.Models
{
    public class Order:BaseModel
    {
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
        public Promotion Promotion { get; set; }
    }
}