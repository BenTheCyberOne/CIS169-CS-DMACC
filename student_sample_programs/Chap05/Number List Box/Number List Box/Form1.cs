﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Number_List_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            numberListBox.Items.Add(10);
            numberListBox.Items.Add(20);
            numberListBox.Items.Add(30);
            numberListBox.Items.Add(40);
        }
    }
}
