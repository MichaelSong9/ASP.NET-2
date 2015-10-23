using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    // pode ser usada sem instanciar
    public static class clsExtensao
    {
        public static string Real(this decimal valor)
        {
            return valor.ToString("C2");
        }

        public static string Euro(this decimal valor)
        {
            return valor.ToString("C2", new System.Globalization.CultureInfo("es-es"));
        }

        public static string PesoArgentino(this decimal valor)
        {
            return valor.ToString("C2", new System.Globalization.CultureInfo("es-ar"));
        }
    }
}
