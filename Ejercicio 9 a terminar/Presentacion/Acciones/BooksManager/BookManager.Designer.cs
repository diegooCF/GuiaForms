namespace Presentacion.Acciones.BooksManager
{
    partial class BookManager
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
            this.btnAddLibro = new System.Windows.Forms.Button();
            this.btnAddEjemplar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnVerLibros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddLibro
            // 
            this.btnAddLibro.Location = new System.Drawing.Point(12, 12);
            this.btnAddLibro.Name = "btnAddLibro";
            this.btnAddLibro.Size = new System.Drawing.Size(105, 34);
            this.btnAddLibro.TabIndex = 0;
            this.btnAddLibro.Text = "Añadir Libro";
            this.btnAddLibro.UseVisualStyleBackColor = true;
            this.btnAddLibro.Click += new System.EventHandler(this.btnAddLibro_Click);
            // 
            // btnAddEjemplar
            // 
            this.btnAddEjemplar.Location = new System.Drawing.Point(123, 12);
            this.btnAddEjemplar.Name = "btnAddEjemplar";
            this.btnAddEjemplar.Size = new System.Drawing.Size(105, 34);
            this.btnAddEjemplar.TabIndex = 1;
            this.btnAddEjemplar.Text = "Añadir Ejemplar";
            this.btnAddEjemplar.UseVisualStyleBackColor = true;
            this.btnAddEjemplar.Click += new System.EventHandler(this.btnAddEjemplar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 93);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(216, 34);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnVerLibros
            // 
            this.btnVerLibros.Location = new System.Drawing.Point(12, 52);
            this.btnVerLibros.Name = "btnVerLibros";
            this.btnVerLibros.Size = new System.Drawing.Size(216, 34);
            this.btnVerLibros.TabIndex = 3;
            this.btnVerLibros.Text = "Ver Libros";
            this.btnVerLibros.UseVisualStyleBackColor = true;
            // 
            // BookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 139);
            this.Controls.Add(this.btnVerLibros);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAddEjemplar);
            this.Controls.Add(this.btnAddLibro);
            this.Name = "BookManager";
            this.Text = "Gestor de Libros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddLibro;
        private System.Windows.Forms.Button btnAddEjemplar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnVerLibros;
    }
}