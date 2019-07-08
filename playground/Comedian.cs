using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace playground
{
    public class Comedian
    {
        public string Name { get; set; }

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
