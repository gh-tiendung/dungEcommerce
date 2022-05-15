namespace dungEcommerce.DAL.Models
{
    public class OrderDetail : BaseModel
    {
        public Product Product { get; set; }
        public int Qty { get; set; }

    }
}