using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NaderE_Shop.Application.Contracts.InfrastructureCont;
using NaderE_Shop.Application.OtherModels.Email;
using NaderE_Shop.Infrastructure.Mail;

namespace NaderE_Shop.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection ConfigureInfrastructureService(this IServiceCollection service, IConfiguration configuration)
        {
            var section = configuration.GetSection("EmailSettings");
            service.Configure<EmailSetting>(section);

            service.AddTransient<IEmailSender, EmailSender>();

            return service;
        }
    }
}
