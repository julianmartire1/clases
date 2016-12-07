using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalLaboratorio
{
    public class Producto
    {
        public string Nombre;
        public int Stock;

        public Producto()
        { }

        public Producto(string nombre, int stock)
        {
            this.Nombre = nombre;
            this.Stock = stock;
        }

        public static bool operator ==(Producto uno, Producto dos)
        {
            if (uno.Nombre == dos.Nombre)
                return true;
            return false;
        }

        public static bool operator !=(Producto uno, Producto dos)
        {
            return !(uno.Nombre == dos.Nombre);
        }
    }
}
