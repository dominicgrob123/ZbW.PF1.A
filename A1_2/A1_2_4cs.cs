using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB01.A1_2
{
    public partial class A1_2_4cs : Form
    {
        public A1_2_4cs()
        {
            InitializeComponent();
        }

        private void CmdBiggerHeight_Click(object sender, EventArgs e)
        {
            Size = new Size(Size.Width, Size.Height + 1);
        }

        private void CmdSmallerHeight_Click(object sender, EventArgs e)
        {
            Size = new Size(Size.Width, Size.Height - 1);
        }

        private void CmdBiggerWidth_Click(object sender, EventArgs e)
        {
            Size = new Size(Size.Width + 1, Size.Height);
        }

        private void CmdSmallerWidth_Click(object sender, EventArgs e)
        {
            Size = new Size(Size.Width - 1, Size.Height + 1);
        }

        private void A1_2_4cs_SizeChanged(object sender, EventArgs e)
        {
            CenterToScreen();
            Location = new Point(Location.X, Location.Y);
            LblPosition.Text = $"Position: " + Location.X +"; " + Location.Y;
            LblDimension.Text = $"Dimension: " + Size.Width +"; " + Size.Height;
        }
    }
}
