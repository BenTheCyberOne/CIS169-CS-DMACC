/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Employee DB Search
 The user can view and search from a table of employees
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

namespace EmployeeSearch
{
    public partial class EmployeeSearchForm : Form
    {
        public EmployeeSearchForm()
        {
            InitializeComponent();
        }

        private void employeeTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeesDataSet);

        }

        private void EmployeeSearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeesDataSet.EmployeeTable' table. You can move, or remove it, as needed.
            this.employeeTableTableAdapter.Fill(this.employeesDataSet.EmployeeTable);

        }

        private void exitButton_Click(object sender, EventArgs e)//exit the program
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)//query using LIKE and nameTextBox.Text
        {
            Regex r = new Regex(@"[/~`!@#$%^&*()+=|\\{}':;.,<>/?[\]""_-]");//regex to validate input - we don't want to be injected!
            Regex regex = new Regex(@"^[a-zA-Z ]*$");//for text only
            if (nameTextBox.Text == "" || r.IsMatch(nameTextBox.Text) || regex.IsMatch(nameTextBox.Text) == false)
            {
                MessageBox.Show("Please enter a valid name.");
                nameTextBox.Text = "";
            }
            else
            {
                this.employeeTableTableAdapter.FillByName(this.employeesDataSet.EmployeeTable, nameTextBox.Text);
            }
        }
    }
}
