using System;
using System.Collections.Generic;
using System.Text.Json;

namespace DogADay
{
    class Program
    {
        static void Main(string[] args)
        {
            GetDog getDog = new GetDog();
            
            DogInfo dogInfo= JsonSerializer.Deserialize<DogInfo>(getDog.ApiInfo());
            
            Console.WriteLine(dogInfo.message);

            //ReadMailingList mailingList = new ReadMailingList();


            SendEmail sendEmail = new SendEmail();

            sendEmail.SendEmails();
        }
    }
}
