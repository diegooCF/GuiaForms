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
    public partial class AddLibro : Form
    {
        public AddLibro()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void AddLibro_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text != "" && txtTitulo.Text != "" && txtAutor.Text != "")
            {
                try
                {
                    Program.ListaLibros.Add(new Entidades.Libro(Convert.ToInt32(txtCodigo.Text), txtTitulo.Text, txtAutor.Text));
                    MessageBox.Show("El registro se ha realizado correctamente", "Registro Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigo.Clear();
                    txtTitulo.Clear();
                    txtAutor.Clear();
                    txtCodigo.Focus();
                }
                catch(Exception excep)
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
