using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            const int factor1 = 3;
            const int factor2 = 23;
            const int expected = 69;

            //Act
            var actual = Program.Mult(factor1, factor2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
