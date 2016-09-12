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
    public partial class BorrarSocio : Form
    {
        /// <summary>
        /// Carga la grilla con los datos de la lista de clientes registrados
        /// </summary>
        /// <param name="listaSocios">Lista que contiene los socios registrados</param>
        private void updateGridyList(List<Entidades.Socio> listaSocios)
        {
            //Limpiamos la grilla y lista por si queremos recargarlas
            gridSocios.Rows.Clear();
            cboListaSocios.Items.Clear();
            foreach (var item in listaSocios)
            {
                gridSocios.Rows.Add(new object[] { item.Codigo, item.Nombre, item.Direccion, Logica.Socio.getMorosoString(item) });
            }
            foreach (var item in listaSocios)
            {
                cboListaSocios.Items.Add(item.Codigo);
            }
        }
        public BorrarSocio()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            cboListaSocios.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BorrarSocio_Load(object sender, EventArgs e)
        {
            //Cuando carga el formulario, llenamos la lista de datos
            updateGridyList(Program.ListaSocios);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int selectedItem = cboListaSocios.SelectedIndex;
            try
            {
                Program.ListaSocios.RemoveAt(selectedItem);
                updateGridyList(Program.ListaSocios);
            }
            catch
            {
                MessageBox.Show("No hay ningun elemento seleccionado", "Error en baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
