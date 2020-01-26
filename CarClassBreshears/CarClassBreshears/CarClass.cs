/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Car Class Challenge
 The user can click a button to accelerate or decellerate a car object, as well as set the make and year
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarClassBreshears
{
    public partial class CarClass : Form
    {
        Car car = new Car();
        public CarClass()
        {
            InitializeComponent();
            makeLabel.Text = car.Make;
            yearLabel.Text = car.Year.ToString();
            currentSpeedLabel.Text = car.Speed.ToString();
        }
        private void accelerateButton_Click(object sender, EventArgs e)//call the accelerate function in class car
        {
            car.Accelerate();
            currentSpeedLabel.Text = car.Speed.ToString();
        }
        private void breakButton_Click(object sender, EventArgs e)//call the break function in class car
        {
            Boolean test = car.Break();
            if (test == true)
            {
                currentSpeedLabel.Text = car.Speed.ToString();
            }
            else
            {
                MessageBox.Show("Cannot go negative speed!");
            }
        }

        private void setMakeAndYearButton_Click(object sender, EventArgs e)//set the make and year without creating a whole new car object
        {
            Regex r = new Regex(@"[~`!@#$%^&*()+=|\\{}':;.,<>/?[\]""_-]");//regex to validate input
            if (makeTextBox.Text == "" || yearTextBox.Text == "")//test to see if textboxes are empty
            {
                MessageBox.Show("Please enter a valid Make and Year.");
            }
            else if (makeTextBox.Text.All(char.IsDigit))//check if make textbox contains numbers
            {
                MessageBox.Show("Make can not contain numeric values.");
            }
            else if (!int.TryParse(yearTextBox.Text, out int i))//check if year textbox is numeric only
            {
                MessageBox.Show("Year can be integer only!");
            }
            else if (Int32.Parse(yearTextBox.Text) < 1885 || Int32.Parse(yearTextBox.Text) > 2020)//check if year is logical
            {
                MessageBox.Show("Year must be between 1885 and 2020");
            }
            else if (r.IsMatch(makeTextBox.Text) || (r.IsMatch(yearTextBox.Text)))//check the regex for special characters
            {
                MessageBox.Show("Special characters are not allowed!");
            }
            else
            {
                car.Make = makeTextBox.Text;//if all checks pass, set the make
                car.Year = Int32.Parse(yearTextBox.Text);//if all checks pass, set the year
                makeLabel.Text = car.Make;
                yearLabel.Text = car.Year.ToString();
                car.Speed = 0;//reset because we changed cars
                currentSpeedLabel.Text = "0";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)//exit the program
        {
            this.Close();
        }
    }
}
