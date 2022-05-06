namespace FactoryMethodVehicle
{
    public class Tir : Vehicle
    {
        public Tir(int cilindrata, double wheigth) : base(cilindrata, wheigth)
        {
        }

        public Tir(int cilindrata) : base(cilindrata, 20000D)
        {
        }

    }
}
