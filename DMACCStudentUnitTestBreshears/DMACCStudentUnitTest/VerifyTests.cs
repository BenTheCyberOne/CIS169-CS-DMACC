using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Text.RegularExpressions;

namespace DMACCStudentUnitTest
{
    [TestClass]
    public class VerifyTests
    {
        [TestMethod]
        public void DMACCStudent_ValidateStudentNumber()
        {
            Regex r = new Regex(@"[/~`!@#$%^&*()+=|\\{}':;.,<>/?[\]""_-]");
            string s1 = "900";
            string studentNumber = "900950701";
            int length = studentNumber.Length;
            if (r.IsMatch(studentNumber) || length > 9 || studentNumber.All(char.IsDigit) == false || studentNumber.Contains(s1) == false)
            {
                throw new System.ArgumentException("must be a valid student number");
            }
        }
        [TestMethod]
        public void DMACCStudent_ValidateFirstName()
        {
            Regex r = new Regex(@"[/~`!@#$%^&*()+=|\\{}:;.,<>/?[\]""_]");
            string firstName = "ben";
            firstName = char.ToUpper(firstName[0]) + firstName.Substring(1);
            if (r.IsMatch(firstName) || firstName.All(char.IsDigit) == true)
            {
                throw new System.ArgumentException("must be a valid first name");
            }
        }
        [TestMethod]
        public void DMACCStudent_ValidateLastName()
        {
            Regex r = new Regex(@"[/~`!@#$%^&*()+=|\\{}:;.,<>/?[\]""_]");
            string lastName = "breshears";
            lastName = char.ToUpper(lastName[0]) + lastName.Substring(1);
            if (r.IsMatch(lastName) || lastName.All(char.IsDigit) == true)
            {
                throw new System.ArgumentException("must be a valid last name");
            }
        }
        [TestMethod]
        public void DMACCStudent_ValidateCRN()
        {
            Regex r = new Regex(@"[/~`!@#$%^&*()+=|\\{}:;.,<>/?[\]""_]");
            string crn = "12345";
            int length = crn.Length;
            if (r.IsMatch(crn) || length > 5 || crn.All(char.IsDigit) == false)
            {
                throw new System.ArgumentException("must be a valid CRN");
            }
        }
        [TestMethod]
        public void DMACCStudent_ValidateClassCodeAndNumber()
        {
            Regex r = new Regex(@"[/~`!@#$%^&*()+=|\\{}:;.,<>/?[\]""_]");
            string classinfo = "CIS169";
            string classcode = classinfo.Substring(0, 2);
            string classnumber = classinfo.Substring(3);
            int length = classinfo.Length;
            if (r.IsMatch(classinfo) || length > 6 || classcode.All(char.IsDigit) == true || classnumber.All(char.IsDigit) == false)
            {
                throw new System.ArgumentException("must be a valid course code and number (no spaces or hyphens)");
            }

        }

    }
}
