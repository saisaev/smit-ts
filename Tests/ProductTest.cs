using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmitDemo;

namespace SmitTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void Constructor_CreateProduct_CheckFields() {
            int id = 1;
            string customerId = "demo";
            double posX = 1.11;
            double posY = 2.22;
            var product = new ProductData(id, customerId, posX, posY);

            Assert.AreEqual(product.ProductId, id);
            Assert.AreEqual(product.CustomerProductId, customerId);
            Assert.AreEqual(product.PosX, posX, 1e-5);
            Assert.AreEqual(product.PosY, posY, 1e-5);
        }
    }
}
