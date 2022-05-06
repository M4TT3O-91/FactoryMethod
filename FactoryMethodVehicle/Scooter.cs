namespace FactoryMethodVehicle
{
    public class Scooter : Vehicle, IVehicle
    {
        public Scooter(int cilindrata) : base(cilindrata, 200D)
        {

        }

        public Scooter(int cilindrata, double wheigth) : base(cilindrata, wheigth)
        {

        }
    }
}