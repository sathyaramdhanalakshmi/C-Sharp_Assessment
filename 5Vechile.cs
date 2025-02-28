using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting...");
        }
    }

    // Derived class Car
    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is starting with a key ignition...");
        }
    }

    class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike is starting with a self-start mechanism...");
        }
    }
}
