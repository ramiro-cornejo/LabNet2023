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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CampanyName = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.nupd_ShipperID = new System.Windows.Forms.NumericUpDown();
            this.btn_InsertarShipper = new System.Windows.Forms.Button();
            this.btn_ActualizarShipper = new System.Windows.Forms.Button();
            this.btn_EliminarShipper = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_ShipperID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shipper ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Company Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // txt_CampanyName
            // 
            this.txt_CampanyName.Location = new System.Drawing.Point(163, 95);
            this.txt_CampanyName.Name = "txt_CampanyName";
            this.txt_CampanyName.Size = new System.Drawing.Size(220, 22);
            this.txt_CampanyName.TabIndex = 4;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(439, 95);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(220, 22);
            this.txt_Phone.TabIndex = 5;
            // 
            // nupd_ShipperID
            // 
            this.nupd_ShipperID.Location = new System.Drawing.Point(46, 96);
            this.nupd_ShipperID.Name = "nupd_ShipperID";
            this.nupd_ShipperID.Size = new System.Drawing.Size(67, 22);
            this.nupd_ShipperID.TabIndex = 6;
            // 
            // btn_InsertarShipper
            // 
            this.btn_InsertarShipper.Location = new System.Drawing.Point(344, 154);
            this.btn_InsertarShipper.Name = "btn_InsertarShipper";
            this.btn_InsertarShipper.Size = new System.Drawing.Size(75, 23);
            this.btn_InsertarShipper.TabIndex = 7;
            this.btn_InsertarShipper.Text = "Insertar";
            this.btn_InsertarShipper.UseVisualStyleBackColor = true;
            // 
            // btn_ActualizarShipper
            // 
            this.btn_ActualizarShipper.Location = new System.Drawing.Point(452, 154);
            this.btn_ActualizarShipper.Name = "btn_ActualizarShipper";
            this.btn_ActualizarShipper.Size = new System.Drawing.Size(100, 23);
            this.btn_ActualizarShipper.TabIndex = 8;
            this.btn_ActualizarShipper.Text = "Actualizar";
            this.btn_ActualizarShipper.UseVisualStyleBackColor = true;
            // 
            // btn_EliminarShipper
            // 
            this.btn_EliminarShipper.Location = new System.Drawing.Point(584, 154);
            this.btn_EliminarShipper.Name = "btn_EliminarShipper";
            this.btn_EliminarShipper.Size = new System.Drawing.Size(75, 23);
            this.btn_EliminarShipper.TabIndex = 9;
            this.btn_EliminarShipper.Text = "Eliminar";
            this.btn_EliminarShipper.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(613, 206);
            this.dataGridView1.TabIndex = 10;
            // 
            // FormShippers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_EliminarShipper);
            this.Controls.Add(this.btn_ActualizarShipper);
            this.Controls.Add(this.btn_InsertarShipper);
            this.Controls.Add(this.nupd_ShipperID);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.txt_CampanyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormShippers";
            this.Text = "Shippers";
            ((System.ComponentModel.ISupportInitialize)(this.nupd_ShipperID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CampanyName;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.NumericUpDown nupd_ShipperID;
        private System.Windows.Forms.Button btn_InsertarShipper;
        private System.Windows.Forms.Button btn_ActualizarShipper;
        private System.Windows.Forms.Button btn_EliminarShipper;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}