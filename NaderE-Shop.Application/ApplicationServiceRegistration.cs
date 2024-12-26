using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace NaderE_Shop.Application
{
    public static class ApplicationServiceRegistration
    {
        public static void ConfigureApplicationService(this IServiceCollection services)
        {
            //services.AddAutoMapper(typeof(MappingProfile));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
