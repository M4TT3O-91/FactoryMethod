namespace FactoryMethodVehicle
{
    public class VehicleFactory
    {
        public static IVehicle Build(int numberOfWheels, int cilindrata) => numberOfWheels switch
        {
            2 => cilindrata > 125 ? new Motorbike(cilindrata) : new Scooter(cilindrata),
            4 => new Car(cilindrata),
            6 => new Truck(cilindrata),
            _ => throw new NumberOfWheelsNotSupported()
        };
    }
}
