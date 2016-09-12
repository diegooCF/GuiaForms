using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Acciones
{
    public partial class NewPrestamo : Form
    {
        private void fillCombos(List<Entidades.Libro> listaLibros,
                                List<Entidades.Socio> listaSocios)
        {
            foreach (var item in listaLibros)
            {
                cboLibro.Items.Add(item.Titulo);
            }
            foreach (var item in listaSocios)
            {
                cboSocio.Items.Add(item.Codigo);
            }
        }
        public NewPrestamo()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.cboSocio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewPrestamo_Load(object sender, EventArgs e)
        {
            fillCombos(Program.ListaLibros, Program.ListaSocios);
        }

        private void cboSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblName.Text = Program.ListaSocios.ElementAt(cboSocio.SelectedIndex).Nombre;
            lblMoroso.Text = Logica.Socio.getMorosoString(Program.ListaSocios.ElementAt(cboSocio.SelectedIndex));
            numLibrosPrestados.Value = Program.ListaSocios.ElementAt(cboSocio.SelectedIndex).CantidadLibros;
            if(numLibrosPrestados.Value >= 2)
            {
                btnAccept.Enabled = false;
            }
        }
    }
}
