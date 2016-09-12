namespace Presentacion.Acciones
{
    partial class BorrarSocio
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
            this.gridSocios = new System.Windows.Forms.DataGridView();
            this.cboListaSocios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esMoroso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSocios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSocios
            // 
            this.gridSocios.AllowUserToAddRows = false;
            this.gridSocios.AllowUserToDeleteRows = false;
            this.gridSocios.AllowUserToOrderColumns = true;
            this.gridSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSocio,
            this.nameSocio,
            this.addressSocio,
            this.esMoroso});
            this.gridSocios.Location = new System.Drawing.Point(13, 13);
            this.gridSocios.Name = "gridSocios";
            this.gridSocios.ReadOnly = true;
            this.gridSocios.Size = new System.Drawing.Size(444, 150);
            this.gridSocios.TabIndex = 0;
            // 
            // cboListaSocios
            // 
            this.cboListaSocios.FormattingEnabled = true;
            this.cboListaSocios.Location = new System.Drawing.Point(13, 198);
            this.cboListaSocios.Name = "cboListaSocios";
            this.cboListaSocios.Size = new System.Drawing.Size(188, 21);
            this.cboListaSocios.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Socio a dar de baja:";
            // 
            // idSocio
            // 
            this.idSocio.HeaderText = "Codigo Socio";
            this.idSocio.Name = "idSocio";
            this.idSocio.ReadOnly = true;
            // 
            // nameSocio
            // 
            this.nameSocio.HeaderText = "Nombre";
            this.nameSocio.Name = "nameSocio";
            this.nameSocio.ReadOnly = true;
            // 
            // addressSocio
            // 
            this.addressSocio.HeaderText = "Direccion";
            this.addressSocio.Name = "addressSocio";
            this.addressSocio.ReadOnly = true;
            // 
            // esMoroso
            // 
            this.esMoroso.HeaderText = "Moroso?";
            this.esMoroso.Name = "esMoroso";
            this.esMoroso.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnAccept);
            this.groupBox1.Location = new System.Drawing.Point(249, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(110, 23);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(84, 23);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(110, 52);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BorrarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 288);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboListaSocios);
            this.Controls.Add(this.gridSocios);
            this.Name = "BorrarSocio";
            this.Text = "Dar de baja a Socio";
            this.Load += new System.EventHandler(this.BorrarSocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSocios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSocios;
        private System.Windows.Forms.ComboBox cboListaSocios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn esMoroso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAccept;
    }
}