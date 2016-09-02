using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas
{
    public partial class Form1 : Form
    {
        Persona[] persona = new Persona[5];
        private static int cont = 0;

        public void Clean()
        {
            txtName.Clear();
            txtLast.Clear();
            txtAge.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (cont != 4)
            {
                if (txtPhone.Text != "")
                {
                    persona[cont] = new Persona(txtName.Text, txtLast.Text, Convert.ToInt32(txtAge.Text), txtPhone.Text, txtAddress.Text);
                }
                else
                {
                    persona[cont] = new Persona(txtName.Text, txtLast.Text, Convert.ToInt32(txtAge.Text), txtAddress.Text);
                }
                cont++;
                Clean();
            }
            else
            {
                btnEnter.Enabled = false;
            }
        }
    }
}
