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
            var productSimple = new ProductoSimple(idProducto: "01", nombreProducto: "Salchicha", precioVenta: 2000, costoEmpresa: 1000, stock: -2);
            ProductoSimple productoSimple = new ProductoSimple();

            string respuesta = productoSimple.RegistroProducto(productSimple);

            Assert.AreEqual("La cantidad digitada no puede ser menor a 0", respuesta);

        }

        [Test]
        public void PuedeRegistrarLosProductos()
        {
            var productSimple = new ProductoSimple(idProducto: "010", nombreProducto: "Salchicha", precioVenta: 2000, costoEmpresa: 1000, stock: 30);
            ProductoSimple productoSimple = new ProductoSimple();

            string respuesta = productoSimple.RegistroProducto(productSimple);

            //Assert.AreEqual(0, productoSimple.ProductosSimpless.Count);
            Assert.AreEqual("Se registro correctamente la cantidad del stock es de 3", respuesta);

        }
    }
}