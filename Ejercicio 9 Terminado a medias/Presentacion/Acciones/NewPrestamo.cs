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
            if (numLibrosPrestados.Value >= 2)
                btnAccept.Enabled = false;
            else
                btnAccept.Enabled = true;
        }

        private void cboLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboEjemplar.Items.Clear();
            foreach (var libro in Program.ListaLibros.ElementAt(cboLibro.SelectedIndex).ListaEjemplares)
            {
                if(libro.estado.Equals(Entidades.Ejemplar.Estado.Libre))
                cboEjemplar.Items.Add(libro.CodigoEjemplar);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Entidades.Prestamo prestamo = new Entidades.Prestamo();
            prestamo.Socio = Program.ListaSocios.ElementAt(cboSocio.SelectedIndex);
            prestamo.Ejemplar = Program.ListaLibros.ElementAt(cboLibro.SelectedIndex).ListaEjemplares.ElementAt(cboEjemplar.SelectedIndex);
            prestamo.FechaPrestamo = clndrPrestamo.Value;
            prestamo.FechaDevolucion = clndrDevo.Value;

            Program.ListaSocios.ElementAt(cboSocio.SelectedIndex).CantidadLibros++;
            //TODO No funciona bien el ejemplar seleccionado
            Program.ListaLibros.ElementAt(cboLibro.SelectedIndex).ListaEjemplares.ElementAt(Convert.ToInt32(cboEjemplar.SelectedItem.ToString())).alquilado();
            Close();
        }
    }
}
