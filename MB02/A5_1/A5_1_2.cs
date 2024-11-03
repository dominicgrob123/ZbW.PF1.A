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
    public partial class A5_1_2 : Form

    {
        int richtung = 0;
        public A5_1_2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int locx = Pnl.Location.X;
            int locy = Pnl.Location.Y;
            int formWidth = ClientRectangle.Width;
            if (locx <= 0)
            {
                richtung = 0;
            }
            if (locx >= (formWidth - (Pnl.Size.Width)))
            {
                richtung = 1;
            }
            if (richtung == 0)
            {
                Pnl.Location = new Point(locx + 1, locy);
                locx = Pnl.Location.X;
            }
            else if (richtung == 1)
            {
                Pnl.Location = new Point(locx - 1, locy);
                locx = Pnl.Location.X;
            }
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                CmdStart.Text = "Start";
            }
            else
            {
                timer1.Start();
                CmdStart.Text = "Stop";
            }
        }

        private void Pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
