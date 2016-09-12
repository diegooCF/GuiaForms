using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio16
{
    public partial class FrmAgregar : Form
    {
        public string nombre { get; set; }
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
            nombre = txtNombre.Text;
        }
    }
}
