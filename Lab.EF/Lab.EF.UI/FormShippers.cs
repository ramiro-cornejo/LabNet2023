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
    public partial class FormShippers : Form
    {
        private ShippersLogic _shLogic;
        public FormShippers()
        {
            InitializeComponent();
            ConfigDataGrid();
            _shLogic = new ShippersLogic();
            btn_Refresh_Click(null, new EventArgs());

        }
        private void LimpiarTextboxs()
        {
            this.txt_CompanyName.Text = "";
            this.txt_Phone.Text = "";


        }
        private bool Validation()
        {
            if (!string.IsNullOrEmpty(txt_CompanyName.Text.Trim()))
                return true;
            else
                return false;

        }
        private bool Exist()
        {
            bool existente = false;
            try
            {
                existente = _shLogic.Exist(txt_CompanyName.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            return existente;
        }
        private void ConfigDataGrid()
        {
            dgv_Shippers.MultiSelect = false;
            dgv_Shippers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Shippers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_Shippers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void MostrarDataGrid(object o)
        {
            dgv_Shippers.DataSource = null;
            dgv_Shippers.DataSource = o;
        }

        private void btn_InsertarShipper_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation())
                {
                    if (!Exist())
                    {
                        Shippers SH = new Shippers();
                        SH.CompanyName = txt_CompanyName.Text;
                        SH.Phone = txt_Phone.Text;

                        _shLogic.Add(SH);
                        MessageBox.Show("Insert.");
                        btn_Refresh_Click(null, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("CompanyName Exists.");
                    }
                }
                else
                {
                    MessageBox.Show("Campo oblicatorio (*)");
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

        private void btn_ActualizarShipper_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Shippers.RowCount > 0)
                {
                    Shippers SHP = null;
                    SHP = dgv_Shippers.SelectedRows[0].DataBoundItem as Shippers;
                    if (SHP != null)
                    {
                        if (!string.IsNullOrEmpty(txt_CompanyName.Text.Trim()))
                        {
                            SHP.CompanyName = txt_CompanyName.Text;
                            _shLogic.Update(SHP);
                            MessageBox.Show("Modificado.");
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

        private void btn_EliminarShipper_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Shippers.RowCount > 0)
                {
                    Shippers SHP = null;
                    SHP = dgv_Shippers.SelectedRows[0].DataBoundItem as Shippers;
                    _shLogic.Delete(SHP);
                    MessageBox.Show("Delete.");
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
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void dgv_Shippers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Shippers SH = null;
            if (dgv_Shippers.RowCount > 0)
            {

                SH = dgv_Shippers.SelectedRows[0].DataBoundItem as Shippers;
                if (SH != null)
                {
                    txt_CompanyName.Text = SH.CompanyName ?? "";
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarDataGrid(_shLogic.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
