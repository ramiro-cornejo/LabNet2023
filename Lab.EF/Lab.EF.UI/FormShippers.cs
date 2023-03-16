using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.EF.UI
{
    public partial class FormShippers : Form
    {
        public FormShippers()
        {
            InitializeComponent();
        }

        private void btn_InsertarShipper_Click(object sender, EventArgs e)
        {

        }

        private void btn_ActualizarShipper_Click(object sender, EventArgs e)
        {
            nupd_ShipperID.Text = "";
            txt_CampanyName.Text = "";
            txt_Phone.Text = "";
        }

        private void btn_EliminarShipper_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
