using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestLR10;

namespace Test_LR10_Task1Tests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            //исходные данные
            int a = 3;
            int b = 5;
            int expected = 15;

            //получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            //Сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CylinderVolume_3and5_235_62returned()
        {
            double a = 3;
            double b = 5;
            double expected = 141.37;

            Geometry g = new Geometry();
            double actual = g.CylinderVolume(a, b);

            Assert.AreEqual(expected, actual);

        }
    }
}
