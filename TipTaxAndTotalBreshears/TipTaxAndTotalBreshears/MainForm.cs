/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Tip, Tax, and Total
 The user can input the initial price of a bill and will be shown the 15% tip amount, the 7% tax amount, and the total price of the bill.
 Academic Honesty:
 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipTaxAndTotalBreshears
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e) // If the user has input a real number, the tip and tax totals are calculated and added together to the base amount to give the user their total amount. Else, a message will appear showing how they must enter a valid number.
        {
            try
            {
                double initPrice = double.Parse(StartPriceBox.Text);
                double tip = initPrice * .15;
                double tax = initPrice * .07;
                double totalPrice = initPrice + tip + tax;
                TipCalculateLabel.Text = tip.ToString("c");
                TaxCalculateLabel.Text = tax.ToString("c");
                TotalCalculateLabel.Text = totalPrice.ToString("c");
            }
            catch
            {
                MessageBox.Show("Please enter a valid price");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)// Closes the program
        {
            this.Close();
        }
    }
}
