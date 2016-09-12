using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejericicio19
{
    public partial class FrmMain : Form
    {
        private List<int> listNumeros = new List<int>();
        private static int itemCounter = 0;
        public List<int> getList()
        {
            return listNumeros;
        }
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.lsbNumeros.DataSource = this.getList();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (itemCounter == 3)
                {
                    itemCounter = 0;
                    listNumeros.RemoveAt(listNumeros.Count - 1);
                }
                try
                {
                    listNumeros.Add(Convert.ToInt32(txtNumero.Text));
                    itemCounter++;
                }
                catch
                {
                    throw new Exception("El numero ingresado no es valido");
                }
                lsbNumeros.DataSource = null;
                lsbNumeros.DataSource = listNumeros;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtNumero.Clear();
                txtNumero.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
