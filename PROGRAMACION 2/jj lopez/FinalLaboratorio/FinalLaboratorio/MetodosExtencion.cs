using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalLaboratorio
{
    public static class MetodosExtencion
    {
        //punto 1
        public static bool EsPar(this Int32 numero)
        {
            if ((numero % 2) == 0)
                return true;
            return false;
        }

        public static bool EsImpar(this Int32 numero)
        {
            return !(numero.EsPar());
        }
    }
}
