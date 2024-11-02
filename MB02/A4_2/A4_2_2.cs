using MB02.A4_2;
using System.Diagnostics.Eventing.Reader;
namespace MB02.A4_2
{
    public partial class A4_2_2 : Form
    {
        int counter_ampel = 0;
        public A4_2_2()
        {
            InitializeComponent();
            
        }

        private void CmdSchalten_Click(object sender, EventArgs e)
        {
            if (counter_ampel == 0)
            {
                TxtYellow.BackColor = Color.Orange;
                counter_ampel++;
            }
            else if (counter_ampel == 1)
            {
                TxtRed.BackColor = Color.Gray;
                TxtYellow.BackColor = Color.Gray;
                TxtGreen.BackColor = Color.Green;
                counter_ampel++;
            }
            else if (counter_ampel == 2)
            {
                TxtGreen.BackColor = Color.Gray;
                TxtYellow.BackColor = Color.Orange;
                counter_ampel++;
            }
            else if (counter_ampel == 3)
            {
                TxtRed.BackColor = Color.Red;
                TxtYellow.BackColor = Color.Gray;
                counter_ampel = 0;
            }

        }
    }


}
