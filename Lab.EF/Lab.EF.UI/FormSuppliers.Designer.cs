namespace Lab.EF.UI
{
    partial class FormSuppliers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_Suppliers = new System.Windows.Forms.DataGridView();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txt_CompanyName = new System.Windows.Forms.TextBox();
            this.lblContactName = new System.Windows.Forms.Label();
            this.txt_ContactName = new System.Windows.Forms.TextBox();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.txt_ContactTitle = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.btn_InsertarSupp = new System.Windows.Forms.Button();
            this.btn_ActualizarSupp = new System.Windows.Forms.Button();
            this.btn_EliminarSupp = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Suppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Suppliers
            // 
            this.dgv_Suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Suppliers.Location = new System.Drawing.Point(27, 179);
            this.dgv_Suppliers.Name = "dgv_Suppliers";
            this.dgv_Suppliers.RowHeadersWidth = 51;
            this.dgv_Suppliers.RowTemplate.Height = 24;
            this.dgv_Suppliers.Size = new System.Drawing.Size(1034, 428);
            this.dgv_Suppliers.TabIndex = 19;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.ForeColor = System.Drawing.Color.Maroon;
            this.lblCompanyName.Location = new System.Drawing.Point(24, 38);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(121, 16);
            this.lblCompanyName.TabIndex = 20;
            this.lblCompanyName.Text = "Company Name (*)";
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CompanyName.Location = new System.Drawing.Point(27, 58);
            this.txt_CompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(202, 22);
            this.txt_CompanyName.TabIndex = 21;
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(267, 38);
            this.lblContactName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(92, 16);
            this.lblContactName.TabIndex = 22;
            this.lblContactName.Text = "Contact Name";
            // 
            // txt_ContactName
            // 
            this.txt_ContactName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ContactName.Location = new System.Drawing.Point(270, 58);
            this.txt_ContactName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ContactName.Name = "txt_ContactName";
            this.txt_ContactName.Size = new System.Drawing.Size(202, 22);
            this.txt_ContactName.TabIndex = 23;
            // 
            // lblContactTitle
            // 
            this.lblContactTitle.AutoSize = true;
            this.lblContactTitle.Location = new System.Drawing.Point(24, 94);
            this.lblContactTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactTitle.Name = "lblContactTitle";
            this.lblContactTitle.Size = new System.Drawing.Size(81, 16);
            this.lblContactTitle.TabIndex = 24;
            this.lblContactTitle.Text = "Contact Title";
            // 
            // txt_ContactTitle
            // 
            this.txt_ContactTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ContactTitle.Location = new System.Drawing.Point(27, 114);
            this.txt_ContactTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ContactTitle.Name = "txt_ContactTitle";
            this.txt_ContactTitle.Size = new System.Drawing.Size(202, 22);
            this.txt_ContactTitle.TabIndex = 25;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(552, 38);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 16);
            this.lblCity.TabIndex = 26;
            this.lblCity.Text = "City";
            // 
            // txt_City
            // 
            this.txt_City.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_City.Location = new System.Drawing.Point(555, 58);
            this.txt_City.Margin = new System.Windows.Forms.Padding(4);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(358, 22);
            this.txt_City.TabIndex = 27;
            // 
            // btn_InsertarSupp
            // 
            this.btn_InsertarSupp.Location = new System.Drawing.Point(737, 141);
            this.btn_InsertarSupp.Name = "btn_InsertarSupp";
            this.btn_InsertarSupp.Size = new System.Drawing.Size(75, 23);
            this.btn_InsertarSupp.TabIndex = 28;
            this.btn_InsertarSupp.Text = "Insertar";
            this.btn_InsertarSupp.UseVisualStyleBackColor = true;
            this.btn_InsertarSupp.Click += new System.EventHandler(this.btn_InsertarSupp_Click);
            // 
            // btn_ActualizarSupp
            // 
            this.btn_ActualizarSupp.Location = new System.Drawing.Point(854, 141);
            this.btn_ActualizarSupp.Name = "btn_ActualizarSupp";
            this.btn_ActualizarSupp.Size = new System.Drawing.Size(94, 23);
            this.btn_ActualizarSupp.TabIndex = 29;
            this.btn_ActualizarSupp.Text = "Actualizar";
            this.btn_ActualizarSupp.UseVisualStyleBackColor = true;
            this.btn_ActualizarSupp.Click += new System.EventHandler(this.btn_ActualizarSupp_Click);
            // 
            // btn_EliminarSupp
            // 
            this.btn_EliminarSupp.Location = new System.Drawing.Point(986, 141);
            this.btn_EliminarSupp.Name = "btn_EliminarSupp";
            this.btn_EliminarSupp.Size = new System.Drawing.Size(75, 23);
            this.btn_EliminarSupp.TabIndex = 30;
            this.btn_EliminarSupp.Text = "Eliminar";
            this.btn_EliminarSupp.UseVisualStyleBackColor = true;
            this.btn_EliminarSupp.Click += new System.EventHandler(this.btn_EliminarSupp_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(873, 613);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 31;
            this.btn_Refresh.Text = "Refrescar";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(986, 613);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 32;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // FormSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 648);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_EliminarSupp);
            this.Controls.Add(this.btn_ActualizarSupp);
            this.Controls.Add(this.btn_InsertarSupp);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txt_ContactTitle);
            this.Controls.Add(this.lblContactTitle);
            this.Controls.Add(this.txt_ContactName);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.txt_CompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.dgv_Suppliers);
            this.Name = "FormSuppliers";
            this.Text = "FormSuppliers";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Suppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Suppliers;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txt_CompanyName;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.TextBox txt_ContactName;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.TextBox txt_ContactTitle;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Button btn_InsertarSupp;
        private System.Windows.Forms.Button btn_ActualizarSupp;
        private System.Windows.Forms.Button btn_EliminarSupp;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Salir;
    }
}