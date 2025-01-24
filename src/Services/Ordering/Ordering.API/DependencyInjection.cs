namespace Ordering.API;

public static class DependencyInjection
{
    public static IServiceCollection AddApiServices(this IServiceCollection services)
    {
        // addCarter()

        return services;
    }

    public static WebApplication UseApiServices(this WebApplication app)
    {
        // mapCarter()

        return app;
    }
}
