using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var assemby=typeof(Program).Assembly.GetName().Name;

builder.Services.AddIdentityServer().AddConfigurationStore(
    options=>{
        options.ConfigureDbContext  = b =>b.UseSqlServer(dungEcommerceConnection,opt=>opt.MigrationAssembly(assemby));
    }
);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
