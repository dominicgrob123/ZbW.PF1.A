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
    public partial class A5_1_3 : Form
    {
        int leben = 3;
        Random r = new Random();
        bool x = true;
        int punkte = 0;

        public A5_1_3()
        {
            InitializeComponent();
        }
        private void A5_1_3_Load(object sender, EventArgs e)
        {
            int zielpunkte = r.Next(5000, 10000);
            LblZiel.Text = "Ziel: " + zielpunkte;
            LblLeben.Text = "Leben: " + leben;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            panel2.Location = new Point(panel2.Location.X, 383 - trackBar1.Value);
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            CmdStart.Visible = false;
            panel1.Location = new Point(33, r.Next(0, 460));
            panel1.Visible = true;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Location = new Point(panel1.Location.X + 5, panel1.Location.Y);
            if (leben <= 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Sie haben verloren");
                Environment.Exit(0);
            }
            if (punkte >= 10000)
            {
                timer1.Enabled = false;
                MessageBox.Show("Sie haben gewonnen");
                Environment.Exit(0);
            }

        }

        private void panel1_LocationChanged(object sender, EventArgs e)
        {
            if (panel1.Bounds.IntersectsWith(panel2.Bounds))
            {
                timer1.Interval = r.Next(1, 5);
                panel1.Location = new Point(33, r.Next(0, 460));
                punkte += 100;
                LblPunkte.Text = "Punkte:" + punkte;
            }
            else if (panel1.Bounds.IntersectsWith(trackBar1.Bounds))
            {
                timer1.Interval = r.Next(1, 5);
                panel1.Location = new Point(33, r.Next(0, 460));
                punkte -= 150;
                LblPunkte.Text = "Punkte:" + punkte;
                leben -= 1;
                LblLeben.Text = "Leben: " + leben;
            }
        }
    }
}
