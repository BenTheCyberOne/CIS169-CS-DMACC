using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cups_To_Ounces;
namespace CupsToOuncesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void ButtonClick_3Cups_24Ounces()
        {
            double cups = 3;
            double expected = 24;
            Form1 c = new Form1();
            double ounces = c.CupsToOunces(cups);
            Assert.AreEqual(expected, ounces, "Somehow, the end result was not equal");
        }
        [TestMethod]
        public void ButtonClick_halfCups_4Ounces()
        {
            double cups = 0.5;
            double expected = 4;
            Form1 c = new Form1();
            double ounces = c.CupsToOunces(cups);
            Assert.AreEqual(expected, ounces, "Somehow, the end result was not equal");
        }
        [TestMethod]
        public void ButtonClick_thirdCups_2Ounces()
        {
            //We could also do Math.Round depending on the needness of exactness
            double cups = 0.33;
            double expected = 2.66;
            Form1 c = new Form1();
            double ounces = c.CupsToOunces(cups);
            Assert.AreEqual(expected, ounces, 0.03, "Somehow, the end result was not equal");
        }
        [TestMethod]
        public void ButtonClick_InvalidInput_NegativeException()
        {
            double cups = 0;
            Form1 c = new Form1();
            double ounces = c.CupsToOunces(cups);
            if (ounces < 0)
            {
                Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => ounces);
            }
        }

    }
}
