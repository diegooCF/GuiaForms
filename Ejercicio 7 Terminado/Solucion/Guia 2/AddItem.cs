using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_2
{
    public partial class AddItem : Form
    {
        //Recibe de Form1 (Inicio) la caja activa seleccionada
        private string cajaActiva;
        public string CajaActiva { get; set; }

        private Clases.Caja cajaActual;
        public Clases.Caja CajaActual { get; set; }

        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            lblCajaActiva.Text = "N" + CajaActiva;
            //Se realiza la carga de articulos al ComboBox
            for (int i = 0; i < Inicio.articulos.Length; i++)
            {
                cboArticulos.Items.Add(Inicio.articulos[i].Codigo);
            }
            //Estilo del ComboBox y Formulario
            cboArticulos.DropDownStyle = ComboBoxStyle.DropDownList;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        /// <summary>
        /// Este metodo se encarga de actualizar las etiquetas con los datos de los articulos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            double precio = Inicio.articulos[Convert.ToInt32(cboArticulos.SelectedItem.ToString())-1].Precio;
            int stock = Inicio.articulos[Convert.ToInt32(cboArticulos.SelectedItem.ToString())-1].Stock;
            lblPrecio.Text = precio.ToString();
            lblStock.Text = stock.ToString();
            btnInsert.Enabled = true;
        }

        /// <summary>
        /// Este metodo se encarga de intentar realizar las conversiones, descontar el stock y mostrar al usuario MessageBox con informacion
        /// relevante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            int cantidad;
            try
            {
                cantidad = Convert.ToInt32(txtCantidad.Text);
                //Se chequea que la cantidad ingresada sea valida y menor o igual a stock disponible
                if (cantidad <= Inicio.articulos[Convert.ToInt32(cboArticulos.SelectedItem.ToString()) - 1].Stock)
                {

                    if (cboArticulos.SelectedItem != null && cantidad > 0)
                    {
                        Inicio.articulos[Convert.ToInt32(cboArticulos.SelectedItem.ToString()) - 1].Stock -= cantidad;
                        lblStock.Text = Inicio.articulos[Convert.ToInt32(cboArticulos.SelectedItem.ToString()) - 1].Stock.ToString();
                        Inicio.cajas[Convert.ToInt32(CajaActiva) - 1].SellUnits += cantidad; //PREGUNTAR
                        Inicio.cajas[Convert.ToInt32(CajaActiva) - 1].TotalVentas += (Inicio.articulos[Convert.ToInt32(cboArticulos.SelectedItem.ToString()) - 1].Precio) * cantidad;
                        MessageBox.Show("Producto registrado correctamente", "Ingreso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Se ha producido un error, revise los datos ingresados", "Ingreso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Stock insuficiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Se ha producido un error, revise los datos ingresados", "Error encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
