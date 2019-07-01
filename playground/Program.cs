using System;


namespace playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat(); // You can write like this or like line 15-25
            cat1.Name = "Oscar";
            cat1.Color = "brown";

            Random rnd = new Random();

            rnd.Next();
            cat1.IntroduceCat();

            Console.WriteLine("Cats 1's name is " + cat1.Name);

        }
    }
    class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public void IntroduceCat()
        {
            Console.WriteLine("Hi! I'm " + Name + "!");
        }
    }
}
