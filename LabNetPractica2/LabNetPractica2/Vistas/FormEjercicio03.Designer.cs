namespace LabNetPractica2
{
    partial class FormEjercicio03
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
            this.btn_InfExcepcion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_InfExcepcion
            // 
            this.btn_InfExcepcion.Location = new System.Drawing.Point(105, 79);
            this.btn_InfExcepcion.Name = "btn_InfExcepcion";
            this.btn_InfExcepcion.Size = new System.Drawing.Size(227, 26);
            this.btn_InfExcepcion.TabIndex = 0;
            this.btn_InfExcepcion.Text = "Ver información de Excepción";
            this.btn_InfExcepcion.UseVisualStyleBackColor = true;
            this.btn_InfExcepcion.Click += new System.EventHandler(this.btn_InfExcepcion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mensaje de la excepción y el tipo de la excepción";
            // 
            // FormEjercicio03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 132);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_InfExcepcion);
            this.Name = "FormEjercicio03";
            this.Text = "FormEjercicio03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_InfExcepcion;
        private System.Windows.Forms.Label label1;
    }
}