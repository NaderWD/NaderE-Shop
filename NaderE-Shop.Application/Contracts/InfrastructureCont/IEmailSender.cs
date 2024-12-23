using NaderE_Shop.Application.OtherModels.Email;

namespace NaderE_Shop.Application.Contracts.InfrastructureCont
{
    public interface IEmailSender
    {
           Task<bool> SendEmail(Email email);
    }
}
