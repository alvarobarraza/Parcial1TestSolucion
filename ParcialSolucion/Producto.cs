using System;

namespace ParcialSolucion
{
    public class Producto
    {
        public Producto(string idProducto, string nombreProducto, decimal precioVenta, decimal costoEmpresa, int stock)
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            CostoEmpresa = costoEmpresa;
            PrecioVenta = precioVenta;
            Stock = stock;
    
        }

        public Producto()
        {

        }

        public string IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal CostoEmpresa { get; set; }
        public int Stock { get; set; }


    }
}
