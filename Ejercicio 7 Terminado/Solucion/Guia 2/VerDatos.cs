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
    public partial class VerDatos : Form
    {
        private string cajaActiva;
        public string CajaActiva { get; set; }

        public VerDatos()
        {
            InitializeComponent();
        }

        private void VerDatos_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            lblCajaActiva.Text = "N" + CajaActiva;
            lblTotalCash.Text = "$ " + Convert.ToString(Inicio.cajas[Convert.ToInt32(CajaActiva)-1].TotalVentas);
            lblTotItems.Text = Convert.ToString(Inicio.cajas[Convert.ToInt32(CajaActiva) - 1].SellUnits);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
