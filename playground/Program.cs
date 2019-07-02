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
        }
      
    }
    class Dog
    {
        public string Name { get; set; }
        //public string Name //This is the same thing as  public string Name { get; set; }
        //{
        //    get
        //    {
        //        return Name;
        //    }
        //    set
        //    {
        //        Name = value;
        //    }
        //}
        public int NumberOfLegs { get; set; }

    }
}
