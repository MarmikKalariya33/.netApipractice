
using Microsoft.EntityFrameworkCore;
using practice.Models;

namespace practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Register services
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Database connection
            builder.Services.AddDbContext<EcomDbContext>(options =>
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("Econn")
                )
            );

            var app = builder.Build();

            // Enable Swagger
            app.UseSwagger();   
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
