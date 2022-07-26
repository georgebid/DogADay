using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;

namespace DogADay
{
    public class EmailMessage
    {
        public MailMessage EmailContent()
        {
            
            GetDog getDog = new GetDog();
            DogInfo dogInfo = JsonSerializer.Deserialize<DogInfo>(getDog.ApiInfo());

            StringBuilder mailBody = new StringBuilder();
            // removed the below as it was causing issues looking for 'email' as it was removed as an argument.
            // need a to change this to the users name.
            //mailBody.AppendLine($"<h1>Hey, {email.Email}</h1>");
            mailBody.AppendLine($"<p>Here is your daily dose of Dog, Enjoy!</p>");
            mailBody.AppendLine($"<html><body> \n <img height=\"300\" src= {dogInfo.message}> </body></html>");

            var mailMessage = new MailMessage
            {
                From = new MailAddress("georginaweathertest@gmail.com"),
                Subject = "Dog A Day.",
                Body = mailBody.ToString(),
                IsBodyHtml = true,
            };

           //mailMessage.To.Add(email.Email);

            return mailMessage;
        }
    }
}

