using System;

namespace playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Comedian comedian = new Comedian();
            comedian.Name = "Macy J";

            Singer mySinger = new Singer();
            mySinger.Name = "Sara Dent";

            TellToIntroduce(comedian);
            TellToIntroduce(mySinger);

            comedian.TellChuckNorrisJoke();
        }
        static void TellToIntroduce(Human myHuman)
        {
            myHuman.Introduce();
            
        }
    }
}

