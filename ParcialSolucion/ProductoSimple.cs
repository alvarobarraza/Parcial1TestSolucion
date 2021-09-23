using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialSolucion
{
    public class ProductoSimple : Producto
    {
        public ProductoSimple()
        {

        }

        public ProductoSimple(string idProducto, string nombreProducto, decimal precioVenta, decimal costo, int stock) : base(idProducto, nombreProducto, precioVenta, costo, stock)
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            PrecioVenta = precioVenta;
            Costo = costo;
            Stock = stock;
        }

        public string RegistroProducto(Producto producto)
        {
            if (producto.Stock <= 0)
            {
                return "La cantidad digitada no puede ser menor a 0";
            }

            throw new NotImplementedException();
        }

        public string SalidaProducto(Producto producto)
        {


            throw new NotImplementedException();
        }
    }

}
