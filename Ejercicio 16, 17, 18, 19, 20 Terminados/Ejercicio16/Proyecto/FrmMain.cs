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
    public partial class FrmMain : Form
    {
        private int nombreContador = 0;
        private List<string> nombres = new List<string>(4);
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            while(nombreContador < 4)
            {
                agregarNombre();
            }
            nombres.Sort();
            lsbNombresOrdenados.DataSource = nombres;
        }

        private void agregarNombre()
        {
            FrmAgregar form = new FrmAgregar();
            form.ShowDialog();
            if(form.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                nombres.Add(form.nombre);
                nombreContador++;
            }
            else
            {
                nombreContador = 4;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
