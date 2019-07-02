using System;


namespace playground
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "hello";

            Dog myDog = new Dog();
            Dog mySecondDog = new Dog();

            myDog.Name = "Snoopy";
            myDog.NumberOfLegs = 4;

            mySecondDog.Name = "Champion";
            mySecondDog.NumberOfLegs = 3;

            myDog.Speak();
            mySecondDog.Speak();
        }
      
    }
    class Dog
    {
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }

        public void Speak()
        {
            Console.WriteLine("Ruff! My name is " + Name + "!");
        }
     }
}
