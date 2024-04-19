using Ecommerce.Application.Models.Email;
using Ecommmerce.Application.Persistance.Email;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Ecommerce.Infrastructure.Email
{
    public class EmailSender : IEmailSender
    {
        public EmailSetting emailSetting { get; }
        public EmailSender(IOptions<EmailSetting> emailSetting)
        {
            this.emailSetting = emailSetting.Value ;
        }


        public async Task<bool> SendEmailAsync(EmailMessage email)
        {
            var client = new SendGridClient(emailSetting.ApiKey);
            var to = new EmailAddress(email.To);
            var from = new EmailAddress
            {
                Email =emailSetting.FromAddress,
                Name =emailSetting.FromName,

            };
            var message = MailHelper.CreateSingleEmail(from, to, email.Subject, email.Body, email.Body);
            var respone = await client.SendEmailAsync(message);
            return respone.StatusCode==System.Net.HttpStatusCode.OK|| respone.StatusCode==System.Net.HttpStatusCode.Accepted;
        }
    }
}
