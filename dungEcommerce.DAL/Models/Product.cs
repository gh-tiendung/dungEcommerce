namespace dungEcommerce.DAL.Models
{
    public class Product:BaseModel
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public Double Price { get; set; }
        public Rate Rate { get; set; }
    }
}