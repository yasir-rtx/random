using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int bil1;
        public int bil2;
        public int hasil;

        private void butttonPlus_Click(object sender, EventArgs e)
        {
            hasil = bil1 + bil2;
            txtHasil.Text = hasil.ToString();
        }

        private void buttonSplit_Click(object sender, EventArgs e)
        {
            hasil = bil1 - bil2;
            txtHasil.Text = hasil.ToString();
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            hasil = bil1 * bil2;
            txtHasil.Text = hasil.ToString();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            hasil = bil1 / bil2;
            txtHasil.Text = hasil.ToString();
        }

        private void txtBil1_TextChanged(object sender, EventArgs e)
        {
            bil1 = int.Parse(txtBil1.Text);
        }

        private void txtBil2_TextChanged(object sender, EventArgs e)
        {
            bil2 = int.Parse(txtBil2.Text);
        }
    }
}
