using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://api.chucknorris.io/jokes/random";
            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(url).Result;

            //int jokeStartIndex = response.IndexOf("value") + 8;
            //int jokeLength = response.Length - jokeStartIndex - 2;   
            //string joke = response.Substring(jokeStartIndex, jokeLength);

            string joke2 = JObject.Parse(response).GetValue("value").ToString();

            Console.WriteLine(joke2);
            //Console.WriteLine(joke);

        }
    }
}

