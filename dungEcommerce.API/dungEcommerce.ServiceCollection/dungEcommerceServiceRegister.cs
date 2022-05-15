using dungEcommerce.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace dungEcommerce.API.dungEcommerce.ServiceCollection
{
    public static class dungEcommerceServiceRegister
    {
        public static void addDungEcomemrceServiceRegister(this IServiceCollection services,IConfiguration configuration)
        {
            // Add services to the container.

            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddDbContext<dungEcommerceDataContext>(options => options.UseSqlServer(configuration.GetConnectionString("dungEcommerceConnection")));
        }
    }
}