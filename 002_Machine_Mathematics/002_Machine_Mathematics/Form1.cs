using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_Machine_Mathematics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void byteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0 : 255", "byte");
        }

        private void sbyteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-128 : 127", "sbyte");
        }

        private void shortButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-32768 : 32767", "short");
        }

        private void ushortButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0 : 65535", "ushort");
        }

        private void intButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-2147483648 : 2147483647", "int");
        }

        private void uintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0 : 4294967295", "uint");
        }

        private void longButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("–9 223 372 036 854 775 808 : 9 223 372 036 854 775 807", "long");
        }

        private void ulongButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0 : 18 446 744 073 709 551 615", "ulong");
        }
    }
}
