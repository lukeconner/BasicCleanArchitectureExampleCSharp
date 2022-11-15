using System.Net;
using System.Net.Mail;
using Ddp.App.Interfaces;

namespace Ddp.Shared.Services;

public class EmailService : IEmailService
{
    public bool SendEmail(string email, string subject, string message)
    {
        var client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
        {
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential("email@login.com", "password"),
            EnableSsl = true
        };

        var mailMessage = new MailMessage
        {
            From = new MailAddress("email@email.com", "Email Display")
        };
        mailMessage.To.Add(email);
        mailMessage.Body = message;
        mailMessage.Subject = subject;
        client.Send(mailMessage);

        return true;
    }
}