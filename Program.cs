using ClothShop.Data;
using ClothShop.Interfaces.Repository;
using ClothShop.Repositories;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        AddServices(builder);
        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }

    private static void AddServices(WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<DataContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("Postgres")));
        builder.Services.AddScoped<ISneakerRepository, SneakerRepository>();
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
    }
}