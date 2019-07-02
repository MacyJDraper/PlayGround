using System;


namespace playground
{
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
