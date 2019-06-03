using System.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmitDemo;

namespace SmitTest
{
    [TestClass]
    public class ConvertersTest
    {
        [TestMethod]
        public void PositionToScreenConverter_Convert() {
            var converter = new PositionToScreenConverter();
            double expectedScreenPos = 10.0;
            double screenSize = 100.0;
            double machinePos = 0.01;
            string machineSize = "0.1";

            var actual = converter.Convert(new object[] { screenSize, machinePos, machineSize }, null, null, null);

            Assert.AreEqual(expectedScreenPos, (double)actual, 1e-5);    
        }

        [TestMethod]
        public void PositionToVisibilityConverter_Convert_Visible() {
            var converter = new PositionToVisibilityConverter();
            var expected = Visibility.Visible;
            double x = 10.1;
            double y = 0.01;
            double length = 1.0;
            double width = 0.01;
            string m_length = "100.0";
            string m_width = "0.1";

            var actual = converter.Convert(new object[] { x, y, length, width, m_length, m_width }, null, null, null);

            Assert.AreEqual(expected, (Visibility)actual);
        }

        [TestMethod]
        public void PositionToVisibilityConverter_Convert_Invisible() {
            var converter = new PositionToVisibilityConverter();
            var expected = Visibility.Hidden;
            double x = 99.1;
            double y = 0.01;
            double length = 1.0;
            double width = 0.01;
            string m_length = "100.0";
            string m_width = "0.1";

            var actual = converter.Convert(new object[] { x, y, length, width, m_length, m_width }, null, null, null);

            Assert.AreEqual(expected, (Visibility)actual);
        }
    }
}
