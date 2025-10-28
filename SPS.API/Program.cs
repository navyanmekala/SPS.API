using SPS.Business.Abstractions;
using SPS.Business.Implementations;
using SPS.DAL.Abstractions;
using SPS.DAL.Implementations;

namespace SPS.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            // Add Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Register your dependencies (if any)
            builder.Services.AddScoped<ISPSDataRepository, SPSDataRepository>();
            builder.Services.AddScoped<ISPSDataService, SPSDataService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
