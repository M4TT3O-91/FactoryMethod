namespace FactoryMethodVehicle
{
    public abstract class Vehicle : IVehicle
    {
        private int Cilindrata;
        private double Wheigth
            ;

        protected Vehicle(int cilindrata, double wheigth)
        {
            Cilindrata = cilindrata;
            Wheigth = wheigth;
        }

        public double GetWeigth() => Wheigth;
        
        public int GetPower() => Cilindrata;

    }
}
