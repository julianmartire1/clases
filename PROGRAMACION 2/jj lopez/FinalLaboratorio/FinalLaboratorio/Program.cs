using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FinalLaboratorio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Punto 2

            Stack<Double> miPila;
            miPila = new Stack<double>();

            miPila.Push(1);
            miPila.Push(2);
            miPila.Push(3);

            miPila = ClasePila.OrdenAlreves(miPila);

            /**********************************************/

            //Punto 3

            Deposito depositoUno;
            depositoUno = new Deposito();

            Deposito depositoDos;
            depositoDos = new Deposito();

            depositoUno.lista.Add(new Producto("Helado",5));
            depositoUno.lista.Add(new Producto("Azucar", 5));
            depositoDos.lista.Add(new Producto("Carne",5));
            depositoDos.lista.Add(new Producto("Helado", 5));

            List<Producto> listaFinal = depositoUno + depositoDos;

            /**********************************************/

            //Punto 4

            Galpon<int> galpon;
            galpon = new Galpon<int>();

            galpon.EsImpar += new Delegado(Program.Evento);

            try
            {
                galpon.Cantidad = 0;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            ///Punto 6
            try
            {
                Burbujeo.MetodoEstatico();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message + " y program");
            }
            ///Punto 7
            //No me serializa
            Galpon<Deposito> aux = new Galpon<Deposito>();
            depositoUno.lista.Add(new ProdVendido("Carne vendida", 1));
            aux.lista.Add(depositoUno);
            aux.lista.Add(depositoDos);
            try
            {
                if(aux.SerializarXML(aux))
                    Console.WriteLine("Serializado");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

        public static void Evento(Object obj, EventArgs args)
        {
            string archivo = "log.txt";
            DateTime time = new DateTime();

            StreamWriter escritor = new StreamWriter(archivo,true);

            time = DateTime.Now;
            escritor.Write("Hora de la excepcion: "+time.ToLongTimeString() + "//" + "Cantidad ingresada: "+((int)obj).ToString());

            escritor.Close();
        }
    }
}
