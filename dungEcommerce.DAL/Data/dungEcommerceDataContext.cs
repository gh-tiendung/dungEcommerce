using Microsoft.EntityFrameworkCore;

namespace dungEcommerce.DAL.Models
{
    public class dungEcommerceDataContext : DbContext
    {
        public dungEcommerceDataContext() { }
        public dungEcommerceDataContext(DbContextOptions<dungEcommerceDataContext> options) : base(options) { }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
                    CancellationToken cancellationToken = default(CancellationToken))
        {
            var modifiedEntries = ChangeTracker.Entries()
                    .Where(x => x.Entity is BaseModel && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                var entity = entry.Entity as BaseModel;

                if (entry.State == EntityState.Added)
                {
                    entity.DateCreated = DateTime.UtcNow;
                }

                entity.DateModified = DateTime.UtcNow;
            }

            return (await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken));
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
    }
}

