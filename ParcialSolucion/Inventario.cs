using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialSolucion
{
    public class Inventario
    {
        public Inventario(Producto producto, Venta venta)
        {
            Producto = producto;
            Venta = venta;
        }

        public Producto Producto { get;  set; }
        public Venta Venta { get;  set; }

    }
    
}
