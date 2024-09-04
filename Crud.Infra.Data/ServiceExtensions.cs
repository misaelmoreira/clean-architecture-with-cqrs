using Crud.Domain.Interfaces;
using Crud.Infra.Data.Context;
// using Crud.Infra.Data.Repositorios.Memoria; // usando o memory
// using UnitOfWork = Crud.Infra.Data.Repositorios.Memoria.UnitOfWork;  // usando o memory
using Crud.Infra.Data.Repositorios.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Crud.Infra.Data;

public static class ServiceExtensions
{
    public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));

        //// usando o memoria
        //services.AddSingleton<ICustomerRepository, CustomerRepository>();
        //services.AddSingleton<IUnitOfWork, UnitOfWork>();

        // usando o ef core        
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
    }
}
