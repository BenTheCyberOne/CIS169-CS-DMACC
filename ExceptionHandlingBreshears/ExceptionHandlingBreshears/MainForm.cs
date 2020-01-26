/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Exception Handling 
 The user can calculate a discounted price of an item by entering integers only and clicking a button. A message will appear if the user enters anything except a type that can be parsed into a proper decimal.
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

namespace ExceptionHandlingBreshears
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice;
            decimal discountPercentage;
            decimal discountAmount;
            decimal salePrice;
            try
            {
                originalPrice = decimal.Parse(OriginalBox.Text);
                discountPercentage = decimal.Parse(DiscountBox.Text);
                discountPercentage = discountPercentage / 100;
                discountAmount = originalPrice * discountPercentage;
                salePrice = originalPrice - discountAmount;
                FinalBox.Text = salePrice.ToString("c");
            }
            catch
            {
                MessageBox.Show("Inputs must be valid integers!");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
