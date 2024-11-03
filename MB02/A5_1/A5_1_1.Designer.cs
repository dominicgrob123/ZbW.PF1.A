namespace MB02.A5_1
{
    partial class A5_1_1
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
            PnlFarbe = new Panel();
            CkBxRot = new CheckBox();
            ChBxGrün = new CheckBox();
            ChBxBlau = new CheckBox();
            LblRot = new Label();
            LblGrün = new Label();
            LblFrabcode = new Label();
            LblBlau = new Label();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            RdCmdHex = new RadioButton();
            RdCmdDezi = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            SuspendLayout();
            // 
            // PnlFarbe
            // 
            PnlFarbe.Location = new Point(109, 198);
            PnlFarbe.Name = "PnlFarbe";
            PnlFarbe.Size = new Size(344, 100);
            PnlFarbe.TabIndex = 0;
            PnlFarbe.BackColorChanged += PnlFarbe_BackColorChanged;
            PnlFarbe.Paint += PnlFarbe_Paint;
            // 
            // CkBxRot
            // 
            CkBxRot.AutoSize = true;
            CkBxRot.Location = new Point(440, 29);
            CkBxRot.Name = "CkBxRot";
            CkBxRot.Size = new Size(15, 14);
            CkBxRot.TabIndex = 1;
            CkBxRot.UseVisualStyleBackColor = true;
            CkBxRot.CheckedChanged += CkBxRot_CheckedChanged;
            // 
            // ChBxGrün
            // 
            ChBxGrün.AutoSize = true;
            ChBxGrün.Location = new Point(440, 89);
            ChBxGrün.Name = "ChBxGrün";
            ChBxGrün.Size = new Size(15, 14);
            ChBxGrün.TabIndex = 1;
            ChBxGrün.UseVisualStyleBackColor = true;
            ChBxGrün.CheckedChanged += ChBxGrün_CheckedChanged;
            // 
            // ChBxBlau
            // 
            ChBxBlau.AutoSize = true;
            ChBxBlau.Location = new Point(440, 149);
            ChBxBlau.Name = "ChBxBlau";
            ChBxBlau.Size = new Size(15, 14);
            ChBxBlau.TabIndex = 1;
            ChBxBlau.UseVisualStyleBackColor = true;
            ChBxBlau.CheckedChanged += ChBxBlau_CheckedChanged;
            // 
            // LblRot
            // 
            LblRot.AutoSize = true;
            LblRot.Location = new Point(41, 29);
            LblRot.Name = "LblRot";
            LblRot.Size = new Size(28, 15);
            LblRot.TabIndex = 2;
            LblRot.Text = "Rot:";
            // 
            // LblGrün
            // 
            LblGrün.AutoSize = true;
            LblGrün.Location = new Point(41, 88);
            LblGrün.Name = "LblGrün";
            LblGrün.Size = new Size(36, 15);
            LblGrün.TabIndex = 2;
            LblGrün.Text = "Grün:";
            // 
            // LblFrabcode
            // 
            LblFrabcode.AutoSize = true;
            LblFrabcode.Location = new Point(109, 311);
            LblFrabcode.Name = "LblFrabcode";
            LblFrabcode.Size = new Size(50, 15);
            LblFrabcode.TabIndex = 2;
            LblFrabcode.Text = "#000000";
            // 
            // LblBlau
            // 
            LblBlau.AutoSize = true;
            LblBlau.Location = new Point(41, 148);
            LblBlau.Name = "LblBlau";
            LblBlau.Size = new Size(33, 15);
            LblBlau.TabIndex = 2;
            LblBlau.Text = "Blau:";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(95, 25);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(339, 45);
            trackBar1.TabIndex = 3;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(95, 87);
            trackBar2.Maximum = 255;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(339, 45);
            trackBar2.TabIndex = 3;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(95, 147);
            trackBar3.Maximum = 255;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(339, 45);
            trackBar3.TabIndex = 3;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // RdCmdHex
            // 
            RdCmdHex.AutoSize = true;
            RdCmdHex.Checked = true;
            RdCmdHex.Location = new Point(109, 347);
            RdCmdHex.Name = "RdCmdHex";
            RdCmdHex.Size = new Size(93, 19);
            RdCmdHex.TabIndex = 4;
            RdCmdHex.TabStop = true;
            RdCmdHex.Text = "Hexadezimal";
            RdCmdHex.UseVisualStyleBackColor = true;
            RdCmdHex.CheckedChanged += RdCmdHex_CheckedChanged;
            // 
            // RdCmdDezi
            // 
            RdCmdDezi.AutoSize = true;
            RdCmdDezi.Location = new Point(209, 347);
            RdCmdDezi.Name = "RdCmdDezi";
            RdCmdDezi.Size = new Size(67, 19);
            RdCmdDezi.TabIndex = 5;
            RdCmdDezi.TabStop = true;
            RdCmdDezi.Text = "Dezimal";
            RdCmdDezi.UseVisualStyleBackColor = true;
            RdCmdDezi.CheckedChanged += RdCmdDezi_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 55);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 6;
            label1.Text = "   0";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 177);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 6;
            label2.Text = "  0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 117);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 6;
            label3.Text = "  0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 55);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 7;
            label4.Text = "128";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(251, 117);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 7;
            label5.Text = "128";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(251, 177);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 7;
            label6.Text = "128";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(409, 55);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 7;
            label7.Text = "255";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(409, 117);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 7;
            label8.Text = "255";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(409, 177);
            label9.Name = "label9";
            label9.Size = new Size(25, 15);
            label9.TabIndex = 7;
            label9.Text = "255";
            // 
            // A5_1_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RdCmdDezi);
            Controls.Add(RdCmdHex);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(LblBlau);
            Controls.Add(LblFrabcode);
            Controls.Add(LblGrün);
            Controls.Add(LblRot);
            Controls.Add(ChBxBlau);
            Controls.Add(ChBxGrün);
            Controls.Add(CkBxRot);
            Controls.Add(PnlFarbe);
            Name = "A5_1_1";
            Text = "A5_1_1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlFarbe;
        private CheckBox CkBxRot;
        private CheckBox ChBxGrün;
        private CheckBox ChBxBlau;
        private Label LblRot;
        private Label LblGrün;
        private Label LblFrabcode;
        private Label LblBlau;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private RadioButton RdCmdHex;
        private RadioButton RdCmdDezi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}