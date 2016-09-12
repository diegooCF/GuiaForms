using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> list = new List<Persona>();
        private static int cont = 0;

        private void Clean()
        {
            txtName.Clear();
            txtLast.Clear();
            txtAge.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtName.Focus();
        }
        public FrmPrincipal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (cont <= 5)
            {
                try
                {
                    if (txtPhone.Text != "")
                    {
                        list.Add(new Persona(txtName.Text, txtLast.Text, Convert.ToInt32(txtAge.Text), txtPhone.Text, txtAddress.Text));
                    }
                    else
                    {
                        list.Add(new Persona(txtName.Text, txtLast.Text, Convert.ToInt32(txtAge.Text), txtAddress.Text));
                    }
                    cont++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Clean();
            }
            if (cont == 5)
            {
                txtName.Enabled = false;
                txtLast.Enabled = false;
                txtAge.Enabled = false;
                txtPhone.Enabled = false;
                txtAddress.Enabled = false;
                btnEnter.Enabled = false;
                btnList.Enabled = true;
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }   

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvRegistros.DataSource = list;
        }
    }
}
