using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Frugos : BebidaAzucarada
    {
        public override int CuantaAzucarContiene()
        {
            //menos azúcar
            return 5;
        }
    }
}
