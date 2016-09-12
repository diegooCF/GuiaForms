namespace Ejercicio8
{
    partial class Estacionamiento
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngresaVehiculo = new System.Windows.Forms.Button();
            this.btnSaleVehiculo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresaVehiculo
            // 
            this.btnIngresaVehiculo.Location = new System.Drawing.Point(12, 12);
            this.btnIngresaVehiculo.Name = "btnIngresaVehiculo";
            this.btnIngresaVehiculo.Size = new System.Drawing.Size(116, 33);
            this.btnIngresaVehiculo.TabIndex = 1;
            this.btnIngresaVehiculo.Text = "Ingresar Vehiculo";
            this.btnIngresaVehiculo.UseVisualStyleBackColor = true;
            this.btnIngresaVehiculo.Click += new System.EventHandler(this.btnIngresaVehiculo_Click);
            // 
            // btnSaleVehiculo
            // 
            this.btnSaleVehiculo.Location = new System.Drawing.Point(134, 12);
            this.btnSaleVehiculo.Name = "btnSaleVehiculo";
            this.btnSaleVehiculo.Size = new System.Drawing.Size(116, 33);
            this.btnSaleVehiculo.TabIndex = 1;
            this.btnSaleVehiculo.Text = "Salida de Vehiculo";
            this.btnSaleVehiculo.UseVisualStyleBackColor = true;
            this.btnSaleVehiculo.Click += new System.EventHandler(this.btnSaleVehiculo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 51);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(238, 33);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Estacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 99);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSaleVehiculo);
            this.Controls.Add(this.btnIngresaVehiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Estacionamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estacionamiento";
            this.Load += new System.EventHandler(this.Estacionamiento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresaVehiculo;
        private System.Windows.Forms.Button btnSaleVehiculo;
        private System.Windows.Forms.Button btnSalir;
    }
}

