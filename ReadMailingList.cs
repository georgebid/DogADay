using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DogADay
{
    public class ReadMailingList : IEmail
    {
        public string Email { get; set; }


        static string listOfEmails = "C:\\Users\\Georgina.Bidder\\.vscode\\DogADay\\DogADayMailingList.csv";

        public List<IEmail> EmailList
        {
            get; set;
        }

        StreamReader readEmails = new StreamReader(listOfEmails);

        public void ReadList()
        {
            EmailList = new List<IEmail>();
            //make sure the list exists
            if (!File.Exists(listOfEmails))
            {
                Console.WriteLine($"The data file does not exist at {listOfEmails}.");
                throw new Exception();
            }
            // read every email in the file
            string emailAddress;

            while ((emailAddress = readEmails.ReadLine()) != null)
            {
                Console.WriteLine(emailAddress);

                IEmail getEmail = new ReadMailingList();

                // set the property of IEmail to the current email address
                getEmail.Email = emailAddress;

                // Add the emails to a list to be read by a send email object
                EmailList.Add(getEmail);
            }
        }
    }
}
