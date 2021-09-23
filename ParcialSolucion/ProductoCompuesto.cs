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

        public ProductoCompuesto(string idProducto, string nombreProducto, decimal precio, decimal costo, int stock) : base(idProducto, nombreProducto, precio, costo, stock)
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            Precio = precio;
            Costo = costo;
            Stock = stock;
        }

        public List<ProductoSimple> ListaProductoCompuesto { get; set; }


    }

   
}
