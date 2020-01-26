using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HospitalChargesBreshears;
namespace HospitalChargesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HospitalCharges_CalcStayCharges_Return700()
        {
            int days = 2;
            int expected = 700;
            HospitalCharges x = new HospitalCharges();
            int result = x.CalcStayCharges(days);
        }
    }
}
