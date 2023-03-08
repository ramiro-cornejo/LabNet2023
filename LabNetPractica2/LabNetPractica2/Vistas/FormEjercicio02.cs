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
    public partial class FormEjercicio02 : Form
    {
        Ejercicio02 ctrl = new Ejercicio02();
        public FormEjercicio02()
        {
            InitializeComponent();
        }

        private void btn_Dividir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ctrl.Dividir(txt_NumDividendo.Text, txt_NumDivisor.Text));
        }
    }
}
