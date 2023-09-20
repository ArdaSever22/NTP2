using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseHover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Mouse Üzerimde");
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Mouse Üzerimde Değildir");
        }
    }
}
