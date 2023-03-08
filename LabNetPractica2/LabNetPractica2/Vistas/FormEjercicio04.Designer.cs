namespace LabNetPractica2
{
    partial class FormEjercicio04
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
            this.btn_InfExcepcionPers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de excepción personalizada";
            // 
            // btn_InfExcepcionPers
            // 
            this.btn_InfExcepcionPers.Location = new System.Drawing.Point(92, 77);
            this.btn_InfExcepcionPers.Name = "btn_InfExcepcionPers";
            this.btn_InfExcepcionPers.Size = new System.Drawing.Size(237, 28);
            this.btn_InfExcepcionPers.TabIndex = 1;
            this.btn_InfExcepcionPers.Text = "Ver información de excepción ";
            this.btn_InfExcepcionPers.UseVisualStyleBackColor = true;
            this.btn_InfExcepcionPers.Click += new System.EventHandler(this.btn_InfExcepcionPers_Click);
            // 
            // FormEjercicio04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 128);
            this.Controls.Add(this.btn_InfExcepcionPers);
            this.Controls.Add(this.label1);
            this.Name = "FormEjercicio04";
            this.Text = "FormEjercicio04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_InfExcepcionPers;
    }
}