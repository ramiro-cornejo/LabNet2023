using Lab.EF.Entities;
using Lab.EF.Logic.Control;
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
    public partial class FormLinq : Form
    {
        LinqControl linqControl = new LinqControl();
        public FormLinq()
        {
            InitializeComponent();
        }

        private void FormLinq_Load(object sender, EventArgs e)
        {
         
        }

        private void cbo_numEjercicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_numEjercicio.Text == "Ejercicio 1")
            {
                dgv_ListEjercicios.DataSource = null;
                dgv_ListEjercicios.DataSource = linqControl.GetCustomers().ToList();
                dgv_ListEjercicios.Columns[12].Visible = false;
                dgv_ListEjercicios.Columns[11].Visible = false;
            }
            else if(cbo_numEjercicio.Text == "Ejercicio 2")
            {
                dgv_ListEjercicios.DataSource = null;
                dgv_ListEjercicios.DataSource = linqControl.GetProductsWithoutStock().ToList();
                dgv_ListEjercicios.Columns[12].Visible = false;
                dgv_ListEjercicios.Columns[11].Visible = false;
            }
            else if(cbo_numEjercicio.Text == "Ejercicio 3")
            {
                dgv_ListEjercicios.DataSource = null;
                dgv_ListEjercicios.DataSource = linqControl.GetProductsWithtStock3Units().ToList();
                dgv_ListEjercicios.Columns[12].Visible = false;
                dgv_ListEjercicios.Columns[11].Visible = false;
            }
            else if(cbo_numEjercicio.Text == "Ejercicio 4")
            {
                dgv_ListEjercicios.DataSource = null;
                dgv_ListEjercicios.DataSource = linqControl.GetCustomersRegionWA().ToList();
                dgv_ListEjercicios.Columns[12].Visible = false;
                dgv_ListEjercicios.Columns[11].Visible = false;
            }
            else if(cbo_numEjercicio.Text == "Ejercicio 5")
            {
                dgv_ListEjercicios.DataSource = null;
                dgv_ListEjercicios.DataSource = linqControl.GetElementOrNull().ToList();
            }
            else if (cbo_numEjercicio.Text == "Ejercicio 6 (Mayuscula)")
            {
                try
                {
                    var item = linqControl.GetCustomersName().ToList();
                    item.ForEach(c =>
                    {
                        c.ContactName = c.ContactName.ToUpper();
                    });
                    dgv_ListEjercicios.DataSource = null;
                    dgv_ListEjercicios.DataSource = item.ToList();
                    dgv_ListEjercicios.Columns[11].Visible = false;
                    dgv_ListEjercicios.Columns[12].Visible = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al cargar los datos");
                }
            }
            else if (cbo_numEjercicio.Text == "Ejercicio 6 (Minuscula)")
            {
                try
                {
                    var item = linqControl.GetCustomersName().ToList();
                    var updatedItems = item.Select(p => new Customers
                    {
                        CustomerID = p.CustomerID,
                        CompanyName = p.CompanyName,
                        ContactTitle = p.ContactTitle,
                        Address = p.Address,
                        City = p.City,
                        Region = p.Region,
                        PostalCode = p.PostalCode,
                        Country = p.Country,
                        Phone = p.Phone,
                        Fax = p.Fax,
                        ContactName = p.ContactName.ToLower(),
                    }).ToList();
                    dgv_ListEjercicios.DataSource = null;
                    dgv_ListEjercicios.DataSource = updatedItems.ToList();
                    dgv_ListEjercicios.Columns[11].Visible = false;
                    dgv_ListEjercicios.Columns[12].Visible = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al cargar los datos");
                }
            }
            else if(cbo_numEjercicio.Text == "Ejercicio 7")
            {
                dgv_ListEjercicios.DataSource = null;
                dgv_ListEjercicios.DataSource = linqControl.GetJoinCustomersAndOrders().ToList();
                dgv_ListEjercicios.Columns[16].Visible = false;
            }
            else if(cbo_numEjercicio.Text == "Ejercicio 8")
            {
            
            }
            else if(cbo_numEjercicio.Text == "Ejercicio 9")
            {
                
            }
            else if(cbo_numEjercicio.Text == "Ejercico 10")
            {
                
            }
            else if (cbo_numEjercicio.Text == "Ejercicio 11")
            {
                
            }
            else if (cbo_numEjercicio.Text == "Ejercicio 12")
            {
                
            }
        }
    }
}
