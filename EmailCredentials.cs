using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Xml;

namespace DogADay
{
    public class EmailCredentials
    {
        public void SetUpAndSendEmail(MailMessage message)
        {
            // smtp client set up within the using block and is disposed of once the using is done,
            // which is why the Send() needs to happen here.
            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                // set to false as I want to use my own credentials
                smtp.UseDefaultCredentials = false;
                //credentials are taken from the App.config file.
                var username = ConfigurationManager.AppSettings["Username"];
                var password = ConfigurationManager.AppSettings["Password"];
                smtp.Credentials = new NetworkCredential(username, password);
               
                smtp.EnableSsl = true;
                smtp.Send(message);
            }
        }
    }
}

