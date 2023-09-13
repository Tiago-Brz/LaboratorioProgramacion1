namespace trabajo1
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
            this.Mezclar_btn = new System.Windows.Forms.Button();
            this.Salir_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Cartas_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Mezclar_btn
            // 
            this.Mezclar_btn.BackColor = System.Drawing.Color.Black;
            this.Mezclar_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Mezclar_btn.FlatAppearance.BorderSize = 3;
            this.Mezclar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mezclar_btn.ForeColor = System.Drawing.Color.White;
            this.Mezclar_btn.Location = new System.Drawing.Point(115, 28);
            this.Mezclar_btn.Name = "Mezclar_btn";
            this.Mezclar_btn.Size = new System.Drawing.Size(106, 29);
            this.Mezclar_btn.TabIndex = 0;
            this.Mezclar_btn.Text = "Mezclar Cartas";
            this.Mezclar_btn.UseVisualStyleBackColor = false;
            this.Mezclar_btn.Click += new System.EventHandler(this.Mezclar_btn_Click);
            // 
            // Salir_btn
            // 
            this.Salir_btn.BackColor = System.Drawing.Color.Black;
            this.Salir_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Salir_btn.FlatAppearance.BorderSize = 2;
            this.Salir_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir_btn.ForeColor = System.Drawing.Color.White;
            this.Salir_btn.Location = new System.Drawing.Point(176, 220);
            this.Salir_btn.Name = "Salir_btn";
            this.Salir_btn.Size = new System.Drawing.Size(75, 23);
            this.Salir_btn.TabIndex = 1;
            this.Salir_btn.Text = "Salir";
            this.Salir_btn.UseVisualStyleBackColor = false;
            this.Salir_btn.Click += new System.EventHandler(this.Salir_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tus Cartas:";
            // 
            // Cartas_lbl
            // 
            this.Cartas_lbl.AutoSize = true;
            this.Cartas_lbl.ForeColor = System.Drawing.Color.White;
            this.Cartas_lbl.Location = new System.Drawing.Point(100, 88);
            this.Cartas_lbl.Name = "Cartas_lbl";
            this.Cartas_lbl.Size = new System.Drawing.Size(0, 13);
            this.Cartas_lbl.TabIndex = 3;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(302, 259);
            this.Controls.Add(this.Cartas_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Salir_btn);
            this.Controls.Add(this.Mezclar_btn);
            this.Name = "Form1";
            this.Text = "Baraja de Cartas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCartas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Mezclar_btn;
        private System.Windows.Forms.Button Salir_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Cartas_lbl;
    }
}

