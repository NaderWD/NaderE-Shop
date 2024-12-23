using NaderE_Shop.Application.Contracts.InfrastructureCont;
using NaderE_Shop.Application.OtherModels.Email;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Net;

namespace NaderE_Shop.Infrastructure.Mail
{
    public class EmailSender(EmailSetting emailSetting) : IEmailSender
    {
        private readonly EmailSetting _emailSetting = emailSetting;

        public async Task<bool> SendEmail(Email email)
        {
            var client = new SendGridClient(_emailSetting.ApiKey);
            var to = new EmailAddress(email.To);
            var from = new EmailAddress()
            {
                Name = _emailSetting.FromName,
                Email = _emailSetting.FromAddress,
            };
            var message = MailHelper.CreateSingleEmail(from, to, email.Subject, email.Body, email.Body);
            var response = await client.SendEmailAsync(message);

            return response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted;
        }
    }
}
