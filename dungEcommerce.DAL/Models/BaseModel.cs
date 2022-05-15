namespace dungEcommerce.DAL.Models
{
    public class BaseModel
    {
        public bool Status { get; set; }
        public Guid Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Guid? UserCreated { get; set; }
        public Guid? UserModified { get; set; }
    }
}