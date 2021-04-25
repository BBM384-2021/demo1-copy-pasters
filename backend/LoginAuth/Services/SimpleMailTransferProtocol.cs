using System.Net;
using System.Net.Mail;

namespace LoginAuth.Services
{
    public class SimpleMailTransferProtocol : SmtpClient
    {
        public SimpleMailTransferProtocol(string username, string password,
            string port, string host, string enableSsl)
        {
            Credentials = new NetworkCredential(username, password);
            Port = int.Parse(port);
            Host = host;
            EnableSsl = bool.Parse(enableSsl);
        }
        
    }
}