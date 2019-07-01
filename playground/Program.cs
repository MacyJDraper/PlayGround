using System;


namespace playground
{
    class Program
    {
        public class Cat
        {
            public string Name { get; set; }
            public string Color { get; set; }
            public string Age { get; set; }

            public void MeetTheCat()
            {
                Console.WriteLine("Hello, I'm " + Name + " the " + Color + " colored cat!");
            }

        }
        static void Main(string[] args)
        {
            var cat = new Cat(); //same as bellow you can do it either way. 
            cat.Name = "Oscar";
            cat.Color = "brown";
            cat.MeetTheCat();
            var cat2 = new Cat()
            {
                Name = "Sebastian", //same as above you can do it either way.
                Color = "Gray"
            };
            cat2.MeetTheCat();
        }
        
    }
    
}
