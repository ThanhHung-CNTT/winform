﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lableeeeel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblText.Text = "This is my first Lable";
            lblText.BorderStyle = BorderStyle.FixedSingle;
            lblText.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
