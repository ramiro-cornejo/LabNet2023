using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabNetPractica2
{
    public partial class FormEjercicio01 : Form
    {
        Ejercicio01 ctrl = new Ejercicio01();
        public FormEjercicio01()
        {
            InitializeComponent();
        }

        private void btn_RealizarOperacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ctrl.Dividir(nupd_NumValor.Value));
        }
    }
}
