using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB01.A1_2
{
    public partial class A1_2_3 : Form
    {
        public A1_2_3()
        {
            InitializeComponent();
        }

        private void CmdUp_Click(object sender, EventArgs e)
        {

            CmdPoint.Location = new Point(CmdPoint.Location.X, CmdPoint.Location.Y - 1);
        }

        private void CmdLeft_Click(object sender, EventArgs e)
        {
            CmdPoint.Location = new Point(CmdPoint.Location.X - 1, CmdPoint.Location.Y);
        }

        private void Cmdhome_Click(object sender, EventArgs e)
        {
            CmdPoint.Location = new Point(322, 271);
        }

        private void CmdRight_Click(object sender, EventArgs e)
        {
            CmdPoint.Location = new Point(CmdPoint.Location.X + 1, CmdPoint.Location.Y);
        }

        private void CmdDown_Click(object sender, EventArgs e)
        {
            CmdPoint.Location = new Point(CmdPoint.Location.X, CmdPoint.Location.Y + 1);
        }
    }
}
