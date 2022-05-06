using System;

namespace FactoryMethodVehicle
{
    class Program
    {
        static void Main()
        {
            var vehicleWith4wheels = VehicleFactory.Build(4,2000,2000);
            Console.WriteLine($"I'm a ... {vehicleWith4wheels.GetType()} and weigth  {vehicleWith4wheels.GetWeigth()} Kg");

            var vehicleWith2wheels = VehicleFactory.Build(2,50,200);
            Console.WriteLine($"I'm a ... {vehicleWith2wheels.GetType()} and my power is {vehicleWith2wheels.GetPower()} and my weigth {vehicleWith2wheels.GetWeigth()} Kg");

            var vehicleWith2wheels2 = VehicleFactory.Build(2, 150,200);
            Console.WriteLine($"I'm a ... {vehicleWith2wheels2.GetType()} and weigth {vehicleWith2wheels2.GetWeigth()} Kg");

            var vehicleWith2wheels3 = VehicleFactory.Build(3, 650, 400);
            Console.WriteLine($"I'm a ... {vehicleWith2wheels3.GetType()} and weigth {vehicleWith2wheels3.GetWeigth()} Kg");

            var vehicleWith6wheels = VehicleFactory.Build(6, 6000, 10000);
            Console.WriteLine($"I'm a ... {vehicleWith6wheels.GetType()} and weigth {vehicleWith6wheels.GetWeigth()} Kg");

            var vehicleWith6wheelsTir = VehicleFactory.Build(6, 6000, 20000);
            Console.WriteLine($"I'm a ... {vehicleWith6wheelsTir.GetType()} and weigth {vehicleWith6wheelsTir.GetWeigth()} Kg");

            Console.ReadLine();
        }
    }
}
