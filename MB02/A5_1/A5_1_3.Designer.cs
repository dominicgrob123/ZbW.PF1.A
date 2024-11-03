namespace MB02.A5_1
{
    partial class A5_1_3
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
            panel1 = new Panel();
            panel2 = new Panel();
            trackBar1 = new TrackBar();
            LblLeben = new Label();
            LblPunkte = new Label();
            LblZiel = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Location = new Point(33, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(20, 20);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 0);
            panel2.Location = new Point(367, 383);
            panel2.Name = "panel2";
            panel2.Size = new Size(20, 80);
            panel2.TabIndex = 1;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(427, 3);
            trackBar1.Maximum = 383;
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(45, 450);
            trackBar1.TabIndex = 2;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // LblLeben
            // 
            LblLeben.AutoSize = true;
            LblLeben.Location = new Point(12, 9);
            LblLeben.Name = "LblLeben";
            LblLeben.Size = new Size(42, 15);
            LblLeben.TabIndex = 3;
            LblLeben.Text = "Leben:";
            // 
            // LblPunkte
            // 
            LblPunkte.AutoSize = true;
            LblPunkte.Location = new Point(118, 9);
            LblPunkte.Name = "LblPunkte";
            LblPunkte.Size = new Size(47, 15);
            LblPunkte.TabIndex = 4;
            LblPunkte.Text = "Punkte:";
            // 
            // LblZiel
            // 
            LblZiel.AutoSize = true;
            LblZiel.Location = new Point(259, 9);
            LblZiel.Name = "LblZiel";
            LblZiel.Size = new Size(29, 15);
            LblZiel.TabIndex = 5;
            LblZiel.Text = "Ziel:";
            // 
            // A5_1_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(484, 461);
            Controls.Add(LblZiel);
            Controls.Add(LblPunkte);
            Controls.Add(LblLeben);
            Controls.Add(trackBar1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "A5_1_3";
            Text = "A5_1_3";
            Load += A5_1_3_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TrackBar trackBar1;
        private Label LblLeben;
        private Label LblPunkte;
        private Label LblZiel;
    }
}