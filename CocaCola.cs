using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class CocaCola : BebidaAzucarada
    {
        //metodo override
        public override int CuantaAzucarContiene()
        {
            //más azúcar
            return 20;
        }
    }
}
