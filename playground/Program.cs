namespace playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myExampleDog = new Dog();
            myExampleDog.Name = "Spot";
            myExampleDog.NumberOfLegs = 4;

            Dog mySecondDog = new Dog() { Name = "Spot", NumberOfLegs = 4 };
        }
      
    }
}
