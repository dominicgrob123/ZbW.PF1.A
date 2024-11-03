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
        public A5_1_3()
        {
            InitializeComponent();
        }
        private void A5_1_3_Load(object sender, EventArgs e)
        {
            int leben = 3;
            Random r = new Random();
            int zielpunkte = r.Next(5000, 10000);
            LblZiel.Text = "Ziel: " + zielpunkte;
            LblLeben.Text = "Leben: " + leben;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            panel2.Location = new Point(panel2.Location.X, 383 - trackBar1.Value);
        }


    }
}
