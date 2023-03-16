using Lab.EF.Entities;
using Lab.EF.Logic;
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
    public partial class FormCategories : Form
    {
        ShippersLogic shippersLogic;
        public FormCategories()
        {
            InitializeComponent();
        }

        private void btn_InsertarCat_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ActualizarCat_Click(object sender, EventArgs e)
        {
            nupd_CategoryID.Text = "";
            txt_CategoryName.Text = "";
            txt_DescriptionCat.Text = "";
            txt_Picture.Text = "";
        }

        private void btn_EliminarCat_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_Categories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nupd_CategoryID.Text = "";
            txt_CategoryName.Text = "";
            txt_DescriptionCat.Text = "";
            txt_Picture.Text = "";
        }
    }
}
