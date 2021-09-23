using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialSolucion
{
    public class ProductoSimple : Producto
    {
        public List<ProductosSimples> listaProductosSimples;
        public IReadOnlyCollection<ProductosSimples> ProductosSimples => listaProductosSimples.AsReadOnly();
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

            listaProductosSimples = new List<ProductosSimples>();
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
                listaProductosSimples.Add(new ProductosSimples(producto: producto));

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
            ProductoSimple = producto;
        }

        public ProductoSimple ProductoSimple { get; set; }
    }

}
