namespace MB01.A2_1
{
    partial class A2_1_3
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
            TxtZahl1 = new TextBox();
            TxtZahl2 = new TextBox();
            TxtResultat = new TextBox();
            LblZahl1 = new Label();
            LblZahl2 = new Label();
            LblResultat = new Label();
            CmdPlus = new Button();
            CmdMinus = new Button();
            CmdMal = new Button();
            Cmddurch = new Button();
            SuspendLayout();
            // 
            // TxtZahl1
            // 
            TxtZahl1.Location = new Point(94, 30);
            TxtZahl1.Name = "TxtZahl1";
            TxtZahl1.Size = new Size(216, 23);
            TxtZahl1.TabIndex = 0;
            // 
            // TxtZahl2
            // 
            TxtZahl2.Location = new Point(94, 59);
            TxtZahl2.Name = "TxtZahl2";
            TxtZahl2.Size = new Size(216, 23);
            TxtZahl2.TabIndex = 0;
            // 
            // TxtResultat
            // 
            TxtResultat.Location = new Point(94, 101);
            TxtResultat.Name = "TxtResultat";
            TxtResultat.ReadOnly = true;
            TxtResultat.Size = new Size(216, 23);
            TxtResultat.TabIndex = 0;
            // 
            // LblZahl1
            // 
            LblZahl1.AutoSize = true;
            LblZahl1.Location = new Point(29, 38);
            LblZahl1.Name = "LblZahl1";
            LblZahl1.Size = new Size(42, 15);
            LblZahl1.TabIndex = 1;
            LblZahl1.Text = "Zahl 1:";
            // 
            // LblZahl2
            // 
            LblZahl2.AutoSize = true;
            LblZahl2.Location = new Point(29, 67);
            LblZahl2.Name = "LblZahl2";
            LblZahl2.Size = new Size(42, 15);
            LblZahl2.TabIndex = 1;
            LblZahl2.Text = "Zahl 2:";
            // 
            // LblResultat
            // 
            LblResultat.AutoSize = true;
            LblResultat.Location = new Point(29, 104);
            LblResultat.Name = "LblResultat";
            LblResultat.Size = new Size(55, 15);
            LblResultat.TabIndex = 1;
            LblResultat.Text = "Resultat: ";
            // 
            // CmdPlus
            // 
            CmdPlus.Location = new Point(57, 143);
            CmdPlus.Name = "CmdPlus";
            CmdPlus.Size = new Size(50, 50);
            CmdPlus.TabIndex = 2;
            CmdPlus.Text = "+";
            CmdPlus.UseVisualStyleBackColor = true;
            CmdPlus.Click += CmdPlus_Click;
            // 
            // CmdMinus
            // 
            CmdMinus.Location = new Point(113, 143);
            CmdMinus.Name = "CmdMinus";
            CmdMinus.Size = new Size(50, 50);
            CmdMinus.TabIndex = 2;
            CmdMinus.Text = "-";
            CmdMinus.UseVisualStyleBackColor = true;
            CmdMinus.Click += CmdMinus_Click;
            // 
            // CmdMal
            // 
            CmdMal.Location = new Point(169, 143);
            CmdMal.Name = "CmdMal";
            CmdMal.Size = new Size(50, 50);
            CmdMal.TabIndex = 2;
            CmdMal.Text = "*";
            CmdMal.UseVisualStyleBackColor = true;
            CmdMal.Click += CmdMal_Click;
            // 
            // Cmddurch
            // 
            Cmddurch.Location = new Point(225, 143);
            Cmddurch.Name = "Cmddurch";
            Cmddurch.Size = new Size(50, 50);
            Cmddurch.TabIndex = 2;
            Cmddurch.Text = "/";
            Cmddurch.UseVisualStyleBackColor = true;
            Cmddurch.Click += Cmddurch_Click;
            // 
            // A2_1_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 227);
            Controls.Add(Cmddurch);
            Controls.Add(CmdMal);
            Controls.Add(CmdMinus);
            Controls.Add(CmdPlus);
            Controls.Add(LblResultat);
            Controls.Add(LblZahl2);
            Controls.Add(LblZahl1);
            Controls.Add(TxtResultat);
            Controls.Add(TxtZahl2);
            Controls.Add(TxtZahl1);
            Name = "A2_1_3";
            Text = "A2_1_3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtZahl1;
        private TextBox TxtZahl2;
        private TextBox TxtResultat;
        private Label LblZahl1;
        private Label LblZahl2;
        private Label LblResultat;
        private Button CmdPlus;
        private Button CmdMinus;
        private Button CmdMal;
        private Button Cmddurch;
    }
}