using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class Estacionamiento : Form
    {
        private List<Piso> Pisos = Componentes.getPisos();
        public Estacionamiento()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnIngresaVehiculo_Click(object sender, EventArgs e)
        {
            FrmIngreso form = new FrmIngreso();
            form.ShowDialog();
        }

        private void Estacionamiento_Load(object sender, EventArgs e)
        {
            Componentes.Initialize();
        }

        private void btnSaleVehiculo_Click(object sender, EventArgs e)
        {
            FrmSalida form = new FrmSalida();
            form.ShowDialog();
        }
    }
}
