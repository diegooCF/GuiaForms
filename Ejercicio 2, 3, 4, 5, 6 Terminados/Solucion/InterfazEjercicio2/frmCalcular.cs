using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace InterfazEjercicio2
{
    public partial class frmCalcular : Form
    {
        Ejercicio2.Rectangulo rectangulo = null;
        Ejercicio2.Triangulo triangulo = null;
        Ejercicio2.Circunferencia circunferencia = null;
        public frmCalcular() { }
        public frmCalcular(Ejercicio2.Rectangulo rectangulo)
        {
            InitializeComponent();
            this.rectangulo = rectangulo;
        }
        public frmCalcular(Ejercicio2.Circunferencia circunferencia)
        {
            InitializeComponent();
            this.circunferencia = circunferencia;
        }
        public frmCalcular(Ejercicio2.Triangulo triangulo)
        {
            InitializeComponent();
            this.triangulo = triangulo;
        }

        private void frmCalcular_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            try
            {
                if (rectangulo != null)
                    MessageBox.Show("Area: " + rectangulo.getArea().ToString(), "Area de rectangulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (circunferencia != null)
                    MessageBox.Show("Area: " + circunferencia.getArea().ToString(), "Area de circunferencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (triangulo != null)
                {
                    int ladoBase = Convert.ToInt32(Interaction.InputBox("Ingrese valor lado base: ", "Calculo area de triangulo", "Value"));
                    int altura = Convert.ToInt32(Interaction.InputBox("Ingrese valor altura: ", "Calculo area de triangulo", "Value"));
                    triangulo = new Ejercicio2.Triangulo(ladoBase, altura);
                    MessageBox.Show("Area: " + triangulo.getArea().ToString(), "Area de triangulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            try
            {
                if (rectangulo != null)
                    MessageBox.Show("Perimetro: " + rectangulo.getPerimetro().ToString(), "Perimetro de rectangulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (circunferencia != null)
                    MessageBox.Show("Perimetro: " + circunferencia.getPerimetro().ToString(), "Perimetro de circunferencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (triangulo != null)
                {
                    int lado1 = Convert.ToInt32(Interaction.InputBox("Ingrese valor lado 1: ", "Calculo perimetro de triangulo", "Value"));
                    int lado2 = Convert.ToInt32(Interaction.InputBox("Ingrese valor lado 2: ", "Calculo perimetro de triangulo", "Value"));
                    int lado3 = Convert.ToInt32(Interaction.InputBox("Ingrese valor lado 3: ", "Calculo perimetro de triangulo", "Value"));
                    triangulo = new Ejercicio2.Triangulo(lado1, lado2, lado3);
                    if (triangulo.esTriangulo())
                        MessageBox.Show("La figura ingresada es un triangulo valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        MessageBox.Show("La figura ingresada NO es un triangulo valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Perimetro: " + triangulo.getPerimetro().ToString(), "Perimetro de triangulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
