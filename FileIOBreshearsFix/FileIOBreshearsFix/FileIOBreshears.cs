/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 File IO
 The user can input a name of a friend and it will append to a text file. The user can also read from the same text file.
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
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileIOBreshearsFix
{
    public partial class FileIOBreshears : Form
    {
        public FileIOBreshears()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)//Create/Open the "Friend.txt" file and append whatever is in the textbox to a new line 
        {
            string inputName = nameTextBox.Text;
            try
            {
                if (inputName.Any(char.IsDigit) == false)
                {
                StreamWriter outputFile;
                outputFile = File.AppendText("Friend.txt");
                outputFile.WriteLine(inputName);
                outputFile.Close();
                nameTextBox.Text = "";
                nameTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Names can not be numbers!");
                    nameTextBox.Text = "";
                    nameTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)//Accidentally created reference before renaming, renaming now crashes program
            //Open the Friend.txt file and while it is not EOS, add a line of text from the txt file
        {
            try
            {
                string listedName;
                StreamReader inputFile = File.OpenText("Friend.txt");
                FriendListTextBox.Text = "";
                while (!inputFile.EndOfStream)
                {
                    listedName = inputFile.ReadLine();
                    FriendListTextBox.AppendText(listedName);//This is so we can display each name on their own line
                    FriendListTextBox.AppendText(Environment.NewLine);
                }
                inputFile.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
