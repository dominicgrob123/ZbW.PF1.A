namespace MB02.A4_1
{
    partial class A4_1_4
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
            TxtZahlA = new TextBox();
            TxtZahlB = new TextBox();
            LblZahlA = new Label();
            LblZahlB = new Label();
            LblOut = new Label();
            CmdCal = new Button();
            SuspendLayout();
            // 
            // TxtZahlA
            // 
            TxtZahlA.Location = new Point(69, 34);
            TxtZahlA.Name = "TxtZahlA";
            TxtZahlA.Size = new Size(202, 23);
            TxtZahlA.TabIndex = 0;
            TxtZahlA.Text = "0";
            // 
            // TxtZahlB
            // 
            TxtZahlB.Location = new Point(69, 72);
            TxtZahlB.Name = "TxtZahlB";
            TxtZahlB.Size = new Size(202, 23);
            TxtZahlB.TabIndex = 0;
            TxtZahlB.Text = "0";
            // 
            // LblZahlA
            // 
            LblZahlA.AutoSize = true;
            LblZahlA.Location = new Point(25, 37);
            LblZahlA.Name = "LblZahlA";
            LblZahlA.Size = new Size(44, 15);
            LblZahlA.TabIndex = 1;
            LblZahlA.Text = "Zahl A:";
            // 
            // LblZahlB
            // 
            LblZahlB.AutoSize = true;
            LblZahlB.Location = new Point(25, 75);
            LblZahlB.Name = "LblZahlB";
            LblZahlB.Size = new Size(43, 15);
            LblZahlB.TabIndex = 1;
            LblZahlB.Text = "Zahl B:";
            // 
            // LblOut
            // 
            LblOut.AutoSize = true;
            LblOut.Location = new Point(69, 160);
            LblOut.Name = "LblOut";
            LblOut.Size = new Size(0, 15);
            LblOut.TabIndex = 1;
            // 
            // CmdCal
            // 
            CmdCal.Location = new Point(69, 111);
            CmdCal.Name = "CmdCal";
            CmdCal.Size = new Size(202, 23);
            CmdCal.TabIndex = 2;
            CmdCal.Text = "Bestimme grössere Zahl:";
            CmdCal.UseVisualStyleBackColor = true;
            CmdCal.Click += CmdCal_Click;
            // 
            // A4_1_4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdCal);
            Controls.Add(LblOut);
            Controls.Add(LblZahlB);
            Controls.Add(LblZahlA);
            Controls.Add(TxtZahlB);
            Controls.Add(TxtZahlA);
            Name = "A4_1_4";
            Text = "A4_1_4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtZahlA;
        private TextBox TxtZahlB;
        private Label LblZahlA;
        private Label LblZahlB;
        private Label LblOut;
        private Button CmdCal;
    }
}