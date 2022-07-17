using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DogADay
{
    public class ReadMailingList
    {

        static string listOfEmails= "C:\\Users\\Georgina.Bidder\\.vscode\\DogADay\\DogADayMailingList.csv";

        public List<EmailCredentials> emailList
        {
            get; set;
        }

        StreamReader readEmails = new StreamReader(listOfEmails);

        public void ReadList()
        {
            emailList = new List<EmailCredentials>();
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

                EmailCredentials emailCredentials = new EmailCredentials();

                // set the property of EmailCredentials to the current email address
                emailCredentials.Email = emailAddress;

                // Add the emails to a list to be read by a send email object
                emailList.Add(emailCredentials);
            }
        }
    }
}
