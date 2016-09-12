using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace InterfazEjercicio2
{
    public partial class frmDesplegar : Form
    {
        public frmDesplegar()
        {
            InitializeComponent();
        }
        
        private void Calcular()
        {
            frmCalcular form = new frmCalcular();
            if (cboFiguras.SelectedItem.ToString() == "Circunferencia")
            {
                try
                {
                    int radio = Convert.ToInt32(Interaction.InputBox("Ingrese radio: ", "Calculo de circunferencia", "Radio"));
                    form = new frmCalcular(new Ejercicio2.Circunferencia(radio));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
            else if (cboFiguras.SelectedItem.ToString() == "Rectangulo")
            {
                try
                {
                    int lado1 = Convert.ToInt32(Interaction.InputBox("Ingrese valor lado 1: ", "Calculo de rectangulo", "Value"));
                    int lado2 = Convert.ToInt32(Interaction.InputBox("Ingrese valor lado 2: ", "Calculo de rectangulo", "Value"));
                    Ejercicio2.Rectangulo rectangulo = new Ejercicio2.Rectangulo(lado1, lado2);
                    if (rectangulo.esCuadrado())
                        MessageBox.Show("La figura ingresada es un cuadrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("La figura ingresada es un rectangulo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form = new frmCalcular(rectangulo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (cboFiguras.SelectedItem.ToString() == "Triangulo")
            {
                form = new frmCalcular(new Ejercicio2.Triangulo());
            }
            form.ShowDialog();
        }

        private void frmDesplegar_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            cboFiguras.SelectedIndex = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }
    }
}
