namespace MB01
{
    partial class A1_2_1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CmdBlau = new Button();
            CmdGrün = new Button();
            CmdRot = new Button();
            CmdGelb = new Button();
            LblGelb = new Label();
            LblRot = new Label();
            LblGrün = new Label();
            LblBlau = new Label();
            SuspendLayout();
            // 
            // CmdBlau
            // 
            CmdBlau.Location = new Point(59, 135);
            CmdBlau.Name = "CmdBlau";
            CmdBlau.Size = new Size(75, 23);
            CmdBlau.TabIndex = 0;
            CmdBlau.Text = "Blau";
            CmdBlau.UseVisualStyleBackColor = true;
            CmdBlau.Click += CmdBlau_Click;
            // 
            // CmdGrün
            // 
            CmdGrün.Location = new Point(59, 106);
            CmdGrün.Name = "CmdGrün";
            CmdGrün.Size = new Size(75, 23);
            CmdGrün.TabIndex = 0;
            CmdGrün.Text = "Grün";
            CmdGrün.UseVisualStyleBackColor = true;
            CmdGrün.Click += CmdGrün_Click;
            // 
            // CmdRot
            // 
            CmdRot.Location = new Point(59, 77);
            CmdRot.Name = "CmdRot";
            CmdRot.Size = new Size(75, 23);
            CmdRot.TabIndex = 0;
            CmdRot.Text = "Rot";
            CmdRot.UseVisualStyleBackColor = true;
            CmdRot.Click += CmdRot_Click;
            // 
            // CmdGelb
            // 
            CmdGelb.Location = new Point(59, 48);
            CmdGelb.Name = "CmdGelb";
            CmdGelb.Size = new Size(75, 23);
            CmdGelb.TabIndex = 0;
            CmdGelb.Text = "Gelb";
            CmdGelb.UseVisualStyleBackColor = true;
            CmdGelb.Click += button4_Click;
            // 
            // LblGelb
            // 
            LblGelb.AutoSize = true;
            LblGelb.Location = new Point(250, 52);
            LblGelb.Name = "LblGelb";
            LblGelb.Size = new Size(0, 15);
            LblGelb.TabIndex = 1;
            // 
            // LblRot
            // 
            LblRot.AutoSize = true;
            LblRot.Location = new Point(250, 81);
            LblRot.Name = "LblRot";
            LblRot.Size = new Size(0, 15);
            LblRot.TabIndex = 1;
            // 
            // LblGrün
            // 
            LblGrün.AutoSize = true;
            LblGrün.Location = new Point(250, 110);
            LblGrün.Name = "LblGrün";
            LblGrün.Size = new Size(0, 15);
            LblGrün.TabIndex = 1;
            // 
            // LblBlau
            // 
            LblBlau.AutoSize = true;
            LblBlau.Location = new Point(250, 139);
            LblBlau.Name = "LblBlau";
            LblBlau.Size = new Size(0, 15);
            LblBlau.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 291);
            Controls.Add(LblBlau);
            Controls.Add(LblGrün);
            Controls.Add(LblRot);
            Controls.Add(LblGelb);
            Controls.Add(CmdRot);
            Controls.Add(CmdGelb);
            Controls.Add(CmdGrün);
            Controls.Add(CmdBlau);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdBlau;
        private Button CmdGrün;
        private Button CmdRot;
        private Button CmdGelb;
        private Label LblGelb;
        private Label LblRot;
        private Label LblGrün;
        private Label LblBlau;
    }
}
