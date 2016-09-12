namespace Guia_2
{
    partial class VerStock
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
            this.dataStock = new System.Windows.Forms.DataGridView();
            this.itemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dataStock
            // 
            this.dataStock.AllowUserToAddRows = false;
            this.dataStock.AllowUserToDeleteRows = false;
            this.dataStock.AllowUserToOrderColumns = true;
            this.dataStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCode,
            this.itemStock});
            this.dataStock.Location = new System.Drawing.Point(13, 13);
            this.dataStock.Name = "dataStock";
            this.dataStock.ReadOnly = true;
            this.dataStock.Size = new System.Drawing.Size(244, 189);
            this.dataStock.TabIndex = 0;
            // 
            // itemCode
            // 
            this.itemCode.HeaderText = "Codigo Articulo";
            this.itemCode.Name = "itemCode";
            this.itemCode.ReadOnly = true;
            // 
            // itemStock
            // 
            this.itemStock.HeaderText = "Stock Disponible";
            this.itemStock.Name = "itemStock";
            this.itemStock.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(157, 208);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 43);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // VerStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 263);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataStock);
            this.Name = "VerStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.VerStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemStock;
        private System.Windows.Forms.Button btnBack;
    }
}