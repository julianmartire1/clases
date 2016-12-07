using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalLaboratorio
{
    public class Burbujeo
    {

        private void MetodoDeInstancia()
        {
            throw new Exception("Metodo de instancia");
        }

        public static void MetodoEstatico()
        {
            Burbujeo aux;
            aux = new Burbujeo();

            try
            {
                aux.MetodoDeInstancia();
            }
            catch (Exception e)
            {
                throw new Exception("Estatico / " + e.Message);
            }
        }
    }
}
