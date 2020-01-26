using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pay_and_Bonus;
namespace PayAndBonusTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ButtonClick_InputIsValid_True()
        {
            decimal pay = 0m;
            decimal bonus = 0m;
            Form1 p = new Form1();
            p.grossPayTextBox.Text = "0";
            p.bonusTextBox.Text = "0";
            bool result = p.InputIsValid(ref pay, ref bonus);
            Assert.IsTrue(result, "Somehow, result is not true");
        }
        [TestMethod]
        public void ButtonClick_InputIsValid_False()
        {
            decimal pay = 0m;
            decimal bonus = 0m;
            Form1 p = new Form1();
            p.grossPayTextBox.Text = "a";
            p.bonusTextBox.Text = "b";
            bool result = p.InputIsValid(ref pay, ref bonus);
            Assert.IsFalse(result, "Somehow, result is not true");
        }
        [TestMethod]
        public void ButtonClick_InputIsValid_FirstFalseSecondTrue()
        {
            decimal pay = 0m;
            decimal bonus = 0m;
            Form1 p = new Form1();
            p.grossPayTextBox.Text = "a";
            p.bonusTextBox.Text = "0";
            bool result = p.InputIsValid(ref pay, ref bonus);
            if (result == true)//If the unexpected happens...
            {
                Assert.ThrowsException<System.ArgumentException>(() => result);
            }
        }
        [TestMethod]
        public void ButtonClick_InputIsValid_FirstTrueSecondFalse()
        {
            decimal pay = 0m;
            decimal bonus = 0m;
            Form1 p = new Form1();
            p.grossPayTextBox.Text = "0";
            p.bonusTextBox.Text = "b";
            bool result = p.InputIsValid(ref pay, ref bonus);
            if (result == true)//If the unexpected happens...
            {
                Assert.ThrowsException<System.ArgumentException>(() => result);
            }
        }
    }
}
