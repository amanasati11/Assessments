using System;

namespace Assessment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Class");
            // Creating an object of Car Class
            Car c1 = new Car();
            c1.brake();

            // Creating an object of Bike Class
            Bike b1 = new Bike();
            b1.brake();
            Console.WriteLine();

            // Creating object for Partial Class
            Console.WriteLine("Partial Class");
            Class1 pc = new Class1();
            pc.greet();
            pc.meet();
            Console.WriteLine();

            // static class
            Console.WriteLine("Static class");
            Console.WriteLine("PI: " + StaticClassExample.PI);
            Console.WriteLine("Square of No.: " + StaticClassExample.calc(4));
        }
    }
}