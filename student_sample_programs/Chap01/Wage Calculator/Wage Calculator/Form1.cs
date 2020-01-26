using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wage_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcGrossPayButton_Click(object sender, EventArgs e)
        {
            string str1 = "MANUEL";
            string str2 = "manuel";
            
        if (String.Compare(str1, str2) > 0)
                 {
                     MessageBox.Show(str1 + " and " + str2 + " are equal.");
                 }
             else
  {
                     MessageBox.Show(str1 + " and " + str2 + " are NOT equal.");
                }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
