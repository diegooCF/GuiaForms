using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio17
{
    public partial class FrmMain : Form
    {
        private int numContador = 0;
        private List<int> numeros = new List<int>(6);
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            while (numContador < 6)
            {
                agregarNumero();
            }
            numeros.Sort();
            lsbNumerosOrdenados.DataSource = numeros;
        }
        
        private void agregarNumero()
        {
            FrmAgregar form = new FrmAgregar();
            form.ShowDialog();
            if (form.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                numeros.Add(form.Numero);
                numContador++;
            }
            else
            {
                numContador = 6;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
