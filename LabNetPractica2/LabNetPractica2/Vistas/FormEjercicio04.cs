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
    public partial class FormEjercicio04 : Form
    {
        Ejercicio04Logic ej04Logic = new Ejercicio04Logic();
        public FormEjercicio04()
        {
            InitializeComponent();
        }

        private void btn_InfExcepcionPers_Click(object sender, EventArgs e)
        {
            try
            {
                throw ej04Logic.DispararException();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Mensaje de la excepción personalizada: {ex.Message} \n\n Tipo de la excepción personalizada: {ex}.");
            }
        }
    }
}
