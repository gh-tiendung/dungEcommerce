namespace dungEcommerce.DAL.Models
{
    public class Category:BaseModel
    {
        public string Name { get; set; }
        public Image Logo { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}