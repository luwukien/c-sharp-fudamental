using System;

namespace MyApplication
{
    class Car
    {
        public string model;
        public string color;
        public int year;
        // Constructor
        public Car(string model, string color, int year)
        {
            this.model = model;
            this.color = color;
            this.year = year;
        }

        static void Main(string[] args)
        {
            Car myObj = new Car("Mustang", "red", 2025);
            Console.WriteLine("My car:" + myObj.model + "\nThe color of my car:" + myObj.color + "\nYear:" + myObj.year);
        }

    }



}