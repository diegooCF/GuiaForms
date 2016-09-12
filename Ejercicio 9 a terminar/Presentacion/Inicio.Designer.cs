namespace Presentacion
{
    partial class frmInicio
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
            this.btnNewSocio = new System.Windows.Forms.Button();
            this.btnSuprSocio = new System.Windows.Forms.Button();
            this.btnNewPrestamo = new System.Windows.Forms.Button();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnBooksManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewSocio
            // 
            this.btnNewSocio.Location = new System.Drawing.Point(12, 12);
            this.btnNewSocio.Name = "btnNewSocio";
            this.btnNewSocio.Size = new System.Drawing.Size(123, 50);
            this.btnNewSocio.TabIndex = 0;
            this.btnNewSocio.Text = "Registrar Socio";
            this.btnNewSocio.UseVisualStyleBackColor = true;
            this.btnNewSocio.Click += new System.EventHandler(this.btnNewSocio_Click);
            // 
            // btnSuprSocio
            // 
            this.btnSuprSocio.Location = new System.Drawing.Point(141, 12);
            this.btnSuprSocio.Name = "btnSuprSocio";
            this.btnSuprSocio.Size = new System.Drawing.Size(122, 50);
            this.btnSuprSocio.TabIndex = 1;
            this.btnSuprSocio.Text = "Eliminar Socio";
            this.btnSuprSocio.UseVisualStyleBackColor = true;
            this.btnSuprSocio.Click += new System.EventHandler(this.btnSuprSocio_Click);
            // 
            // btnNewPrestamo
            // 
            this.btnNewPrestamo.Location = new System.Drawing.Point(13, 68);
            this.btnNewPrestamo.Name = "btnNewPrestamo";
            this.btnNewPrestamo.Size = new System.Drawing.Size(122, 50);
            this.btnNewPrestamo.TabIndex = 2;
            this.btnNewPrestamo.Text = "Nuevo Prestamo";
            this.btnNewPrestamo.UseVisualStyleBackColor = true;
            this.btnNewPrestamo.Click += new System.EventHandler(this.btnNewPrestamo_Click);
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Location = new System.Drawing.Point(141, 68);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(122, 50);
            this.btnDevolucion.TabIndex = 3;
            this.btnDevolucion.Text = "Devolucion de Libro";
            this.btnDevolucion.UseVisualStyleBackColor = true;
            // 
            // btnBooksManager
            // 
            this.btnBooksManager.Location = new System.Drawing.Point(12, 155);
            this.btnBooksManager.Name = "btnBooksManager";
            this.btnBooksManager.Size = new System.Drawing.Size(122, 50);
            this.btnBooksManager.TabIndex = 4;
            this.btnBooksManager.Text = "Gestor de Libros";
            this.btnBooksManager.UseVisualStyleBackColor = true;
            this.btnBooksManager.Click += new System.EventHandler(this.btnBooksManager_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 217);
            this.Controls.Add(this.btnBooksManager);
            this.Controls.Add(this.btnDevolucion);
            this.Controls.Add(this.btnNewPrestamo);
            this.Controls.Add(this.btnSuprSocio);
            this.Controls.Add(this.btnNewSocio);
            this.Name = "frmInicio";
            this.Text = "Gestor de Biblioteca";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewSocio;
        private System.Windows.Forms.Button btnSuprSocio;
        private System.Windows.Forms.Button btnNewPrestamo;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.Button btnBooksManager;
    }
}

