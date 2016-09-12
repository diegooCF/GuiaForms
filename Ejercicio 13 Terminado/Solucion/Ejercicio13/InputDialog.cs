using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio13
{
    public partial class InputDialog : Form
    {
        public bool ingresoCero { get; set; }
        //Si el usuario cierra el formulario sin ingresar un numero no suma en +1 al contador de max 20
        public bool usuarioCancelo { get; set; }
        public InputDialog()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int num = 0;
            bool esPar = true;
            try
            {
                num = Convert.ToInt32(txtNumber.Text);
                if (num != 0)
                {
                    ingresoCero = false;
                    esPar = Comprobaciones.checkNum(num);
                    if (esPar == true)
                        Pares.addToPares(num);
                    else
                        Impares.addToImpares(num);
                }
                else
                {
                    MessageBox.Show("El numero ingresado es 0. Ingreso Finalizado", "Ingreso terminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ingresoCero = true;                   
                }
                DialogResult = DialogResult.OK;
            }
            catch(Exception excepcion)
            {
                MessageBox.Show("ERROR: " + excepcion.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
