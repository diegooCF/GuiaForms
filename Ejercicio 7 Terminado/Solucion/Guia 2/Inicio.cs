using System;
using System.Windows.Forms;

namespace Guia_2
{
    public partial class Inicio : Form
    {
        //Creacion de formularios pertenecientes al formulario principal
        private AddItem addArticulo;
        private VerDatos verDatos;
        private VerStock verStock;

        public static Clases.Caja[] cajas = new Clases.Caja[40]; //REVISAR ENCAPSULAMIENTO
        public static Clases.Articulo[] articulos = new Clases.Articulo[10];
        public Inicio()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Realiza una carga por default de productos
        /// </summary>
        private void loadProductos()
        {
            articulos[0] = new Clases.Articulo(1, 20.00, 40);
            articulos[1] = new Clases.Articulo(2, 15.00, 20);
            articulos[2] = new Clases.Articulo(3, 35.50, 60);
            articulos[3] = new Clases.Articulo(4, 5.00, 100);
            articulos[4] = new Clases.Articulo(5, 25.00, 45);
            articulos[5] = new Clases.Articulo(6, 95.00, 50);
            articulos[6] = new Clases.Articulo(7, 110.00, 8);
            articulos[7] = new Clases.Articulo(8, 78.25, 65);
            articulos[8] = new Clases.Articulo(9, 2.50, 20);
            articulos[9] = new Clases.Articulo(10, 3.00, 250);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //En la carga del formulario se realiza la carga de cajas al ComboBox
            for (int i = 0; i < 40; i++)
            {
                cajas[i] = new Clases.Caja(i + 1);
                cboNumCaja.Items.Add(cajas[i].NumCaja);
            }
            //Estilo del ComboBox y Formulario
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            cboNumCaja.DropDownStyle = ComboBoxStyle.DropDownList;
            loadProductos();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            addArticulo = new AddItem();
            try
            {
                //Se pasa al formulario de registro de productos el numero de caja seleccionada
                addArticulo.CajaActiva = cboNumCaja.SelectedItem.ToString();
                addArticulo.ShowDialog();
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado un numero de caja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            verDatos = new VerDatos();
            try
            {
                //Se pasa al formulario de muestra de datos el numero de caja seleccionada
                verDatos.CajaActiva = cboNumCaja.SelectedItem.ToString();
                verDatos.ShowDialog();
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado un numero de caja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerStock_Click(object sender, EventArgs e)
        {
            verStock = new VerStock();
            verStock.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?", "Esta saliendo del programa",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
