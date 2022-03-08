using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto6.ConsoleApp
{
    internal class Celcius
    {
        public double C;
        public double conversao()
        {
            double ValorFinal = C * 1.8 + 32;
            return ValorFinal;
        }
    }
}
