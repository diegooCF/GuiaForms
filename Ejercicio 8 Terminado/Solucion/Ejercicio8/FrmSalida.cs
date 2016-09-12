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
    public partial class FrmSalida : Form
    {
        //Plaza seleccionada
        int numPiso = -1;
        int numPlaza = -1;

        public FrmSalida()
        {
            InitializeComponent();
        }

        private void FrmSalida_Load(object sender, EventArgs e)
        {
            foreach (var piso in Componentes.getPisos())
            {
                foreach (var plaza in piso.Plazas)
                {
                    if(plaza.Disponible == false)
                    cboPiso.Items.Add(plaza.Auto.Patente);
                }
            }   
        }

        private void cboPiso_SelectedIndexChanged(object sender, EventArgs e)
        {
            Componentes.getCoordenadasDePlaza(cboPiso.SelectedItem.ToString(), out numPiso, out numPlaza);
            lblPiso.Text = numPiso.ToString();
            lblPlaza.Text = numPlaza.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Componentes.getPisos().ElementAt(numPiso-1).Plazas.ElementAt(numPlaza-1).saleAuto();
                MessageBox.Show("Salida correcta", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
