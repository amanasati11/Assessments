using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    abstract class AbstractClassExample
    {
        public abstract void brake();
    }

    class Car: AbstractClassExample
    {
        public override void brake()
        {
            Console.WriteLine("Car Brake");
        }
    }

    class Bike: AbstractClassExample
    {
        public override void brake()
        {
            Console.WriteLine("Bike Brake");
        }
    }
}
