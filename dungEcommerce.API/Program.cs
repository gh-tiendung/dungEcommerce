using dungEcommerce.API.dungEcommerce.Builder;
using dungEcommerce.API.dungEcommerce.ServiceCollection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.addDungEcomemrceServiceRegister(builder.Configuration);

var app = builder.Build();

app.useDungEcommerceBuilder(app.Environment.IsDevelopment());

app.MapControllers();

app.Run();
