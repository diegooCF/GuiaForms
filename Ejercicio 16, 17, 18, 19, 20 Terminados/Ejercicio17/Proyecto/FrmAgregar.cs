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
    public partial class FrmAgregar : Form
    {
        public int Numero { get; set; }
        public FrmAgregar()
        {
            InitializeComponent();
        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Numero = Convert.ToInt32(txtNombre.Text);
            }
            catch 
            {
                MessageBox.Show("El numero ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
