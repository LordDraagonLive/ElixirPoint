namespace ElixirPoint.API.Services;

internal static class ServiceCollectionManager
{
    internal static IServiceCollection AddDomainServices(this IServiceCollection services)
    {
        // Register services
        services.AddScoped<ICustomerService, CustomerService>();
        // ...other domain services

        return services;
    }

}
