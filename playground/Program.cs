using System;


namespace playground
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHey();
            SayHey("Macy");
            SayHey("Macy", "Draper");
        }
        static void SayHey()
        {
            Console.WriteLine("Hey!");
        }
        static void SayHey(string name)
        {
            Console.WriteLine("Hey, " + name + "!");
        }
        static void SayHey(string firstName, string lastName)
        {
            Console.WriteLine("Hey, " + firstName + " " + lastName + "!");
        }
    }
}
