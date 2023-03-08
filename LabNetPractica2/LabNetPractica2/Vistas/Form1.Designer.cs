namespace LabNetPractica2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verEjerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio03ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio04ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verEjerciciosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verEjerciciosToolStripMenuItem
            // 
            this.verEjerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejercicio01ToolStripMenuItem,
            this.ejercicio02ToolStripMenuItem,
            this.ejercicio03ToolStripMenuItem,
            this.ejercicio04ToolStripMenuItem});
            this.verEjerciciosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verEjerciciosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.verEjerciciosToolStripMenuItem.Name = "verEjerciciosToolStripMenuItem";
            this.verEjerciciosToolStripMenuItem.Size = new System.Drawing.Size(136, 29);
            this.verEjerciciosToolStripMenuItem.Text = "Ver ejercicios";
            // 
            // ejercicio01ToolStripMenuItem
            // 
            this.ejercicio01ToolStripMenuItem.Name = "ejercicio01ToolStripMenuItem";
            this.ejercicio01ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ejercicio01ToolStripMenuItem.Text = "Ejercicio 01";
            this.ejercicio01ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio01ToolStripMenuItem_Click);
            // 
            // ejercicio02ToolStripMenuItem
            // 
            this.ejercicio02ToolStripMenuItem.Name = "ejercicio02ToolStripMenuItem";
            this.ejercicio02ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ejercicio02ToolStripMenuItem.Text = "Ejercicio 02";
            this.ejercicio02ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio02ToolStripMenuItem_Click);
            // 
            // ejercicio03ToolStripMenuItem
            // 
            this.ejercicio03ToolStripMenuItem.Name = "ejercicio03ToolStripMenuItem";
            this.ejercicio03ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ejercicio03ToolStripMenuItem.Text = "Ejercicio 03";
            this.ejercicio03ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio03ToolStripMenuItem_Click);
            // 
            // ejercicio04ToolStripMenuItem
            // 
            this.ejercicio04ToolStripMenuItem.Name = "ejercicio04ToolStripMenuItem";
            this.ejercicio04ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ejercicio04ToolStripMenuItem.Text = "Ejercicio 04";
            this.ejercicio04ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio04ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(102, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 135);
            this.label1.TabIndex = 1;
            this.label1.Text = "LAB .NET";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verEjerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio02ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio03ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio04ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

