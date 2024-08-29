using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ATech.CityBike.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddPersistence(configuration);

        return services;
    }

    private static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("AppContext");

        // services
        //     .AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString,
        //                                                                 providerOptions => providerOptions.EnableRetryOnFailure()));

        // services.AddScoped<IVehicleRepository, VehicleRepository>();

        // services.AddScoped<IRepository, Repository>();

        return services;
    }
}