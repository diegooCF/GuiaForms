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
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto(textBox1.Text);
            int plazaOcupada;
            foreach (var item in Componentes.getPisos())
            {
                if(item.hayLugar(auto, out plazaOcupada))
                {
                    MessageBox.Show("Auto aparcado en piso " + item.Codigo + ", plaza " + plazaOcupada, "Ingreso correcto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            MessageBox.Show("No hay mas lugar en el estacionamiento", "Plazas llenas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
