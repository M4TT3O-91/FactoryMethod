namespace FactoryMethodVehicle
{
    public class Truck : Vehicle
    {
        public Truck(int cilindrata, double wheigth) : base(cilindrata, wheigth)
        {
        }

        public Truck(int cilindrata) : base(cilindrata, 10000)
        {
        }
    }
}
