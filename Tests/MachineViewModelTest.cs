using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using SmitDemo;

namespace SmitTest
{
    [TestClass]
    public class MachineViewModelTest
    {
        [TestMethod]
        public void Constructor_CreateViewModel_CheckProperties() {
            var machine = new MachineMock();

            var vm = new MachineViewModel(machine);

            Assert.AreEqual(vm.MachineLength, MachineMock.LENGTH, 1e-5);
            Assert.AreEqual(vm.MachineWidth, MachineMock.WIDTH, 1e-5);
            Assert.IsFalse(vm.IsFull);
            Assert.IsFalse(vm.ProductViewModels.Any());
        }

        [TestMethod]
        public void Constructor_CreateViewModel_CheckProperties1() {
            var machine = new MachineMock();
            var product = new ProductMock();

            var vm = new MachineViewModel(machine);
            vm.AddProduct(product);

            Assert.AreEqual(vm.ProductViewModels.Count(), 1);
        }
    }
}
