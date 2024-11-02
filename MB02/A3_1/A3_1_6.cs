using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB02.A3_1
{
    public partial class A3_1_6 : Form
    {
        private byte byte1 = 0;
        private byte byte2 = 0;

        private const string desc1 = "Dezimal: ";
        private const string desc2 = "Ergebnis Dezimal: ";
        private const string desc3 = "Ergebnis Binär: ";
        public A3_1_6()
        {
            InitializeComponent();

        }

        private void A3_1_6_Load(object sender, EventArgs e)
        {

        }

        private void NumB1_7_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 128;
            LblB1Dez.Text = desc1 + byte1;
        }

        private void NumB1_6_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 64;
            LblB1Dez.Text = desc1 + byte1;
        }

        private void NumB1_5_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 32;
            LblB1Dez.Text = desc1 + byte1;
        }

        private void NumB1_4_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 16;
            LblB1Dez.Text = desc1 + byte1;
        }

        private void NumB1_3_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 8;
            LblB1Dez.Text = desc1 + byte1;
        }

        private void NumB1_2_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 4;
            LblB1Dez.Text = desc1 + byte1;
        }

        private void NumB1_1_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 2;
            LblB1Dez.Text = desc1 + byte1;
        }

        private void NumB1_0_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 1;
            LblB1Dez.Text = desc1 + byte1;
        }

        private void NumB2_7_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 128;
            LblB2Dez.Text = desc1 + byte2;
        }

        private void NumB2_6_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 64;
            LblB2Dez.Text = desc1 + byte2;
        }

        private void NumB2_5_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 32;
            LblB2Dez.Text = desc1 + byte2;
        }

        private void NumB2_4_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 16;
            LblB2Dez.Text = desc1 + byte2;
        }

        private void NumB2_3_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 8;
            LblB2Dez.Text = desc1 + byte2;
        }

        private void NumB2_2_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 4;
            LblB2Dez.Text = desc1 + byte2;
        }

        private void NumB2_1_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 2;
            LblB2Dez.Text = desc1 + byte2;
        }

        private void NumB2_0_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 1;
            LblB2Dez.Text = desc1 + byte2;
        }

        private void CmdAND_Click(object sender, EventArgs e)
        {
            LblDez.Text = desc2 + (byte1 & byte2);
            LblBi.Text = desc3 + Convert.ToByte(byte1 & byte2);
        }

        private void CmdOR_Click(object sender, EventArgs e)
        {
            LblDez.Text = desc2 + (byte1 | byte2);
            LblBi.Text = desc3 + Convert.ToByte(byte1 | byte2);
        }

        private void CmdXOR_Click(object sender, EventArgs e)
        {
            LblDez.Text = desc2 + (byte1 ^ byte2);
            LblBi.Text = desc3 + Convert.ToByte(byte1 ^ byte2);
        }
    }
}
