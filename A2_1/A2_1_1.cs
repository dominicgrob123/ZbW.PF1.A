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
    public partial class A2_1_1 : Form
    {
        public A2_1_1()
        {
            InitializeComponent();
        }

        private void CmdAusgabe_Click(object sender, EventArgs e)
        {
            LblAusgabe.Text = TxtFirstname.Text + " " + TxtLastname.Text;
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            TxtFirstname.Text = string.Empty;
            TxtLastname.Text = string.Empty;
            LblAusgabe.Text = "...";
        }
    }
}
