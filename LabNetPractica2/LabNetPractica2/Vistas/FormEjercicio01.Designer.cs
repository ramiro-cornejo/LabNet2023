namespace LabNetPractica2
{
    partial class FormEjercicio01
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
            this.label2 = new System.Windows.Forms.Label();
            this.nupd_NumValor = new System.Windows.Forms.NumericUpDown();
            this.btn_RealizarOperacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_NumValor)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(68, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar un valor para dividir";
            // 
            // nupd_NumValor
            // 
            this.nupd_NumValor.Location = new System.Drawing.Point(71, 53);
            this.nupd_NumValor.Name = "nupd_NumValor";
            this.nupd_NumValor.Size = new System.Drawing.Size(203, 22);
            this.nupd_NumValor.TabIndex = 2;
            // 
            // btn_RealizarOperacion
            // 
            this.btn_RealizarOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RealizarOperacion.Location = new System.Drawing.Point(122, 109);
            this.btn_RealizarOperacion.Name = "btn_RealizarOperacion";
            this.btn_RealizarOperacion.Size = new System.Drawing.Size(152, 29);
            this.btn_RealizarOperacion.TabIndex = 3;
            this.btn_RealizarOperacion.Text = "Realizar operación";
            this.btn_RealizarOperacion.UseVisualStyleBackColor = true;
            this.btn_RealizarOperacion.Click += new System.EventHandler(this.btn_RealizarOperacion_Click);
            // 
            // FormEjercicio01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 176);
            this.Controls.Add(this.btn_RealizarOperacion);
            this.Controls.Add(this.nupd_NumValor);
            this.Controls.Add(this.label2);
            this.Name = "FormEjercicio01";
            this.Text = "FormEjercicio01";
            ((System.ComponentModel.ISupportInitialize)(this.nupd_NumValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupd_NumValor;
        private System.Windows.Forms.Button btn_RealizarOperacion;
    }
}