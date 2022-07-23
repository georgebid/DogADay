﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Mail;
using System.Text.Json;
using System.Net;
using FluentEmail.Core;
using System.Configuration;
using FluentEmail.Razor;

namespace DogADay
{
    public class SendEmail
    {
        public void SendEmails()
        {

            Email.DefaultRenderer = new RazorRenderer();
            // create an instance of email credentials so they can be used to send the email via the email account attached.
            EmailCredentials emailCredentials = new EmailCredentials();
            //instance of email message so that the email sent has the objects content.
            EmailMessage emailMessage = new EmailMessage();
            // assigned the email message - and the content to a new variable called message. This is so it can be used
            //within the sending method.
            //var message = emailMessage.EmailContent();

            ReadMailingList mailingList = new ReadMailingList();
            mailingList.ReadList();

            List<IEmail> emailList = mailingList.emailList;

            // for each email in the mailing list, create the email message using the email that's passed in
            //
            foreach (IEmail email in emailList)
           {
               var createdMessage = emailMessage.EmailContent(email);
               emailCredentials.SetUpAndSendEmail(createdMessage);
           }
           // confirm the above has worked.
            Console.WriteLine("Email sent.");

        }
    }
}