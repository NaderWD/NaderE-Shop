using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace NaderE_Shop.Application
{
    public static class ApplicationServiceRegistration
    {
        public static void ConfigureApplicationService(this IServiceCollection services)
        {

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddMediatR(opt =>
            {
                opt.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                opt.AutoRegisterRequestProcessors = true;
            });
        }
    }
}
