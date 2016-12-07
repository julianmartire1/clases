using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalLaboratorio
{
    public class ProdExport : Producto
    {
        public ProdExport()
        { }

        public ProdExport(string nombre, int stock)
            : base(nombre, stock)
        { }
    }
}
