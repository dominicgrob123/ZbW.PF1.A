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
    public partial class A4_2_4 : Form
    {
        public A4_2_4()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdDurchführen_Click(object sender, EventArgs e)
        {
            decimal zahl1 = Convert.ToDecimal(TxtZahl1.Text);
            decimal zahl2 = Convert.ToDecimal(TxtZahl2.Text);

            switch(TxtOp.Text)
            {
                case "+":
                    TxtResult.Text = Convert.ToString(zahl1 + zahl2);
                    break;
                case "-":
                    TxtResult.Text = Convert.ToString(zahl1 - zahl2);
                    break;
                case "*":
                    TxtResult.Text = Convert.ToString(zahl1 * zahl2);
                    break;
                case "/":
                    if (zahl2 == 0)
                        LblResult.Text = "Division durch 0 nicht erlaubt!";
                    else
                        TxtResult.Text = Convert.ToString(zahl1 / zahl2);
                    break;
                default:
                    LblResult.Text = "Falsches Operationszeichen eingegeben!";
                    break;
            }
            
        }
    }
}
