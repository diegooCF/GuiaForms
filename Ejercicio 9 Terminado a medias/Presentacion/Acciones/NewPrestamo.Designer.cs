namespace Presentacion.Acciones
{
    partial class NewPrestamo
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
            this.clndrPrestamo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clndrDevo = new System.Windows.Forms.DateTimePicker();
            this.cboLibro = new System.Windows.Forms.ComboBox();
            this.cboEjemplar = new System.Windows.Forms.ComboBox();
            this.cboSocio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVerMas = new System.Windows.Forms.Button();
            this.numLibrosPrestados = new System.Windows.Forms.NumericUpDown();
            this.lblMoroso = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLibrosPrestados)).BeginInit();
            this.SuspendLayout();
            // 
            // clndrPrestamo
            // 
            this.clndrPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.clndrPrestamo.Location = new System.Drawing.Point(131, 249);
            this.clndrPrestamo.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.clndrPrestamo.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.clndrPrestamo.Name = "clndrPrestamo";
            this.clndrPrestamo.Size = new System.Drawing.Size(106, 20);
            this.clndrPrestamo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de prestamo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de devolución:";
            // 
            // clndrDevo
            // 
            this.clndrDevo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.clndrDevo.Location = new System.Drawing.Point(131, 276);
            this.clndrDevo.Name = "clndrDevo";
            this.clndrDevo.Size = new System.Drawing.Size(107, 20);
            this.clndrDevo.TabIndex = 2;
            // 
            // cboLibro
            // 
            this.cboLibro.FormattingEnabled = true;
            this.cboLibro.Location = new System.Drawing.Point(123, 12);
            this.cboLibro.Name = "cboLibro";
            this.cboLibro.Size = new System.Drawing.Size(150, 21);
            this.cboLibro.TabIndex = 3;
            this.cboLibro.SelectedIndexChanged += new System.EventHandler(this.cboLibro_SelectedIndexChanged);
            // 
            // cboEjemplar
            // 
            this.cboEjemplar.FormattingEnabled = true;
            this.cboEjemplar.Location = new System.Drawing.Point(123, 39);
            this.cboEjemplar.Name = "cboEjemplar";
            this.cboEjemplar.Size = new System.Drawing.Size(150, 21);
            this.cboEjemplar.TabIndex = 4;
            // 
            // cboSocio
            // 
            this.cboSocio.FormattingEnabled = true;
            this.cboSocio.Location = new System.Drawing.Point(123, 74);
            this.cboSocio.Name = "cboSocio";
            this.cboSocio.Size = new System.Drawing.Size(150, 21);
            this.cboSocio.TabIndex = 5;
            this.cboSocio.SelectedIndexChanged += new System.EventHandler(this.cboSocio_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccione un libro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seleccione ejemplar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Seleccione socio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Libros prestados:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Moroso:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(75, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(16, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerMas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numLibrosPrestados);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblMoroso);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(18, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 116);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos socio seleccionado";
            // 
            // btnVerMas
            // 
            this.btnVerMas.Location = new System.Drawing.Point(165, 80);
            this.btnVerMas.Name = "btnVerMas";
            this.btnVerMas.Size = new System.Drawing.Size(72, 20);
            this.btnVerMas.TabIndex = 13;
            this.btnVerMas.Text = "Ver mas";
            this.btnVerMas.UseVisualStyleBackColor = true;
            // 
            // numLibrosPrestados
            // 
            this.numLibrosPrestados.Enabled = false;
            this.numLibrosPrestados.Location = new System.Drawing.Point(115, 80);
            this.numLibrosPrestados.Name = "numLibrosPrestados";
            this.numLibrosPrestados.Size = new System.Drawing.Size(34, 20);
            this.numLibrosPrestados.TabIndex = 12;
            // 
            // lblMoroso
            // 
            this.lblMoroso.AutoSize = true;
            this.lblMoroso.Location = new System.Drawing.Point(72, 55);
            this.lblMoroso.Name = "lblMoroso";
            this.lblMoroso.Size = new System.Drawing.Size(16, 13);
            this.lblMoroso.TabIndex = 11;
            this.lblMoroso.Text = "...";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(174, 319);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(109, 35);
            this.btnAccept.TabIndex = 14;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 35);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 366);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboSocio);
            this.Controls.Add(this.cboEjemplar);
            this.Controls.Add(this.cboLibro);
            this.Controls.Add(this.clndrDevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clndrPrestamo);
            this.Name = "NewPrestamo";
            this.Text = "Nuevo prestamo";
            this.Load += new System.EventHandler(this.NewPrestamo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLibrosPrestados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker clndrPrestamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker clndrDevo;
        private System.Windows.Forms.ComboBox cboLibro;
        private System.Windows.Forms.ComboBox cboEjemplar;
        private System.Windows.Forms.ComboBox cboSocio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVerMas;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMoroso;
        private System.Windows.Forms.NumericUpDown numLibrosPrestados;
    }
}