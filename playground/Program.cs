using System;


namespace playground
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHey();
            SayHey("Macy");
        }
        static void SayHey()
        {
            Console.WriteLine("Hey!");
        }
        static void SayHey(string name)
        {
            Console.WriteLine("hey, " + name + "!");
        }
    }
}
