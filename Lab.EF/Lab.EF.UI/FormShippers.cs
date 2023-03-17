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
    public partial class FormShippers : Form
    {
        private ShippersControl _shippersControl;
        public FormShippers()
        {
            InitializeComponent();
            ConfigDataGrid();
            _shippersControl = new ShippersControl();
            btn_Refresh_Click(null, new EventArgs());

        }
        private void RefreshTextboxs()
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
                existente = _shippersControl.Exist(txt_CompanyName.Text.Trim());
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
                        Shippers shippers = new Shippers();
                        shippers.CompanyName = txt_CompanyName.Text;
                        shippers.Phone = txt_Phone.Text;

                        _shippersControl.Add(shippers);
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
                RefreshTextboxs();
            }
        }

        private void btn_ActualizarShipper_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Shippers.RowCount > 0)
                {
                    Shippers shippers = null;
                    shippers = dgv_Shippers.SelectedRows[0].DataBoundItem as Shippers;
                    if (shippers != null)
                    {
                        if (!string.IsNullOrEmpty(txt_CompanyName.Text.Trim()))
                        {
                            shippers.CompanyName = txt_CompanyName.Text;
                            _shippersControl.Update(shippers);
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
                RefreshTextboxs();
            }
        }

        private void btn_EliminarShipper_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Shippers.RowCount > 0)
                {
                    Shippers shipperss = null;
                    shipperss = dgv_Shippers.SelectedRows[0].DataBoundItem as Shippers;
                    _shippersControl.Delete(shipperss);
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
                RefreshTextboxs();
            }
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void dgv_Shippers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Shippers shippers = null;
            if (dgv_Shippers.RowCount > 0)
            {

                shippers = dgv_Shippers.SelectedRows[0].DataBoundItem as Shippers;
                if (shippers != null)
                {
                    txt_CompanyName.Text = shippers.CompanyName ?? "";
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarDataGrid(_shippersControl.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
