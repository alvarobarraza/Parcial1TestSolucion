using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialSolucion
{
    public class ProductoCompuesto : Producto
    {
        
        public ProductoCompuesto()
        {
            
        }

        public ProductoCompuesto(List<ProductoSimple> listaProductoCompuesto)
        {
            ListaProductoCompuesto = listaProductoCompuesto;
        }

        public ProductoCompuesto(string idProducto, string nombreProducto, decimal precioVenta, decimal costo, int stock) : base(idProducto, nombreProducto, precioVenta, costo, stock)
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            PrecioVenta = precioVenta;
            Costo = costo;
            Stock = stock;
        }

        public List<ProductoSimple> ListaProductoCompuesto { get; set; }


    }

   
}
