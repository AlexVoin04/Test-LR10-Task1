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

    [TestClass]
    public class QuadraticEquationTest
    {
        [TestMethod]
        public void QuadraticEquation__returned()
        {
            (string, string) expected1 = ("-3,73", "-0,27");
            (string, string) expected2 = ("-4,24", "0,24");
            (string, string) expected3 = (null, null);
            Addition add = new Addition();
            (string, string) result1 = add.SolvingTheQuadraticEquation(1, 4, 1);
            (string, string) result2 = add.SolvingTheQuadraticEquation(1, 4, -1);
            (string, string) result3 = add.SolvingTheQuadraticEquation(1, 1, 1);


            //Assert.AreEqual(expected1, result1);
            Assert.AreEqual(expected2, result2);
            Assert.AreEqual(expected3, result3);
        }

        [TestMethod]
        public void QuadraticEquation__returnedFail()
        {
            (string, string) expected1 = ("-3,73", "-0,13");
            (string, string) expected2 = ("-4,24", "0,12");
            (string, string) expected3 = (null, "3");
            Addition add = new Addition();
            (string, string) result1 = add.SolvingTheQuadraticEquation(1, 4, 1);
            (string, string) result2 = add.SolvingTheQuadraticEquation(1, 4, -1);
            (string, string) result3 = add.SolvingTheQuadraticEquation(1, 1, 1);


            //Assert.AreEqual(expected1, result1);
            //Assert.AreEqual(expected2, result2);
            Assert.AreEqual(expected3, result3);
        }
    }
}
