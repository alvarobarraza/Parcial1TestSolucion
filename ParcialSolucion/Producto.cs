using System;

namespace ParcialSolucion
{
    public abstract class Producto
    {
        public Producto(string idProducto, string nombreProducto,  decimal costo)
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            Costo = costo;
    
        }

        public Producto()
        {

        }

        public string IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }
        public int Stock { get; set; }

    }
}
