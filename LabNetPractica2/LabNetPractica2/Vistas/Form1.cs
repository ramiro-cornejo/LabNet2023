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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejercicio01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormEjercicio01();
            formulario.ShowDialog();
        }

        private void ejercicio02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormEjercicio02();
            formulario.ShowDialog();
        }

        private void ejercicio03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormEjercicio03();
            formulario.ShowDialog();
        }

        private void ejercicio04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormEjercicio04();
            formulario.ShowDialog();
        }
    }
}
