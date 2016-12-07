using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalLaboratorio
{
    public class Deposito
    {
        public List<Producto> lista;

        public Deposito()
        {
            this.lista = new List<Producto>();
        }

        public static List<Producto> operator +(Deposito uno,Deposito dos)
        {
            List<Producto> Lista = new List<Producto>();
            bool band = false;

            foreach (Producto item1 in uno.lista)
            {
                Lista.Add(item1);
            }

            foreach (Producto item2 in dos.lista)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    if (item2 == Lista[i])
                    {
                        Lista[i].Stock += item2.Stock;
                        band = true;
                    }
                }
                if (!band)
                    Lista.Add(item2);
            }

            return Lista;
        }
    }
}
