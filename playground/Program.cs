using System;

namespace playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Comedian comedian = new Comedian();
            comedian.Name = "mitch hedberg";

            comedian.TellChuckNorrisJoke();
            comedian.TellChuckNorrisJoke();
            comedian.TellChuckNorrisJoke();
        }
    }
}

