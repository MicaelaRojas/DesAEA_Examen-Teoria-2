using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //La clase sirve para crear los objetos
    public class Creador
    {
        public const int CocaCola = 1;
        public const int Frugos = 2;

        public static BebidaAzucarada CreadorBebida(int Tipo)
        {
            switch(Tipo)
            {
                case CocaCola: 
                    return new CocaCola();
                case Frugos:
                    return new Frugos();
                default: return null;
            }
        }
    }
}
