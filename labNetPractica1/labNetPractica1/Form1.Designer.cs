namespace labNetPractica1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_TipoTransporte = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nupd_CantPasajeros = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_TransPub = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_CantPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transporte Público";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Transporte Público";
            // 
            // cbo_TipoTransporte
            // 
            this.cbo_TipoTransporte.FormattingEnabled = true;
            this.cbo_TipoTransporte.Location = new System.Drawing.Point(54, 131);
            this.cbo_TipoTransporte.Name = "cbo_TipoTransporte";
            this.cbo_TipoTransporte.Size = new System.Drawing.Size(168, 24);
            this.cbo_TipoTransporte.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad de pasajeros";
            // 
            // nupd_CantPasajeros
            // 
            this.nupd_CantPasajeros.Location = new System.Drawing.Point(298, 131);
            this.nupd_CantPasajeros.Name = "nupd_CantPasajeros";
            this.nupd_CantPasajeros.Size = new System.Drawing.Size(141, 22);
            this.nupd_CantPasajeros.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Datos cargados";
            // 
            // lb_TransPub
            // 
            this.lb_TransPub.ForeColor = System.Drawing.Color.Black;
            this.lb_TransPub.FormattingEnabled = true;
            this.lb_TransPub.ItemHeight = 16;
            this.lb_TransPub.Location = new System.Drawing.Point(54, 262);
            this.lb_TransPub.Margin = new System.Windows.Forms.Padding(4);
            this.lb_TransPub.Name = "lb_TransPub";
            this.lb_TransPub.Size = new System.Drawing.Size(364, 164);
            this.lb_TransPub.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cargar datos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_TransPub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nupd_CantPasajeros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_TipoTransporte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nupd_CantPasajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_TipoTransporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupd_CantPasajeros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lb_TransPub;
        private System.Windows.Forms.Button button1;
    }
}

