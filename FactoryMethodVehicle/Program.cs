using System;

namespace FactoryMethodVehicle
{
    class Program
    {
        static void Main()
        {
            var vehicleWith4wheels = VehicleFactory.Build(4,2000);
            Console.WriteLine($"I'm a ... {vehicleWith4wheels.GetType()}");


            var vehicleWith2wheels = VehicleFactory.Build(2,50);
            Console.WriteLine($"I'm a ... {vehicleWith2wheels.GetType()} and my power is {vehicleWith2wheels.GetPower()}");

            var vehicleWith2wheels2 = VehicleFactory.Build(2, 150);
            Console.WriteLine($"I'm a ... {vehicleWith2wheels2.GetType()}");

            var vehicleWith6wheels = VehicleFactory.Build(6, 6000);
            Console.WriteLine($"I'm a ... {vehicleWith6wheels.GetType()}");

            Console.ReadLine();
        }
    }
}
