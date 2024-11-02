namespace MB02
{
    enum DayOfWeek
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    public partial class A3_1_1 : Form
    {
        const string textForLabel = ". Tag der Woche";
        public A3_1_1()
        {
            InitializeComponent();
        }
        private void CmdMonday_Click_1(object sender, EventArgs e)
        {
            LblDay.Text = (int)DayOfWeek.Monday + textForLabel;
        }
        private void CmdTuesday_Click_1(object sender, EventArgs e)
        {
            LblDay.Text = (int)DayOfWeek.Tuesday + textForLabel;
        }
        private void CmdWednesday_Click_1(object sender, EventArgs e)
        {
            LblDay.Text = (int)DayOfWeek.Wednesday + textForLabel;
        }

        private void CmdThursday_Click_1(object sender, EventArgs e)
        {
            LblDay.Text = (int)DayOfWeek.Thursday + textForLabel;
        }

        private void CmdFriday_Click_1(object sender, EventArgs e)
        {
            LblDay.Text = (int)DayOfWeek.Friday + textForLabel;
        }

        private void CmdSaturday_Click_1(object sender, EventArgs e)
        {
            LblDay.Text = (int)DayOfWeek.Saturday + textForLabel;
        }

        private void CmdSunday_Click_1(object sender, EventArgs e)
        {
            LblDay.Text = (int)DayOfWeek.Sunday + textForLabel;
        }
    }
}
