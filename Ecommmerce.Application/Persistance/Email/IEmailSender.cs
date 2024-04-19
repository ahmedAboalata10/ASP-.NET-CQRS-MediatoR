using Ecommerce.Application.Models.Email;


namespace Ecommmerce.Application.Persistance.Email
{
    public interface IEmailSender
    {
        Task<bool> SendEmailAsync(EmailMessage email);
    }
}
