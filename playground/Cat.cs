using System;
namespace playground
{
    public class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public void Meow()
        {
            Console.WriteLine("Meeeeooww!! I'm " + Name + "....");
        }
    }
}
