namespace MB02.A5_1
{
    partial class A5_1_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            CmdStart = new Button();
            trackBar1 = new TrackBar();
            timer1 = new System.Windows.Forms.Timer(components);
            LblSpeed = new Label();
            Pnl = new Panel();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // CmdStart
            // 
            CmdStart.Location = new Point(21, 27);
            CmdStart.Name = "CmdStart";
            CmdStart.Size = new Size(75, 23);
            CmdStart.TabIndex = 0;
            CmdStart.Text = "Start";
            CmdStart.UseVisualStyleBackColor = true;
            CmdStart.Click += CmdStart_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(21, 85);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 10;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(458, 45);
            trackBar1.TabIndex = 1;
            trackBar1.Value = 10;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // LblSpeed
            // 
            LblSpeed.AutoSize = true;
            LblSpeed.Location = new Point(21, 67);
            LblSpeed.Name = "LblSpeed";
            LblSpeed.Size = new Size(87, 15);
            LblSpeed.TabIndex = 3;
            LblSpeed.Text = "Geschwindikeit";
            // 
            // Pnl
            // 
            Pnl.BackColor = Color.Lime;
            Pnl.Location = new Point(0, 184);
            Pnl.Name = "Pnl";
            Pnl.Size = new Size(29, 23);
            Pnl.TabIndex = 4;
            Pnl.Paint += Pnl_Paint;
            // 
            // A5_1_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 295);
            Controls.Add(Pnl);
            Controls.Add(LblSpeed);
            Controls.Add(trackBar1);
            Controls.Add(CmdStart);
            Name = "A5_1_2";
            Text = "A5_1_2";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdStart;
        private TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
        private Label LblSpeed;
        private Panel Pnl;
    }
}