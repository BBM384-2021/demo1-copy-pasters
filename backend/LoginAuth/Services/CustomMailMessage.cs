using System.Net.Mail;

namespace LoginAuth.Services
{
    public class CustomMailMessage : MailMessage
    {
        public CustomMailMessage(string isBodyHtml, string from, string subject, string body)
        {
            IsBodyHtml = bool.Parse(isBodyHtml);
            From = new MailAddress(from);
            Subject = subject;
            Body = body; // TODO: parameters will be removed from the template.
        }
    }
}