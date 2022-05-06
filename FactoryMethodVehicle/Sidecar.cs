using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodVehicle
{
    public class Sidecar : Vehicle
    {
        public Sidecar(int cilindrata, double wheigth) : base(cilindrata, wheigth)
        {
        } 

        public Sidecar(int cilindrata) : base(cilindrata, 500D)
        {
        }
    }
}
