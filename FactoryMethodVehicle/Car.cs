namespace FactoryMethodVehicle
{
    public class Car : Vehicle, IVehicle
    {
        public Car(int cilindrata, double wheigth) : base(cilindrata, wheigth)
        {
        }
        public Car(int cilindrata) : base(cilindrata, 2000D)
        {
        }
    }
}
