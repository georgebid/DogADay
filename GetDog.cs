using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;

namespace DogADay
{
    public class GetDog
    {
        public string ApiInfo()
        { 
            var api = new Uri("https://dog.ceo/api/breeds/image/random");

            HttpClient client = new HttpClient();

            // send a get request using the api and seriallize the results to a string and save the result in a variable
            var result = client.GetAsync(api).Result.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
            //return the result to be used elsewhere
            return result;
        }
    }
}
