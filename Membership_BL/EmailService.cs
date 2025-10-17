using MimeKit;
using MailKit.Net.Smtp;

namespace Membership_BL
{
    class EmailService
    {
        public void SendEmail(string subject, string body)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Admin", "churchmembership@example.com"));
            message.To.Add(new MailboxAddress("Member", "member@church.com"));
            message.Subject = subject;
            message.Body = new TextPart("plain")
            {
                Text = body
            };

            using (var client = new SmtpClient())
            {
                var smtpHostn = "sandbox.smtp.mailtrap.io";
                var smtpPort = 2525;
                var tls = MailKit.Security.SecureSocketOptions.StartTls;
                client.Connect(smtpHostn, smtpPort, tls);

                var userName = "bb5ffd418562ef";
                var password = "edb1763875bc06";

                client.Authenticate(userName, password);

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
        

