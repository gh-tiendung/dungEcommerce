namespace dungEcommerce.DAL.Models
{
    public class Image:BaseModel
    {
        public string Path { get; set; }
        public Type Type { get; set; }
    }

    public enum Type{
        Logo,
        Avatar,
        Images
    }
}