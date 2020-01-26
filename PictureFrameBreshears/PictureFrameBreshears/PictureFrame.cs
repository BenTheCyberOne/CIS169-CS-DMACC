/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Picture Frame
 The user can click the image box and recieve a random image from a list
 ### No default "Accept" User Assigned Key Required ###
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

namespace PictureFrameBreshears
{
    public partial class PictureFrame : Form
    {
        public PictureFrame()
        {
            InitializeComponent();
        }

        private void photoBox_Click(object sender, EventArgs e)//when clicked, change the image
        {
            Random rnd = new Random();
            int randNum = rnd.Next(0, photoList.Images.Count);
            photoBox.Image = photoList.Images[randNum];//set the image to a random image in the list
        }

        private void exitButton_Click(object sender, EventArgs e)//exit the program
        {
            this.Close();
        }
    }
}
