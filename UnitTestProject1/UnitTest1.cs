using Marzo9.modelo;
using Marzo9.srv;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ProductoSrv productoSrv = new ProductoSrv();

            Assert.IsTrue(productoSrv.ListarTodo().Count > 0);
            var prod = new Producto
            {
                Nombre = "cccc",
                Num = 33,
                Precio = 333,
                Stock = 333
            };
            Assert.IsTrue(productoSrv.Insertar(prod));


        }
    }
}
