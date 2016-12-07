using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalLaboratorio
{
    public class ProdVendido : Producto
    {
        public ProdVendido()
        { }

        public ProdVendido(string nombre, int stock)
            : base(nombre, stock)
        { }
    }
}
