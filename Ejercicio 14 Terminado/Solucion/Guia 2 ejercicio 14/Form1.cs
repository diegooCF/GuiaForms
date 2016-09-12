using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Guia_2_ejercicio_13
{
    public partial class Form1 : Form
    {
        List<Corredor> corredores = new List<Corredor>(10);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                string segundos;
                segundos = Interaction.InputBox("Ingrese tiempo de corredor " + (i+1) + " en segundos: ","Ingreso de tiempo");               
                corredores.Add(new Corredor(segundos));
            }
            corredores = corredores.OrderBy(o => o.Segundos).ToList();
            dgvTiempos.DataSource = corredores;
            txtPrimer.Text = dgvTiempos.Rows[0].Cells["Id"].Value.ToString();
            txtTercer.Text = dgvTiempos.Rows[2].Cells["Id"].Value.ToString();
            txtQuinto.Text = dgvTiempos.Rows[4].Cells["Id"].Value.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
