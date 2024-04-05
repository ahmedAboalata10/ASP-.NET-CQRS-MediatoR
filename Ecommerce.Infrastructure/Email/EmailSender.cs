using Ecommmerce.Application.Models;
using Ecommmerce.Application.Persistance.Email;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Email
{
    public class EmailSender : IEmailSender
    {
        public EmailSetting _emailSetting { get;  }
        public EmailSender(IOptions<EmailSetting> emailSetting)
        {
            _emailSetting = emailSetting.Value;
        }
        public async Task<bool> SendEmailAsync(EmailMessage email)
        {
            var client = new SendGridClient(_emailSetting.ApiKey);
            var to = new EmailAddress(email.To);
            var from = new EmailAddress
            {
                Email =_emailSetting.FromAddress,
                Name =_emailSetting.FromName,

            };
            var message = MailHelper.CreateSingleEmail(from, to, email.Subject, email.Body, email.Body);
            var respone = await client.SendEmailAsync(message);
            return respone.StatusCode==System.Net.HttpStatusCode.OK|| respone.StatusCode==System.Net.HttpStatusCode.Accepted;
        }

    }
}
