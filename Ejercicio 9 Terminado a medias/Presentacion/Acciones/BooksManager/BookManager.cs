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
    public partial class BookManager : Form
    {
        public BookManager()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddLibro_Click(object sender, EventArgs e)
        {
            AddLibro addLibro = new AddLibro();
            addLibro.ShowDialog();
        }

        private void btnAddEjemplar_Click(object sender, EventArgs e)
        {
            AddEjemplar addEjemplar = new AddEjemplar();
            addEjemplar.ShowDialog();
        }
    }
}
