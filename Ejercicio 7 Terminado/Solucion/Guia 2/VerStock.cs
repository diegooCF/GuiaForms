using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_2
{
    public partial class VerStock : Form
    {

        public VerStock()
        {
            InitializeComponent();
        }

        private void VerStock_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            for (int i = 0; i < Inicio.articulos.Length; i++)
            {
                dataStock.Rows.Add(new object[] { Inicio.articulos[i].Codigo, Inicio.articulos[i].Stock });
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
