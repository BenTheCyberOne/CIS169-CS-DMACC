using Microsoft.VisualStudio.TestTools.UnitTesting;
using HospitalChargesBreshears;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalChargesBreshears.Tests
{
    [TestClass()]
    public class HospitalChargesTests
    {
        [TestMethod()]
        public void HospitalCharges_CalcStayCharges_Return700()
        {
            int days = 2;
            int expected = 700;
            HospitalCharges x = new HospitalCharges();
            int result = x.CalcStayCharges(days);
            Assert.AreEqual(expected, result, "Somehow, the end result was not equal");
        }
        [TestMethod]
        public void HospitalCharges_CalcStayCharges_OutOfRangeException()
        {
            int days = 0;
            HospitalCharges x = new HospitalCharges();
            int result = x.CalcStayCharges(days);
            if (result < 0)
            {
                Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => result);
            }
        }
        [TestMethod]
        public void HospitalCharges_CalcMiscCharges_Return2825()
        {
            double medCharges = 425;
            double surgCharges = 1250;
            double labCharges = 350;
            double rehabCharges = 800;
            double expected = 2825;
            HospitalCharges x = new HospitalCharges();
            double result = x.CalcMiscCharges(medCharges, surgCharges, labCharges, rehabCharges);
            Assert.AreEqual(expected, result, "Somhow, the end result was not equal");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),"medCharges cannot be negative")]
        public void HospitalCharges_CalcMiscCharges_medChargesOutOfRangeException()
        {
            HospitalCharges x = new HospitalCharges();
            double medCharges = -1;
            double surgCharges = 1250;
            double labCharges = 350;
            double rehabCharges = 800;
            double result = x.CalcMiscCharges(medCharges, surgCharges, labCharges, rehabCharges);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "surgCharges cannot be negative")]
        public void HospitalCharges_CalcMiscCharges_surgChargesOutOfRangeException()
        {
            HospitalCharges x = new HospitalCharges();
            double medCharges = 425;
            double surgCharges = -1250;
            double labCharges = 350;
            double rehabCharges = 800;
            double result = x.CalcMiscCharges(medCharges, surgCharges, labCharges, rehabCharges);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "labCharges cannot be negative")]
        public void HospitalCharges_CalcMiscCharges_labChargesOutOfRangeException()
        {
            HospitalCharges x = new HospitalCharges();
            double medCharges = 425;
            double surgCharges = 1250;
            double labCharges = -350;
            double rehabCharges = 800;
            double result = x.CalcMiscCharges(medCharges, surgCharges, labCharges, rehabCharges);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "rehabCharges cannot be negative")]
        public void HospitalCharges_CalcMiscCharges_rehabChargesOutOfRangeException()
        {
            HospitalCharges x = new HospitalCharges();
            double medCharges = 425;
            double surgCharges = 1250;
            double labCharges = 350;
            double rehabCharges = -800;
            double result = x.CalcMiscCharges(medCharges, surgCharges, labCharges, rehabCharges);
        }
    }

}