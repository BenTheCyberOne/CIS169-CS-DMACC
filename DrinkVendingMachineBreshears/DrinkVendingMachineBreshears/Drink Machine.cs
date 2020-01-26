/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Drink Vending Machine
 The user can click a picture of soda and simulate a vending machine experience
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

namespace DrinkVendingMachineBreshears
{
    public partial class DrinkMachine : Form
    {
        public DrinkMachine()
        {
            InitializeComponent();
        }
        public struct Drink//drink structure
        {
            public String name;
            public double cost;
            public int drinksLeft;
        }
        public Drink[] drinks = new Drink[] {
            new Drink { name = "Dr. Good Guy", cost = 1, drinksLeft = 20 },
            new Drink { name = "Dr. Radical", cost = 1, drinksLeft = 20 },
            new Drink {name = "Mr. Aahh", cost = 1, drinksLeft = 20 },
            new Drink {name = "Mr. Pig", cost = 1.5, drinksLeft = 20 },
            new Drink {name = "Dr. Skipper", cost = 1.5, drinksLeft = 20 } };//array of drinks
        public double totalSales = 0;//used for total sales
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sodaBox1_Click(object sender, EventArgs e)//if there are drinks left, subtract one and add to the total price
        {
            if (drinks[0].drinksLeft > 0)
            {
                totalSales += drinks[0].cost;
                --drinks[0].drinksLeft;
                totalLabel1.Text = drinks[0].drinksLeft.ToString();
                totalLabel6.Text = totalSales.ToString("c");
            }
            else
            {
                MessageBox.Show("We're sorry - this drink is no longer available");
            }
        }

        private void sodaBox2_Click(object sender, EventArgs e)//if there are drinks left, subtract one and add to the total price
        {
            if (drinks[1].drinksLeft > 0)
            {
                totalSales += drinks[1].cost;
                --drinks[1].drinksLeft;
                totalLabel2.Text = drinks[1].drinksLeft.ToString();
                totalLabel6.Text = totalSales.ToString("c");
            }
            else
            {
                MessageBox.Show("We're sorry - this drink is no longer available");
            }
        }

        private void sodaBox3_Click(object sender, EventArgs e)//if there are drinks left, subtract one and add to the total price
        {
            if (drinks[2].drinksLeft > 0)
            {
                totalSales += drinks[2].cost;
                --drinks[2].drinksLeft;
                totalLabel3.Text = drinks[2].drinksLeft.ToString();
                totalLabel6.Text = totalSales.ToString("c");
            }
            else
            {
                MessageBox.Show("We're sorry - this drink is no longer available");
            }
        }

        private void sodaBox4_Click(object sender, EventArgs e)//if there are drinks left, subtract one and add to the total price
        {
            if (drinks[3].drinksLeft > 0)
            {
                totalSales += drinks[3].cost;
                --drinks[3].drinksLeft;
                totalLabel4.Text = drinks[3].drinksLeft.ToString();
                totalLabel6.Text = totalSales.ToString("c");
            }
            else
            {
                MessageBox.Show("We're sorry - this drink is no longer available");
            }
        }

        private void sodaBox5_Click(object sender, EventArgs e)//if there are drinks left, subtract one and add to the total price
        {
            if (drinks[4].drinksLeft > 0)
            {
                totalSales += drinks[4].cost;
                --drinks[4].drinksLeft;
                totalLabel5.Text = drinks[4].drinksLeft.ToString();
                totalLabel6.Text = totalSales.ToString("c");
            }
            else
            {
                MessageBox.Show("We're sorry - this drink is no longer available");
            }
        }
    }
}
