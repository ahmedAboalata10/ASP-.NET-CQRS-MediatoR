using Ecommmerce.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.Persistance.Email
{
    public interface IEmailSender
    {
        Task<bool> SendEmailAsync(EmailMessage email);
    }
}
