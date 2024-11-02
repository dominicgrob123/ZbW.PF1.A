using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB02.A3_1
{ 
    enum Months
    { 
    Januar = 1, Februar, März, April, Mai, Juni, July, August,
    September, Oktober, November, Dezember
    }

    public partial class A3_1_2 : Form
    {
        public A3_1_2()
        {
            InitializeComponent();
            TxtSolution.Text = Convert.ToString((Months)(Convert.ToInt32(NumZahl.Value)));
        }

        private void NumZahl_ValueChanged(object sender, EventArgs e)
        {
            TxtSolution.Text = Convert.ToString((Months)(Convert.ToInt32(NumZahl.Value)));
        }
    }
}
