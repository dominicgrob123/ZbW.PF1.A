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
    public partial class A2_1_2 : Form
    {
        public A2_1_2()
        {
            InitializeComponent();
        }

        private void CmdAusgabe_Click(object sender, EventArgs e)
        {
            LblAusgabe.Text = TxtFirstname.Text + " " + TxtLastname.Text + " " + NumAlter.Value;
        }

        private void CmdLöschen_Click(object sender, EventArgs e)
        {
            TxtFirstname.Text = string.Empty;
            TxtLastname.Text = string.Empty;
            NumAlter.Value = 0; 
            LblAusgabe.Text = "...";
        }
    }
}
