using System;
using System.Windows.Forms;

namespace Ejercicio13
{
    public partial class Form1 : Form
    {
        //Cuenta la cantidad de numeros ingresados. Max: 20
        private int numCounter = 0;
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (numCounter < 20)
            {
                using (InputDialog form = new InputDialog())
                {
                    var formResult = form.ShowDialog();

                    bool ingresoCero = form.ingresoCero;
                    bool usuarioCancelo = form.usuarioCancelo;
                    if (formResult == DialogResult.OK)
                    {
                        if (ingresoCero)
                        {
                            btnIniciar.Enabled = false;
                            break;
                        }
                        if (!usuarioCancelo)
                            numCounter++;
                    }
                }
            }
            btnIniciar.Enabled = false;
            this.Text = numCounter.ToString();
        }

    }
}
