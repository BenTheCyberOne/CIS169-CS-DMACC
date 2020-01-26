/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Hospital Charges
 The user can input their bill amounts and get a calculated answer
 Academic Honesty:
 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalChargesBreshears
{
    public partial class HospitalCharges : Form
    {
        public HospitalCharges()
        {
            InitializeComponent();
        }
        public int CalcStayCharges(int days)//calculate the base fee from days * $350
        {
            int stayCharges = (350 * days);
            return stayCharges;
        }
        public double CalcMiscCharges(double medCharges, double surgCharges, double labCharges, double rehabCharges)//take all of the misc charges and add them together
        {
            if (medCharges < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (surgCharges < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (labCharges < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (rehabCharges < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                double miscCharges = (medCharges + surgCharges + labCharges + rehabCharges);
                return miscCharges;
            }
        }
        private double CalcTotalCharges(double miscCharges, double stayCharges)//calculate the final total
        {
            double total = (miscCharges + stayCharges);
            return total;
        }
        public void calculateButton_Click(object sender, EventArgs e)//try to parse the user input into int and double, then pass along to corresponding functions
        {
            try
            {
                int days = Convert.ToInt32(daysTextBox.Text);
                double medCharges = Convert.ToDouble(medTextBox.Text);
                double surgCharges = Convert.ToDouble(surgTextBox.Text);
                double labCharges = Convert.ToDouble(labTextBox.Text);
                double rehabCharges = Convert.ToDouble(rehabTextBox.Text);
                int stayCharges = CalcStayCharges(days);
                double miscCharges = CalcMiscCharges(medCharges, surgCharges, labCharges, rehabCharges);
                double total = CalcTotalCharges(miscCharges, stayCharges);
                totalTextBox.Text = Convert.ToString(total);
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers to calculate your total. (enter 0 for N/A)");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)//exit the program
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//Ignore this - still don't know how to get rid of references entirely yet
        {

        }
    }
}
