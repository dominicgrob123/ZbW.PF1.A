namespace MB01
{
    public partial class A1_2_1 : Form
    {
        public A1_2_1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LblGelb.Text = "Gelbe Hintergrundfarbe";
            LblGelb.BackColor = Color.FromArgb(255, 255, 0);
        }

        private void CmdRot_Click(object sender, EventArgs e)
        {
            LblRot.Text = "Rote Hintergrundfarbe";
            LblRot.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void CmdGrün_Click(object sender, EventArgs e)
        {
            LblGrün.Text = "Grüne Hintergrundfarbe";
            LblGrün.BackColor = Color.FromArgb(0, 255, 0);
        }

        private void CmdBlau_Click(object sender, EventArgs e)
        {
            LblBlau.Text = "Blaue Hintergrundfarbe";
            LblBlau.BackColor = Color.FromArgb(0, 0, 255);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
