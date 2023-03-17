namespace Lab.EF.UI
{
    partial class FormLinq
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
            this.dgv_ListLinq = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListLinq)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListLinq
            // 
            this.dgv_ListLinq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListLinq.Location = new System.Drawing.Point(27, 125);
            this.dgv_ListLinq.Name = "dgv_ListLinq";
            this.dgv_ListLinq.RowHeadersWidth = 51;
            this.dgv_ListLinq.RowTemplate.Height = 24;
            this.dgv_ListLinq.Size = new System.Drawing.Size(725, 313);
            this.dgv_ListLinq.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ejercicios Linq";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ejercicio 1",
            "Ejercicio 2",
            "Ejercicio 3",
            "Ejercicio 4",
            "Ejercicio 5",
            "Ejercicio 6",
            "Ejercicio 7",
            "Ejercicio 8 ",
            "Ejercicio 9 ",
            "Ejercicio 10 ",
            "Ejercicio 11 ",
            "Ejercicio 12 ",
            "Ejercicio 13"});
            this.comboBox1.Location = new System.Drawing.Point(27, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccionar número de ejercicio";
            // 
            // FormLinq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_ListLinq);
            this.Name = "FormLinq";
            this.Text = "FormLinq";
            this.Load += new System.EventHandler(this.FormLinq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListLinq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListLinq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}