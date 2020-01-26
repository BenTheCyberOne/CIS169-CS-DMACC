/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 TextBox Demo
 The user will enter a name, click a button and the name will be output to a label
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

namespace TextBoxDemo
{
    public partial class TextBoxDemoForm : Form
    {
        public TextBoxDemoForm()
        {
            InitializeComponent();
        }

        private void ReadInputButton_Click(object sender, EventArgs e)
        {
            UserNameLabel.Text = UserNameBox.Text;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxDemoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
