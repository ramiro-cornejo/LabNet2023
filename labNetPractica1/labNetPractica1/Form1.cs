using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labNetPractica1
{
    public partial class Form1 : Form
    {
        ListadoTransporte listado = new ListadoTransporte();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CargarDatos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listado.CargarDts(cbo_TipoTransporte.Text, (int)nupd_CantPasajeros.Value));
            cargarListado();
        }
        private void cargarListado()
        {
            lb_TransPub.DataSource = null;
            lb_TransPub.DataSource = listado.OrdenarList();
        }

        private void cbo_TipoTransporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_TipoTransporte.Text == "Taxi")
            {
                nupd_CantPasajeros.Maximum = 4;
            }
            else if(cbo_TipoTransporte.Text == "Omnibus")
            {
                nupd_CantPasajeros.Maximum = 100;
            }
        }
    }
}
