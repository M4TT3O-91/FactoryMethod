using System;

namespace FactoryMethodVehicle
{
    class Program
    {
        static void Main()
        {
            var vehicleWith4wheels = VehicleFactory.Build(4,2000,2000);
            Console.WriteLine($"I'm a ... {vehicleWith4wheels.GetType()}");


            var vehicleWith2wheels = VehicleFactory.Build(2,50,200);
            Console.WriteLine($"I'm a ... {vehicleWith2wheels.GetType()} and my power is {vehicleWith2wheels.GetPower()}");

            var vehicleWith2wheels2 = VehicleFactory.Build(2, 150,200);
            Console.WriteLine($"I'm a ... {vehicleWith2wheels2.GetType()}");

            var vehicleWith2wheels3 = VehicleFactory.Build(3, 650, 400);
            Console.WriteLine($"I'm a ... {vehicleWith2wheels3.GetType()}");

            var vehicleWith6wheels = VehicleFactory.Build(6, 6000, 10000);
            Console.WriteLine($"I'm a ... {vehicleWith6wheels.GetType()}");

            var vehicleWith6wheelsTir = VehicleFactory.Build(6, 6000, 20000);
            Console.WriteLine($"I'm a ... {vehicleWith6wheelsTir.GetType()}");

            Console.ReadLine();
        }
    }
}
