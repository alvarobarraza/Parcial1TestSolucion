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

        public ProductoCompuesto(string idProducto, string nombreProducto, decimal precioVenta, decimal costoEmpresa, int stock) : base(idProducto, nombreProducto, precioVenta, costoEmpresa, stock)
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            PrecioVenta = precioVenta;
            CostoEmpresa = costoEmpresa;
            Stock = stock;
        }

        public List<ProductoSimple> ListaProductoCompuesto { get; set; }


    }

   
}
