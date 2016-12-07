using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Linq;
using System.Text;

namespace FinalLaboratorio
{
    public delegate void Delegado(Object obj,EventArgs Args);
    public class Galpon<T> : IGuardarXML<T>
    {
        public List<Deposito> lista;

        public Galpon()
        {
            this.lista = new List<Deposito>();
        }

        //punto 4
        private int _cantidad;
        public int Cantidad 
        {
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Usted ingresó 0");
                }
                else
                {
                    if (value.EsImpar())
                    {
                        this.EsImpar(value, new EventArgs());
                    }
                    else
                    {
                        this._cantidad = value;
                    }
                }
            }
        }



        public event Delegado EsImpar;

        public bool SerializarXML(Galpon<T> galpon)
        {
            XmlSerializer serializador;
            XmlTextWriter escritor;

            try
            {
                serializador = new XmlSerializer(typeof(T));
                escritor = new XmlTextWriter("galpon.xml", Encoding.UTF8);

                serializador.Serialize(escritor, galpon);
                escritor.Close();

                return true;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
