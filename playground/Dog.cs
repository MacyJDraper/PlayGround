using System;


namespace playground
{
    class Dog
    {
        public Dog(string dogName) //constructor method: const tab tab;  this method will not have a return type. The name of method will always be the name of the class
        {
            Name = dogName;
            Console.WriteLine("Instantiating a dog..");
        }
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }

        public void Speak()
        {
            Console.WriteLine("Ruff! My name is " + Name + "!");
        }
    }
}
