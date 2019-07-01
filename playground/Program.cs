using System;


namespace playground
{
    class Program
    {
       static void Main()
        {
            Cat cat1 = new Cat(); // You can write like this or like line 15-25
            cat1.Name = "Oscar";
            cat1.Color = "brown";
            cat1.Age = 1;

            Cat cat2 = new Cat();
            cat2.Name = "Tim";
            cat2.Color = "brown";
            cat2.Age = 1;

            Cat cat3 = new Cat();
            cat2.Name = "Simon";
            cat2.Age = 14;

            //string catName1 = "Oscar";
            //string catColor1 = "brown";
            //int catAge1 = 1;

            //string catName2 = "Tim";
            //string catName2 = "orange";
            //int catAge2 = 5;

            //string catName3 = "Simon";
            //string catName3 = "white";
            //int catAge3 = 14;

            Console.WriteLine("Cats 1's name is " + cat1.Name);
            Console.WriteLine("Cats 2's name is " + cat2.Name);
            Console.WriteLine("Cats 3's name is " + cat3.Name);
        }
        static void IntroduceCat(string name, string color, int age)
        {

        }
    }
    class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
    }
}
