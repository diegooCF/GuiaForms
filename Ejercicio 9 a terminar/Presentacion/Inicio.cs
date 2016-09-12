using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Presentacion
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void btnNewSocio_Click(object sender, EventArgs e)
        {
            Acciones.AddSocio addSocio = new Acciones.AddSocio();
            addSocio.ShowDialog();
        }

        private void btnSuprSocio_Click(object sender, EventArgs e)
        {
            Acciones.BorrarSocio borrarSocio = new Acciones.BorrarSocio();
            borrarSocio.ShowDialog();
        }

        private void btnNewPrestamo_Click(object sender, EventArgs e)
        {
            Acciones.NewPrestamo newPrestamo = new Acciones.NewPrestamo();
            newPrestamo.ShowDialog();
        }

        private void btnBooksManager_Click(object sender, EventArgs e)
        {
            Acciones.BooksManager.BookManager bookManager = new Acciones.BooksManager.BookManager();
            bookManager.ShowDialog();
        }
    }
}
