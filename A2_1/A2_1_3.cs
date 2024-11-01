using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB01.A2_1
{
    public partial class A2_1_3 : Form
    {
        public A2_1_3()
        {
            InitializeComponent();
        }

        private void CmdPlus_Click(object sender, EventArgs e)
        {
            int zahl_1 = Convert.ToInt16(TxtZahl1.Text);
            int zahl_2 = Convert.ToInt16(TxtZahl2.Text);
            TxtResultat.Text = Convert.ToString(zahl_1 + zahl_2);
        }

        private void CmdMinus_Click(object sender, EventArgs e)
        {
            int zahl_1 = Convert.ToInt16(TxtZahl1.Text);
            int zahl_2 = Convert.ToInt16(TxtZahl2.Text);
            TxtResultat.Text = Convert.ToString(zahl_1 - zahl_2);
        }

        private void CmdMal_Click(object sender, EventArgs e)
        {
            int zahl_1 = Convert.ToInt16(TxtZahl1.Text);
            int zahl_2 = Convert.ToInt16(TxtZahl2.Text);
            TxtResultat.Text = Convert.ToString(zahl_1 * zahl_2);
        }

        private void Cmddurch_Click(object sender, EventArgs e)
        {
            int zahl_1 = Convert.ToInt16(TxtZahl1.Text);
            int zahl_2 = Convert.ToInt16(TxtZahl2.Text);
            TxtResultat.Text = Convert.ToString(zahl_1 / zahl_2);
        }
    }
}
