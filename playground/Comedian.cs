using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace playground
{
    class Comedian : IPerform
    {
        public void Perform()
        {
            Console.WriteLine("Welcome! Here's a joke!");
            TellChuckNorrisJoke();
            Console.WriteLine("You've been a great audince, goodnight!");
        }

        public void TellChuckNorrisJoke()
        {
            string url = "https://api.chucknorris.io/jokes/random";
            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(url).Result;
            string joke2 = JObject.Parse(response).GetValue("value").ToString();

            Console.WriteLine(joke2);
        }
    }
}
