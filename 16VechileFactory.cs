using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public interface IVehicle
    {
        void Drive();
    }

    public class Car1 : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Car.");
        }
    }

    public class Bike1 : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding a Bike.");
        }
    }

    public class VehicleFactory
    {
        public static IVehicle GetVehicle(string type)
        {
            if (type.ToLower() == "car")
            {
                return new Car1();
            }
            else if (type.ToLower() == "bike")
            {
                return new Bike1();
            }
            else
            {
                throw new ArgumentException("Invalid vehicle type.");
            }
        }
    }

}
