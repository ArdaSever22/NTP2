﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            { pictureBox1.Visible = radioButton1.Checked; }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            { pictureBox2.Visible = radioButton2.Checked; }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            { pictureBox3.Visible = radioButton3.Checked; }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            { pictureBox4.Visible = radioButton4.Checked; }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
