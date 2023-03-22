using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.EF.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormSuppliers();
            form.ShowDialog();
        }

        private void shippersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormShippers();
            form.ShowDialog();
        }
    }
}
