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
    public partial class A4_2_3 : Form
    {
        public A4_2_3()
        {
            InitializeComponent();
        }

        private void CmdZeichne_Click(object sender, EventArgs e)
        {
            int länge = Convert.ToInt32(TxtLänge.Text);
            int breite = Convert.ToInt32(TxtBreite.Text);

            if (länge == breite)
            {
                PnlBLue.BackColor = Color.Violet;
                LblQuadrat.Visible = true;

            }
            else
            {
                PnlBLue.BackColor = Color.DeepSkyBlue;
                LblQuadrat.Visible = false;
            }

            if (länge < 50 || länge > 200)
            {
                MessageBox.Show("Länge muss > 50 und > 200 sein");
            }
            else if (breite < 50 || breite > 200)
            {
                MessageBox.Show("Breite muss > 50 und > 200 sein");
            }
            PnlBLue.Size = new System.Drawing.Size(länge, breite);
            LblBreitePanel.Location = new Point(315 + länge + 6, 41 + (breite / 2) - 7);
            LblBreitePanel.Text = breite + " cm";
            /*315 X Location Panel oben links
             * 41 Y Location Panel oben links
             * +6 Abstand LblBreitePanel zu Panel
             * -7 Hälfte von LblBreite weil Location immer oben links ist
             * -22 Hälfte von LblLänge weil Location immer oben links ist
             * */
            LblLängePanel.Location = new Point(315 + (länge / 2) - 22, 23);
            LblLängePanel.Text = länge + " cm";
            LblQuadrat.Location = new Point(315 + (länge / 2) - 26, 41 + (breite));
        }
    }
}
