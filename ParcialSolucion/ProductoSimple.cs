using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialSolucion
{
    public class ProductoSimple : Producto
    {
        private List<ProductoSimple> listaProductosSimples;
        public IReadOnlyCollection<ProductoSimple> ProductosSimpless => listaProductosSimples.AsReadOnly();//leer
        public ProductoSimple()
        {

        }

        public ProductoSimple(string idProducto, string nombreProducto, decimal precioVenta, decimal costoEmpresa, int stock)
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            PrecioVenta = precioVenta;
            CostoEmpresa = costoEmpresa;
            Stock = stock;

            listaProductosSimples = new List<ProductoSimple>();
        }

        public string RegistroProducto(ProductoSimple producto)
        {
            if (producto.Stock <= 0)
            {
                return "La cantidad digitada no puede ser menor a 0";
            }
            if (producto.Stock > 0)
            {

                //ProductosSimples productosSimples = new ProductosSimples(producto);
                //listaProductosSimples.Add(productosSimples);
                listaProductosSimples.Add(producto);
                //ProductosSimpless.Add(new ProductosSimples(producto: this));

                return $"Se registro correctamente la cantidad del stock es de {producto.Stock}";
            }
            throw new NotImplementedException();
            
        }

        public string SalidaProducto(Producto producto)
        {


            throw new NotImplementedException();
        }
    }

    public class ProductosSimples
    {
        public ProductosSimples(ProductoSimple producto )
        {
            ProductosSimple = producto;
        }

        public ProductosSimples()
        {

        }

        public ProductoSimple ProductosSimple { get; set; }
    }

}
