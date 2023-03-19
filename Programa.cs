using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConversionCentavosDolares
{
    internal class Programa
    {
        public static void HabilitarDeshabilitar(Control controlGenerico) => controlGenerico.Enabled = !controlGenerico.Enabled;
        public static void HabilitarDeshabilitar(Control controlGenerico, Control controlGenerico2)
        {
            controlGenerico.Enabled = !controlGenerico.Enabled;
            controlGenerico2.Enabled = !controlGenerico2.Enabled;
        }
       

    }
}
