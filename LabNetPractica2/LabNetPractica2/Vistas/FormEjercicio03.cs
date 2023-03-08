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
    public partial class FormEjercicio03 : Form
    {
        Logic logic = new Logic();
        public FormEjercicio03()
        {
            InitializeComponent();
        }

        private void btn_InfExcepcion_Click(object sender, EventArgs e)
        {
            try
            {
                throw logic.DispararException();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Mensaje de la excepción: {ex.Message} \n\n Tipo de la excepción: {ex}.");
            }
        }
    }
}
