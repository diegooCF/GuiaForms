namespace Guia_2.Clases
{
    public class Articulo
    {
        private int codigo;
        private double precio;
        private int stock;

        public int Codigo { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        public Articulo(int codigo, double precio, int stock)
        {
            Codigo = codigo;
            Precio = precio;
            Stock = stock;
        }
    }
}
