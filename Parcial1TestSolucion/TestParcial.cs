using NUnit.Framework;
using ParcialSolucion;


namespace Parcial1TestSolucion
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NoPuedeRegistrarCantidadMenorAUno()
        {
            var producto = new Producto(idProducto: "01", nombreProducto: "Salchicha", precioVenta: 2000, costoEmpresa: 1000, stock: -2);
            ProductoSimple productoSimple = new ProductoSimple();

            string respuesta = productoSimple.RegistroProducto(producto);

            Assert.AreEqual("La cantidad digitada no puede ser menor a 0", respuesta);

        }

        [Test]
        public void PuedeRegistrarLosProductos()
        {
            var producto = new Producto(idProducto: "01", nombreProducto: "Salchicha", precioVenta: 2000, costoEmpresa: 1000, stock: 3);
            ProductoSimple productoSimple = new ProductoSimple();

            string respuesta = productoSimple.RegistroProducto(producto);

            Assert.AreEqual(1, productoSimple.listaProductosSimples.Count);
            Assert.AreEqual("Se registro correctamente la cantidad del stock es de 3", respuesta);

        }
    }
}