using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace EmailLibrary
{
    public class SendMail
    {
        

        public void MailToManagerwithAttachment()
        {

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("asharma33099@gmail.com", "argqqtuofjusamno");
            smtpClient.EnableSsl = true;

            MailMessage message = new MailMessage();
            message.From = new MailAddress("asharma33099@gmail.com");
            message.To.Add("asharma33099@gmail.com");
            message.Subject = "Subject";
            message.Body = "This is test email with attachment.";

            // Create a new Attachment object
            Attachment attachment = new Attachment("logreport.txt");

            //// Add the attachment to the MailMessage object
            message.Attachments.Add(attachment);

            smtpClient.Send(message);
        }
    }
}
