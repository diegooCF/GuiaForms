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

    public partial class AddSocio : Form
    {
        //Variable que asigna autoincrementalmente el numero de socio
        static private int socioCount = Program.ListaSocios.Count + 1;

        public AddSocio()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void AddSocio_Load(object sender, EventArgs e)
        {
            lblCodigoNext.Text = "N" + (socioCount + 1).ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //Agregamos un socio a la lista en la clase Program
            if (txtName.Text != "" && txtAddress.Text != "")
            {
                Logica.Socio.addSocio(Program.ListaSocios, new Entidades.Socio(socioCount + 1, txtName.Text, txtAddress.Text));
                socioCount++;
                MessageBox.Show("Socio codigo: N" + socioCount + " registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Registro incorrecto, corrobore datos ingresados", "Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
