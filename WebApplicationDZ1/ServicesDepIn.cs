
using Microsoft.Extensions.DependencyInjection;
using Services;
using Interfaces;

namespace WebApplicationDZ1
{
    public static class ServicesDepIn
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<ICheck, CheckService>();
            services.AddTransient<IContent,ContentService>();
            services.AddTransient<ILogic,LogicService>();
            services.AddTransient<IPublish,PublishService>();
            services.AddScoped<ISave,SaveInfService>();
            

            return services;
        }
    }
}
