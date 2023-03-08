namespace LabNetPractica2
{
    partial class FormEjercicio02
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NumDividendo = new System.Windows.Forms.TextBox();
            this.txt_NumDivisor = new System.Windows.Forms.TextBox();
            this.btn_Dividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar números a dividir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número dividendo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número divisor";
            // 
            // txt_NumDividendo
            // 
            this.txt_NumDividendo.Location = new System.Drawing.Point(48, 83);
            this.txt_NumDividendo.Name = "txt_NumDividendo";
            this.txt_NumDividendo.Size = new System.Drawing.Size(184, 22);
            this.txt_NumDividendo.TabIndex = 4;
            // 
            // txt_NumDivisor
            // 
            this.txt_NumDivisor.Location = new System.Drawing.Point(48, 143);
            this.txt_NumDivisor.Name = "txt_NumDivisor";
            this.txt_NumDivisor.Size = new System.Drawing.Size(184, 22);
            this.txt_NumDivisor.TabIndex = 5;
            // 
            // btn_Dividir
            // 
            this.btn_Dividir.Location = new System.Drawing.Point(157, 203);
            this.btn_Dividir.Name = "btn_Dividir";
            this.btn_Dividir.Size = new System.Drawing.Size(75, 23);
            this.btn_Dividir.TabIndex = 6;
            this.btn_Dividir.Text = "Dividir";
            this.btn_Dividir.UseVisualStyleBackColor = true;
            this.btn_Dividir.Click += new System.EventHandler(this.btn_Dividir_Click);
            // 
            // FormEjercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 248);
            this.Controls.Add(this.btn_Dividir);
            this.Controls.Add(this.txt_NumDivisor);
            this.Controls.Add(this.txt_NumDividendo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormEjercicio02";
            this.Text = "FormEjercicio02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NumDividendo;
        private System.Windows.Forms.TextBox txt_NumDivisor;
        private System.Windows.Forms.Button btn_Dividir;
    }
}