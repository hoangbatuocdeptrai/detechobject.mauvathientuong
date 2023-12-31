﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selected_Color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap)pictureBox1.Image;
            Color clr = pixelData.GetPixel(e.X, e.Y);
            IbISmallScreen.BackColor = clr;

            IbIRGBValues.Text = "R: " + clr.R.ToString() + "G: " + clr.G.ToString() + "B: " + clr.B.ToString();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap) pictureBox1.Image;
            Color clr = pixelData.GetPixel(e.X, e.Y);
            tblRedValue.Text = clr.R.ToString();
            tblGreenValues.Text = clr.G.ToString();
            tblBlueValues.Text = clr.B.ToString();
        }
    }
}
