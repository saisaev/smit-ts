using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmitDemo;
using System.Linq;

namespace SmitTest
{
    [TestClass]
    public class MachineTest
    {
        [TestMethod]
        public void Constructor_CreateMachine_CheckFields() {
            int capacity = 2;
            double length = 2.0;
            double width = 1.0;

            var machine = new MachineData(length, width, capacity);

            Assert.AreEqual(machine.Length, length, 1e-5);
            Assert.AreEqual(machine.Width, width, 1e-5);
            Assert.IsFalse(machine.Products.Any());
            Assert.IsFalse(machine.IsFull);
        }

        [TestMethod]
        public void AddProduct_CreateMachine_ValidateProducts() {
            int capacity = 2;
            double length = 2.0;
            double width = 1.0;
            var machine = new MachineData(length, width, capacity);
            var prod1 = new ProductMock();
            var prod2 = new ProductMock();

            machine
                .AddProduct(prod1)
                .AddProduct(prod2);

            Assert.AreEqual(machine.Products.Count(), 2);
            Assert.AreSame(machine.Products.ElementAt(0), prod1);
            Assert.AreSame(machine.Products.ElementAt(1), prod2);
            Assert.IsTrue(machine.IsFull);
        }
    }
}
