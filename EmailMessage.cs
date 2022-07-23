using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;

namespace DogADay
{
    public class EmailMessage
    {
        public MailMessage EmailContent(IEmail email)
        {
            
            GetDog getDog = new GetDog();
            DogInfo dogInfo = JsonSerializer.Deserialize<DogInfo>(getDog.ApiInfo());

            StringBuilder mailBody = new StringBuilder();
            mailBody.AppendLine($"<h1>Hey, {email.Email}</h1>");
            mailBody.AppendLine($"<p>Here is your daily dose of Dog, Enjoy!</p>");
            mailBody.AppendLine($"<html><body>test <img src= {dogInfo.message}> importhtml</body></html>");

            var mailMessage = new MailMessage
            {
                From = new MailAddress("georginaweathertest@gmail.com"),
                Subject = "Dog A Day.",
                Body = mailBody.ToString(),
                IsBodyHtml = true,
            };

           mailMessage.To.Add(email.Email);

            return mailMessage;
        }
    }
}

