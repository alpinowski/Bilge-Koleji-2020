    using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.COMMON.Tools
{
    public class MailSender
    {
        public static void SendEmail(string email, string subject, string message)
        {
            MailMessage sender = new MailMessage();
            sender.From = new MailAddress("web@bilgekoleji.com", "Bilge Koleji");
            sender.To.Add(email);
            sender.Subject = subject;
            sender.Body = message;

            SmtpClient smtp = new SmtpClient();

            smtp.Credentials = new System.Net.NetworkCredential("web@bilgekoleji.com", "PYoe45N5");
            smtp.Port = 587;
            smtp.Host = "mail.bilgekoleji.com";
            smtp.EnableSsl = false;
            smtp.Send(sender);
        }
    }
}
