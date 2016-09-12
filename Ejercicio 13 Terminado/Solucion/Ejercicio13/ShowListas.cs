using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio13
{
    public partial class ShowListas : Form
    {
        public List<int> Pares { get; set; }
        public List<int> Impares { get; set; }

        private void bindLists()
        {
            listBox1.DataSource = Pares;
            listBox2.DataSource = Impares;
        }
        public ShowListas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowListas_Load(object sender, EventArgs e)
        {
            bindLists();
        }
    }
}
