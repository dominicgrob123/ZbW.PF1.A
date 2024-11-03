using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB02.A5_1
{
    public partial class A5_1_1 : Form
    {
        public A5_1_1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            PnlFarbe.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            PnlFarbe.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            PnlFarbe.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void CkBxRot_CheckedChanged(object sender, EventArgs e)
        {
            if (trackBar1.Enabled == true)
            {
                trackBar1.Enabled = false;
            }
            else { trackBar1.Enabled = true; }

        }

        private void ChBxGrün_CheckedChanged(object sender, EventArgs e)
        {
            if (trackBar2.Enabled == true)
            {
                trackBar2.Enabled = false;
            }
            else { trackBar2.Enabled = true; }

        }

        private void ChBxBlau_CheckedChanged(object sender, EventArgs e)
        {
            if (trackBar3.Enabled == true)
            {
                trackBar3.Enabled = false;
            }
            else { trackBar3.Enabled = true; }

        }

        private void PnlFarbe_BackColorChanged(object sender, EventArgs e)
        {
            if (RdCmdHex.Checked == true)
            {
                Color myColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
                string hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                LblFrabcode.Text = "#" + hex;
            }
            if (RdCmdHex.Checked == false)
            {
                LblFrabcode.Text = "Rot:" + trackBar1.Value + " Grün: " + trackBar2.Value + " Blau: " + trackBar3.Value;
            }

        }

        private void PnlFarbe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RdCmdDezi_CheckedChanged(object sender, EventArgs e)
        {
            LblFrabcode.Text = "Rot:" + trackBar1.Value + " Grün: " + trackBar2.Value + " Blau: " + trackBar3.Value;
        }

        private void RdCmdHex_CheckedChanged(object sender, EventArgs e)
        {
            Color myColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            string hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            LblFrabcode.Text = "#" + hex;
        }
    }
}
