using Lab.EF.Entities;
using Lab.EF.Logic.Logic;
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
    public partial class FormSuppliers : Form
    {
        private SuppliersLogic _spLogic;
        public FormSuppliers()
        {
            InitializeComponent();
            ConfigurarDataGrid();
            _spLogic = new SuppliersLogic();
            btn_Refresh_Click(null, new EventArgs());
        }

        private void btn_InsertarSupp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (!Exist())
                    {
                        Suppliers SP = new Suppliers();
                        SP.CompanyName = txt_CompanyName.Text;
                        SP.ContactName = txt_ContactName.Text;
                        SP.ContactTitle = txt_ContactTitle.Text;
                        SP.City = txt_City.Text;

                        _spLogic.Add(SP);
                        MessageBox.Show("insertado");
                        btn_Refresh_Click(null, new EventArgs());
                    }
                    else
                        MessageBox.Show("Nombre de compañía existente");

                }
                else
                    MessageBox.Show("Ingresar campo obligatorio (*)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                LimpiarTextboxs();
            }
        }

        private void ConfigurarDataGrid()
        {
            dgv_Suppliers.MultiSelect = false;
            dgv_Suppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Suppliers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_Suppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void MostrarDataGrid(object o)
        {
            dgv_Suppliers.DataSource = null;
            dgv_Suppliers.DataSource = o;
        }

        private bool Exist()
        {
            bool existe = false;
            try
            {
                existe = _spLogic.Exist(txt_CompanyName.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            return existe;
        }

        private void LimpiarTextboxs()
        {
            this.txt_City.Text = "";
            this.txt_CompanyName.Text = "";
            this.txt_ContactName.Text = "";
            this.txt_ContactTitle.Text = "";

        }
        private bool Validar()
        {
            if (!string.IsNullOrEmpty(txt_CompanyName.Text.Trim()))
                return true;
            else
                return false;

        }


        private void dgv_Suppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Suppliers SP = null;
            if (dgv_Suppliers.RowCount > 0)
            {

                SP = dgv_Suppliers.SelectedRows[0].DataBoundItem as Suppliers;
                if (SP != null)
                {
                    txt_ContactTitle.Text = SP.ContactTitle ?? "";
                    txt_City.Text = SP.City ?? "";
                    txt_ContactName.Text = SP.ContactName ?? "";
                    txt_CompanyName.Text = SP.CompanyName ?? "";
                }
            }
        }

        private void btn_ActualizarSupp_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Suppliers.RowCount > 0)
                {
                    Suppliers SPP = null;
                    SPP = dgv_Suppliers.SelectedRows[0].DataBoundItem as Suppliers;
                    if (SPP != null)
                    {
                        if (!string.IsNullOrEmpty(txt_CompanyName.Text.Trim()))
                        {
                            SPP.City = txt_City.Text;
                            SPP.CompanyName = txt_CompanyName.Text;
                            SPP.ContactTitle = txt_ContactTitle.Text;
                            SPP.ContactName = txt_ContactName.Text;
                            _spLogic.Update(SPP);
                            MessageBox.Show("modificado");
                            btn_Refresh_Click(null, new EventArgs());
                        }
                        else
                            MessageBox.Show("Escriba un CompanyName para modificar");

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                LimpiarTextboxs();
            }
        }

        private void btn_EliminarSupp_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Suppliers.RowCount > 0)
                {
                    Suppliers SPP = null;
                    SPP = dgv_Suppliers.SelectedRows[0].DataBoundItem as Suppliers;
                    _spLogic.Delete(SPP);
                    MessageBox.Show("eliminado");
                    btn_Refresh_Click(null, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                LimpiarTextboxs();
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarDataGrid(_spLogic.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
