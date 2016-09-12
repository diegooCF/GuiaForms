using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazEjercicio2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Desplegar()
        {
            frmDesplegar form = new frmDesplegar();
            form.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnDesplegar_Click(object sender, EventArgs e)
        {
            Desplegar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEquilatero_Click(object sender, EventArgs e)
        {
            try
            {
                int lado = Convert.ToInt32(Interaction.InputBox("Ingrese valor lado 1: ", "Calculo perimetro de triangulo", "Value"));
                Ejercicio2.Equilatero triangulo = new Ejercicio2.Equilatero(lado);
                MessageBox.Show("Area redondeada: " + Math.Round(triangulo.EquilateroArea) + " - Perimetro: " + triangulo.EquilateroPerimetro, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
