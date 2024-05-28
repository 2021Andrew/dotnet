using System;

namespace MyApplication
{
    class Car
    {
        public string Color { get; set; }

        public Car()
        {
            Color = "Red"; // Default color
        }

        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.Color);
        }
    }
}
