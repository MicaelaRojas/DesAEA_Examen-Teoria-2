using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
     class Program
    {
        static void Main(string[] args)
        {
            BebidaAzucarada bebida = Creador.CreadorBebida(Creador.Frugos);
            Console.WriteLine(bebida.CuantaAzucarContiene());
        }
    }
}
