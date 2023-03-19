using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConversionCentavosDolares
{
    internal class Calculadora
    {

        public static void CalcularDolares(int centavosInput, out int dolares, out int centavosRestantes)
        {
            dolares = centavosInput / 100;
            centavosRestantes = centavosInput % 100;     
        }
    }
}
