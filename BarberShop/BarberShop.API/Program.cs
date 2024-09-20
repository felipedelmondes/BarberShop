
using BarberShop.Core.Interfaces.Repositories;
using BarberShop.Core.Interfaces.Services;
using BarberShop.Core.Services;
using BarberShop.Repository.Repositories;

namespace BarberShop.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //services
            builder.Services.AddTransient<DBContext, DBContext>();
            builder.Services.AddTransient<IClientesRepositories, ClientesRepositories>();
            builder.Services.AddTransient<IClientesServices, ClientesServices>();
            builder.Services.AddTransient<IFuncionariosServices, FuncionariosService>();
            builder.Services.AddTransient<IFuncionariosRepositories, FuncionariosRepositories>();
            builder.Services.AddTransient<IServicosService, ServicosService>();
            builder.Services.AddTransient<IServicosRepositories, ServicosRepositories>();

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
