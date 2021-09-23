using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialSolucion
{
    public class Venta
    {
        public Venta(string idVenta, decimal costo, decimal precio, Producto producto)
        {
            IdVenta = idVenta;
            Costo = costo;
            Precio = precio;
            Producto = producto;
        }

        public string IdVenta { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public Producto Producto { get; set; }



    }
    
}
