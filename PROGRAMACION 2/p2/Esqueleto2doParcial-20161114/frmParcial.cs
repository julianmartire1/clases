using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;

namespace Esqueleto2doParcial_20161114
{
    public partial class frmParcial : Form
    {
        private Empleado _emp;
        private string path;

        public frmParcial()
        {
            InitializeComponent();
            this._emp = new Empleado("Julian", "Martire", 104303);
            this.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\empleado.xml";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(this.guardar);
            hilo.Start();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(this.leer);
            hilo.Start();
        }

        public void guardar()
        {
            this._emp.guardar(this.path, this._emp);
        }
        public void leer()
        {
            Empleado aux;

            if (this._emp.leer(this.path, out aux))
            {
                MessageBox.Show(aux.ToString());
            }
            else
            {
                MessageBox.Show("Empleado no leído");
            }
        }
    }
}
