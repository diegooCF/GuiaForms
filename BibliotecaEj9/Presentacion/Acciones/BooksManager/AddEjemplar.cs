using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Acciones.BooksManager
{
    public partial class AddEjemplar : Form
    {
        private void fillCombo(List<Entidades.Libro> listaLibros)
        {
            foreach (var item in listaLibros)
            {
                cboLibros.Items.Add(item.CodigoLibro);
            }
        }
        public AddEjemplar()
        {
            InitializeComponent();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEjemplar_Load(object sender, EventArgs e)
        {
            fillCombo(Program.ListaLibros);
        }

        private void cboLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = Program.ListaLibros.ElementAt(cboLibros.SelectedIndex).Titulo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && cboLibros.SelectedIndex != -1)
            {
                try
                {
                    //Añadimos el ejemplar al libro correspondiente
                    Program.ListaLibros.ElementAt(cboLibros.SelectedIndex).ListaEjemplares.Add(new Entidades.Ejemplar(Convert.ToInt32(txtCodigo.Text),  Program.ListaLibros.ElementAt(cboLibros.SelectedIndex)));
                    MessageBox.Show("El registro se ha realizado correctamente", "Registro Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigo.Clear();
                    txtCodigo.Focus();  
                }
                catch (Exception excep)
                {
                    MessageBox.Show("Se ha producido un error inexperado\nException: " + excep, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Revise que los datos fueron ingresados correctamente", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
