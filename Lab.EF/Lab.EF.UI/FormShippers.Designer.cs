namespace Lab.EF.UI
{
    partial class FormShippers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CompanyName = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.btn_InsertarShipper = new System.Windows.Forms.Button();
            this.btn_ActualizarShipper = new System.Windows.Forms.Button();
            this.btn_EliminarShipper = new System.Windows.Forms.Button();
            this.dgv_Shippers = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Shippers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos de Shippers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Company Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.Location = new System.Drawing.Point(46, 95);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(220, 22);
            this.txt_CompanyName.TabIndex = 4;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(455, 95);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(220, 22);
            this.txt_Phone.TabIndex = 5;
            // 
            // btn_InsertarShipper
            // 
            this.btn_InsertarShipper.Location = new System.Drawing.Point(600, 154);
            this.btn_InsertarShipper.Name = "btn_InsertarShipper";
            this.btn_InsertarShipper.Size = new System.Drawing.Size(75, 23);
            this.btn_InsertarShipper.TabIndex = 7;
            this.btn_InsertarShipper.Text = "Insertar";
            this.btn_InsertarShipper.UseVisualStyleBackColor = true;
            this.btn_InsertarShipper.Click += new System.EventHandler(this.btn_InsertarShipper_Click);
            // 
            // btn_ActualizarShipper
            // 
            this.btn_ActualizarShipper.Location = new System.Drawing.Point(725, 154);
            this.btn_ActualizarShipper.Name = "btn_ActualizarShipper";
            this.btn_ActualizarShipper.Size = new System.Drawing.Size(100, 23);
            this.btn_ActualizarShipper.TabIndex = 8;
            this.btn_ActualizarShipper.Text = "Actualizar";
            this.btn_ActualizarShipper.UseVisualStyleBackColor = true;
            this.btn_ActualizarShipper.Click += new System.EventHandler(this.btn_ActualizarShipper_Click);
            // 
            // btn_EliminarShipper
            // 
            this.btn_EliminarShipper.Location = new System.Drawing.Point(874, 154);
            this.btn_EliminarShipper.Name = "btn_EliminarShipper";
            this.btn_EliminarShipper.Size = new System.Drawing.Size(75, 23);
            this.btn_EliminarShipper.TabIndex = 9;
            this.btn_EliminarShipper.Text = "Eliminar";
            this.btn_EliminarShipper.UseVisualStyleBackColor = true;
            this.btn_EliminarShipper.Click += new System.EventHandler(this.btn_EliminarShipper_Click);
            // 
            // dgv_Shippers
            // 
            this.dgv_Shippers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Shippers.Location = new System.Drawing.Point(46, 220);
            this.dgv_Shippers.Name = "dgv_Shippers";
            this.dgv_Shippers.RowHeadersWidth = 51;
            this.dgv_Shippers.RowTemplate.Height = 24;
            this.dgv_Shippers.Size = new System.Drawing.Size(903, 368);
            this.dgv_Shippers.TabIndex = 10;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(750, 594);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 12;
            this.btn_Refresh.Text = "Refrescar";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(874, 594);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 13;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // FormShippers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 652);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv_Shippers);
            this.Controls.Add(this.btn_EliminarShipper);
            this.Controls.Add(this.btn_ActualizarShipper);
            this.Controls.Add(this.btn_InsertarShipper);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.txt_CompanyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormShippers";
            this.Text = "Shippers";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Shippers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CompanyName;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Button btn_InsertarShipper;
        private System.Windows.Forms.Button btn_ActualizarShipper;
        private System.Windows.Forms.Button btn_EliminarShipper;
        private System.Windows.Forms.DataGridView dgv_Shippers;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Salir;
    }
}