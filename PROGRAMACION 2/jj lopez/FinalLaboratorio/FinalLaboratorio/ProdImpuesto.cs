using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalLaboratorio
{
    public class ProdImpuesto : Producto
    {
        public ProdImpuesto()
        { }

        public ProdImpuesto(string nombre, int stock)
            : base(nombre, stock)
        { }
    }
}
