using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace Lab04.Models
{
    public class MailSender: IEmailSender
    {

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // hanh dong gia
            return Task.CompletedTask;
        }
    }
}
