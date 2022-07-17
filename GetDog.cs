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

            var result = client.GetAsync(api).Result.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
            return result;
        }
    }
}
