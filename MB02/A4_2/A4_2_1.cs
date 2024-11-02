using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB02.A4_2
{
    public partial class A4_2_1 : Form
    {
        public A4_2_1()
        {
            InitializeComponent();
        }

        private void CmdBerechne_Click(object sender, EventArgs e)
        {
            string zahl1 = NumZahl1.Text;
            string zahl2 = NumZahl2.Text;
            if (Convert.ToInt16(zahl1) == Convert.ToInt16(zahl2))
            {
                LblAusgabe1.Text = "Zahl 2 ist gleich gros wie Zahl 1";
                NumZahl1.BackColor = Color.Red;
                NumZahl2.BackColor = Color.Red;
            }
            else if (Convert.ToInt16(zahl1) < Convert.ToInt16(zahl2))
            {
                LblAusgabe2.Text = "Zahl 2 ist grösser!";
                NumZahl2.BackColor = Color.Green;
            }
            else if (Convert.ToInt16(zahl1) > Convert.ToInt16(zahl2))
            {
                LblAusgabe1.Text = "Zahl 1 ist grösser!";
                NumZahl1.BackColor = Color.Green;
            }
        }

        private void NumZahl2_ValueChanged(object sender, EventArgs e)
        {
            NumZahl2.BackColor = Color.White;
            NumZahl1.BackColor = Color.White;
            LblAusgabe1.Text = string.Empty;
            LblAusgabe2.Text = string.Empty;
        }

        private void NumZahl1_ValueChanged(object sender, EventArgs e)
        {
            NumZahl2.BackColor = Color.White;
            NumZahl1.BackColor = Color.White;
            LblAusgabe1.Text = string.Empty;
            LblAusgabe2.Text = string.Empty;
        }
    }
}
