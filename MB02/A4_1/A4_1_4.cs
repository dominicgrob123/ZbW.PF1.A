using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB02.A4_1
{
    public partial class A4_1_4 : Form
    {
        public A4_1_4()
        {
            InitializeComponent();
        }

        private void CmdCal_Click(object sender, EventArgs e)
        {
            string zahl1 = TxtZahlA.Text;
            string zahl2 = TxtZahlB.Text;
            if(Convert.ToInt16(zahl1) == Convert.ToInt16(zahl2)){ LblOut.Text = "Die Zahlen sind gleich gross"; }
            else if(Convert.ToInt16(zahl1) < Convert.ToInt16(zahl2)){ LblOut.Text = "Die Zahl B ist grösser"; }
            else if(Convert.ToInt16(zahl1) > Convert.ToInt16(zahl2)){ LblOut.Text = "Die Zahl A ist grösser"; }
        }
    }
}
