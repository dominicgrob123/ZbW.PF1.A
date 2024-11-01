using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB01.A1_2
{
    public partial class A1_2_5 : Form
    {
        public A1_2_5()
        {
            InitializeComponent();
        }

        private void Cmd2to7_Click(object sender, EventArgs e)
        {
            Cmd2to7.Text = "1";
        }

        private void Cmd2to6_Click(object sender, EventArgs e)
        {
            Cmd2to6.Text = "1";
        }

        private void Cmd2to5_Click(object sender, EventArgs e)
        {
            Cmd2to5.Text = "1";
        }

        private void Cmd2to4_Click(object sender, EventArgs e)
        {
            Cmd2to4.Text = "1";
        }

        private void Cmd2to3_Click(object sender, EventArgs e)
        {
            Cmd2to3.Text = "1";
        }

        private void Cmd2to2_Click(object sender, EventArgs e)
        {
            Cmd2to2.Text = "1";
        }

        private void Cmd2to1_Click(object sender, EventArgs e)
        {
            Cmd2to1.Text = "1";
        }

        private void Cmd2to0_Click(object sender, EventArgs e)
        {
            Cmd2to0.Text = "1";
        }

        private void CmdBerechne_Click(object sender, EventArgs e)
        {
            LblWert.Text = "Wert in Dezimal: " + Convert.ToString(Convert.ToInt16(Cmd2to7.Text + Cmd2to6.Text + Cmd2to5.Text + Cmd2to4.Text + Cmd2to3.Text + Cmd2to2.Text + Cmd2to1.Text + Cmd2to0.Text, 2));
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            Cmd2to0.Text = "0";
            Cmd2to1.Text = "0";
            Cmd2to2.Text = "0";
            Cmd2to3.Text = "0";
            Cmd2to4.Text = "0";
            Cmd2to5.Text = "0";
            Cmd2to6.Text = "0";
            Cmd2to7.Text = "0";
            LblWert.Text = "0";
        }
    }
}
