using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IVehicleInfo
    {
        //void GetNoOfWheels();
    }

    public class Car : IVehicleInfo
    {
        //public void GetNoOfWheels()
        //{
        //    Console.WriteLine("I have 4 wheels");
        //}

        
    }

    public class Truck : IVehicleInfo
    {
        //public void GetNoOfWheels()
        //{
        //    Console.WriteLine("I have 4 wheels");
        //}


    }

    public class Trailer : IVehicleInfo
    {
        //public void GetNoOfWheels()
        //{
        //    Console.WriteLine("I have 6 wheels");
        //}
    }

    public class VehicleFactory
    {

        public IVehicleInfo GetVehicle(string carName)
        {

            switch (carName)
            {
                case "Car":
                    return new Car();
                case "Trailer":
                    return new Trailer();
                case "Truck":
                    return new Truck();
                default:
                    throw new ArgumentException("Not Implemented");
            }
        }

      

    }
}
