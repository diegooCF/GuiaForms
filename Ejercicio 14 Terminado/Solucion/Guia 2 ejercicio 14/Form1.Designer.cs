namespace Guia_2_ejercicio_13
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTiempos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrimer = new System.Windows.Forms.TextBox();
            this.txtTercer = new System.Windows.Forms.TextBox();
            this.txtQuinto = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiempos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiempo de corredores en segundos:";
            // 
            // dgvTiempos
            // 
            this.dgvTiempos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiempos.Location = new System.Drawing.Point(12, 25);
            this.dgvTiempos.Name = "dgvTiempos";
            this.dgvTiempos.Size = new System.Drawing.Size(264, 175);
            this.dgvTiempos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Primer puesto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tercer puesto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quinto puesto:";
            // 
            // txtPrimer
            // 
            this.txtPrimer.Enabled = false;
            this.txtPrimer.Location = new System.Drawing.Point(94, 206);
            this.txtPrimer.Name = "txtPrimer";
            this.txtPrimer.Size = new System.Drawing.Size(100, 20);
            this.txtPrimer.TabIndex = 4;
            // 
            // txtTercer
            // 
            this.txtTercer.Enabled = false;
            this.txtTercer.Location = new System.Drawing.Point(94, 232);
            this.txtTercer.Name = "txtTercer";
            this.txtTercer.Size = new System.Drawing.Size(100, 20);
            this.txtTercer.TabIndex = 4;
            // 
            // txtQuinto
            // 
            this.txtQuinto.Enabled = false;
            this.txtQuinto.Location = new System.Drawing.Point(94, 258);
            this.txtQuinto.Name = "txtQuinto";
            this.txtQuinto.Size = new System.Drawing.Size(100, 20);
            this.txtQuinto.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(200, 206);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(76, 72);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 286);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtQuinto);
            this.Controls.Add(this.txtTercer);
            this.Controls.Add(this.txtPrimer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTiempos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Posiciones corredores";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiempos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTiempos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrimer;
        private System.Windows.Forms.TextBox txtTercer;
        private System.Windows.Forms.TextBox txtQuinto;
        private System.Windows.Forms.Button btnOk;
    }
}

