namespace playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myExampleDog = new Dog("Spot");
            //myExampleDog.Name = "Spot"; //line is no longer needed because of line above.
            myExampleDog.NumberOfLegs = 4;

            Dog mySecondDog = new Dog() { Name = "Spot", NumberOfLegs = 4 };

            myExampleDog.Speak();
            mySecondDog.Speak(); //parens are metjod invocation
        }
      
    }
}
