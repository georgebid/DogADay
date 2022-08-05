using System;
using System.Collections.Generic;
using System.Text.Json;

namespace DogADay
{
    class Program
    {
        static void Main(string[] args)
        {
           static void EmailDogPictures()
            {
                //GetDog getDog = new GetDog();
               // DogInfo dogInfo = JsonSerializer.Deserialize<DogInfo>(getDog.ApiInfo());

                //Previously was writing the message to the console, but now this method is simply using an instance of the SendEmail
                //class and calling the send email object.
                SendEmail sendEmail = new SendEmail();
                sendEmail.SendEmails();
            }

            EmailDogPictures();
        }
    }
}
