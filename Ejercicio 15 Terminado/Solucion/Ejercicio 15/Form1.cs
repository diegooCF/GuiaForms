using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_15
{
    public partial class btnExit : Form
    {
        public btnExit()
        {
            InitializeComponent();
        }

        private void fillAndSort(List<double> list)
        {
            list.Sort();
            foreach (var item in list)
            {
                lvOrden.Items.Add(new ListViewItem(item.ToString()));
            }
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            List<double> numbers = new List<double>(5);
            try
            {
                numbers.Add(Convert.ToDouble(txtNum1.Text));
                numbers.Add(Convert.ToDouble(txtNum2.Text));
                numbers.Add(Convert.ToDouble(txtNum3.Text));
                numbers.Add(Convert.ToDouble(txtNum4.Text));
                numbers.Add(Convert.ToDouble(txtNum5.Text));
                fillAndSort(numbers);
                btnAccept.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
