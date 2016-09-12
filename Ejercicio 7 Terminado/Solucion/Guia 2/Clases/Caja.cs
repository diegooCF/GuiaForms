using System.Collections.Generic;

namespace Guia_2.Clases
{
    public class Caja
    {
        private int numCaja;
        private int sellUnits;
        private double totalVentas;
        private List<Articulo> items = new List<Articulo>();

        public int NumCaja { get; set; }
        public int SellUnits { get; set; }
        public double TotalVentas { get; set; }
        public List<Articulo> Items { get; set; }

        public Caja(int numCaja)
        {
            NumCaja = numCaja;
            SellUnits = 0;
            TotalVentas = 0;
        }

        public void addItem(Articulo item)
        {
            items.Add(item);
        }
    }
}
