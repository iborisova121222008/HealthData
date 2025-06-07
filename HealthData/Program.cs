using HealthData.Data;
using HealthData.Models;

using Microsoft.EntityFrameworkCore;

namespace HealthData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();


            // 1) Регистрираме DbContext, но ползваме InMemory база вместо MySQL.
            //    Казваме “HealthData” ще използва InMemoryDatabase с име “HealthDB”.
            // ---------------------------------------------------------------
            builder.Services.AddDbContext<HealthDataContext>(options =>
                options.UseInMemoryDatabase("HealthDB")
            );


            //builder.Services.AddControllers();
            //builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<HealthDataContext>();

                context.Database.EnsureCreated(); // създава базата ако я няма (важно за InMemory)
                DbInitializer.Initialize(context); // <- тук слагаш логиката за тестови данни
            }






            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
