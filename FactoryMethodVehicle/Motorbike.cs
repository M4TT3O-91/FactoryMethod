namespace FactoryMethodVehicle
{
    public class Motorbike : Vehicle
    {
        public Motorbike(int cilindrata) : base(cilindrata, 200D)
        {

        }

        public Motorbike(int cilindrata, double weight) : base(cilindrata, weight)
        {

        }
    }
}
