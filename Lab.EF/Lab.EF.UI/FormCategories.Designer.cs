namespace Lab.EF.UI
{
    partial class FormCategories
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
            this.txt_DescriptionCat = new System.Windows.Forms.TextBox();
            this.txt_CategoryName = new System.Windows.Forms.TextBox();
            this.txt_Picture = new System.Windows.Forms.TextBox();
            this.nupd_CategoryID = new System.Windows.Forms.NumericUpDown();
            this.btn_InsertarCat = new System.Windows.Forms.Button();
            this.btn_ActualizarCat = new System.Windows.Forms.Button();
            this.btn_EliminarCat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_Categories = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_CategoryID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categories)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Picture";
            // 
            // txt_DescriptionCat
            // 
            this.txt_DescriptionCat.Location = new System.Drawing.Point(313, 80);
            this.txt_DescriptionCat.Name = "txt_DescriptionCat";
            this.txt_DescriptionCat.Size = new System.Drawing.Size(156, 22);
            this.txt_DescriptionCat.TabIndex = 4;
            // 
            // txt_CategoryName
            // 
            this.txt_CategoryName.Location = new System.Drawing.Point(154, 80);
            this.txt_CategoryName.Name = "txt_CategoryName";
            this.txt_CategoryName.Size = new System.Drawing.Size(120, 22);
            this.txt_CategoryName.TabIndex = 5;
            // 
            // txt_Picture
            // 
            this.txt_Picture.Location = new System.Drawing.Point(519, 80);
            this.txt_Picture.Name = "txt_Picture";
            this.txt_Picture.Size = new System.Drawing.Size(156, 22);
            this.txt_Picture.TabIndex = 6;
            // 
            // nupd_CategoryID
            // 
            this.nupd_CategoryID.Location = new System.Drawing.Point(32, 80);
            this.nupd_CategoryID.Name = "nupd_CategoryID";
            this.nupd_CategoryID.Size = new System.Drawing.Size(75, 22);
            this.nupd_CategoryID.TabIndex = 7;
            // 
            // btn_InsertarCat
            // 
            this.btn_InsertarCat.Location = new System.Drawing.Point(394, 136);
            this.btn_InsertarCat.Name = "btn_InsertarCat";
            this.btn_InsertarCat.Size = new System.Drawing.Size(75, 23);
            this.btn_InsertarCat.TabIndex = 8;
            this.btn_InsertarCat.Text = "Insertar";
            this.btn_InsertarCat.UseVisualStyleBackColor = true;
            this.btn_InsertarCat.Click += new System.EventHandler(this.btn_InsertarCat_Click);
            // 
            // btn_ActualizarCat
            // 
            this.btn_ActualizarCat.Location = new System.Drawing.Point(486, 136);
            this.btn_ActualizarCat.Name = "btn_ActualizarCat";
            this.btn_ActualizarCat.Size = new System.Drawing.Size(94, 23);
            this.btn_ActualizarCat.TabIndex = 9;
            this.btn_ActualizarCat.Text = "Actualizar";
            this.btn_ActualizarCat.UseVisualStyleBackColor = true;
            this.btn_ActualizarCat.Click += new System.EventHandler(this.btn_ActualizarCat_Click);
            // 
            // btn_EliminarCat
            // 
            this.btn_EliminarCat.Location = new System.Drawing.Point(600, 136);
            this.btn_EliminarCat.Name = "btn_EliminarCat";
            this.btn_EliminarCat.Size = new System.Drawing.Size(75, 23);
            this.btn_EliminarCat.TabIndex = 10;
            this.btn_EliminarCat.Text = "Eliminar";
            this.btn_EliminarCat.UseVisualStyleBackColor = true;
            this.btn_EliminarCat.Click += new System.EventHandler(this.btn_EliminarCat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Datos de categorias";
            // 
            // dgv_Categories
            // 
            this.dgv_Categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Categories.Location = new System.Drawing.Point(32, 204);
            this.dgv_Categories.Name = "dgv_Categories";
            this.dgv_Categories.RowHeadersWidth = 51;
            this.dgv_Categories.RowTemplate.Height = 24;
            this.dgv_Categories.Size = new System.Drawing.Size(643, 222);
            this.dgv_Categories.TabIndex = 12;
            this.dgv_Categories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Categories_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Refrescar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_Categories);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_EliminarCat);
            this.Controls.Add(this.btn_ActualizarCat);
            this.Controls.Add(this.btn_InsertarCat);
            this.Controls.Add(this.nupd_CategoryID);
            this.Controls.Add(this.txt_Picture);
            this.Controls.Add(this.txt_CategoryName);
            this.Controls.Add(this.txt_DescriptionCat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCategories";
            this.Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.nupd_CategoryID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DescriptionCat;
        private System.Windows.Forms.TextBox txt_CategoryName;
        private System.Windows.Forms.TextBox txt_Picture;
        private System.Windows.Forms.NumericUpDown nupd_CategoryID;
        private System.Windows.Forms.Button btn_InsertarCat;
        private System.Windows.Forms.Button btn_ActualizarCat;
        private System.Windows.Forms.Button btn_EliminarCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_Categories;
        private System.Windows.Forms.Button button1;
    }
}