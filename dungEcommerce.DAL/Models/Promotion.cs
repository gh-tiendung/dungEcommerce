namespace dungEcommerce.DAL.Models
{
    public class Promotion:BaseModel
    {
        public DateTime Effective { get; set; }
        public DateTime Expired { get; set; }
        public decimal Discount { get; set; }
    }
}