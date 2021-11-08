namespace BrainWare.Application
{
    using Microsoft.Extensions.DependencyInjection;

    using Services;
    using Services.Impl;

    public static class Registration
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services.AddTransient<IOrderService, OrderService>();
        }
    }
}