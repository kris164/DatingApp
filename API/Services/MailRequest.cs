using MimeKit;
using System.IO;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit.Utils;
using Microsoft.Extensions.Options;

namespace API.Services
{
     public class MailRequest
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<IFormFile> Attachments { get; set; }
    }


     public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }


     public class MailService : IMailService
    {
        private readonly MailSettings _mailSettings;
        public MailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }
        public async Task SendEmailAsync(MailRequest mailRequest)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_mailSettings.Mail);

            email.From.Add (new MailboxAddress ("Gielda", "gielda@maszonski.com"));
            email.To.Add (new MailboxAddress ("Alice", "gielda@maszonski.com"));
 
            //email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
            email.Subject = mailRequest.Subject;
            var builder = new BodyBuilder();
            if (mailRequest.Attachments != null)
            {
                byte[] fileBytes;
                foreach (var file in mailRequest.Attachments)
                {
                    if (file.Length > 0)
                    {
                        using (var ms = new MemoryStream())
                        {
                            file.CopyTo(ms);
                            fileBytes = ms.ToArray();
                        }
                        builder.Attachments.Add(file.FileName, fileBytes, ContentType.Parse(file.ContentType));
                    }
                }
            }

            var image = builder.LinkedResources.Add (@"C:\Users\adminmts2\FreightExchange\DatingApp\API\EmailTemplates\image002.png");
            image.ContentId = MimeUtils.GenerateMessageId ();

            builder.HtmlBody =string.Format (@"<p>Hey,<br>
<p>Twoje konto zostało zarejestrowane.<br>
<p> <br>
<p>-- Joey<br>
<center><img src=""cid:{0}""></center>", image.ContentId);


            email.Body = builder.ToMessageBody();
            using var smtp = new SmtpClient();
            smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(_mailSettings.Mail, _mailSettings.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }
    }


    public class MailSettings
    {
        public string Mail { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
    }
}