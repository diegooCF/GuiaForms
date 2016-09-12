namespace InterfazEjercicio2
{
    partial class frmMain
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
            this.btnDesplegar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEquilatero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDesplegar
            // 
            this.btnDesplegar.Location = new System.Drawing.Point(12, 12);
            this.btnDesplegar.Name = "btnDesplegar";
            this.btnDesplegar.Size = new System.Drawing.Size(115, 46);
            this.btnDesplegar.TabIndex = 0;
            this.btnDesplegar.Text = "Desplegar";
            this.btnDesplegar.UseVisualStyleBackColor = true;
            this.btnDesplegar.Click += new System.EventHandler(this.btnDesplegar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 64);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(239, 46);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEquilatero
            // 
            this.btnEquilatero.Location = new System.Drawing.Point(133, 12);
            this.btnEquilatero.Name = "btnEquilatero";
            this.btnEquilatero.Size = new System.Drawing.Size(115, 46);
            this.btnEquilatero.TabIndex = 0;
            this.btnEquilatero.Text = "Area y Perimetro de Equilatero";
            this.btnEquilatero.UseVisualStyleBackColor = true;
            this.btnEquilatero.Click += new System.EventHandler(this.btnEquilatero_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 125);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEquilatero);
            this.Controls.Add(this.btnDesplegar);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 2";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDesplegar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEquilatero;
    }
}