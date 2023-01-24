using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System;
using Twilio;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;
using System.Linq;

namespace EmailSender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SendEmail();           
        }       

        private static void SendEmail()
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("", ""),
                    EnableSsl = true,
                };

                //smtpClient.Send("email", "recipient", "subject", "body");

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(""),
                    Subject = "Test Email by saurabh from c#",
                    Body = "<h1>Hello Test mail</h1>",
                    IsBodyHtml = true,
                };
                mailMessage.To.Add("");

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }       



    }
}
