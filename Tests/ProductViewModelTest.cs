using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmitDemo;

namespace SmitTest
{
    [TestClass]
    public class ProductViewModelTest
    {
        [TestMethod]
        public void Constructor_CreateViewModel_CheckProperties() {
            var product = new ProductMock();

            var vm = new ProductViewModel(product);

            Assert.AreEqual(vm.ProductId, ProductMock.ID);
            Assert.AreEqual(vm.CustomerProductId, ProductMock.CID);
            Assert.AreEqual(vm.MachinePosX, ProductMock.POS_X, 1e-5);
            Assert.AreEqual(vm.MachinePosY, ProductMock.POS_Y, 1e-5);
            Assert.AreEqual(vm.ProductState, ProductMock.STATE);
        }

        [TestMethod]
        public void CommandReject_CreateViewModel_CheckProductEjected() {
            var product = new ProductData(1, "", 0, 0);
            var vm = new ProductViewModel(product);

            vm.CommandReject.Execute(null);

            Assert.AreEqual(vm.ProductState, ProductState.ProductRejected);
        }
    }
}
