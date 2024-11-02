using MB02.A4_2;
namespace MB02.A4_2
{
    partial class A4_2_2
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
            GrpBox = new GroupBox();
            TxtRed = new TextBox();
            TxtGreen = new TextBox();
            TxtYellow = new TextBox();
            CmdSchalten = new Button();
            GrpBox.SuspendLayout();
            SuspendLayout();
            // 
            // GrpBox
            // 
            GrpBox.BackColor = SystemColors.ActiveBorder;
            GrpBox.Controls.Add(TxtRed);
            GrpBox.Controls.Add(TxtGreen);
            GrpBox.Controls.Add(TxtYellow);
            GrpBox.Location = new Point(85, 55);
            GrpBox.Name = "GrpBox";
            GrpBox.Size = new Size(98, 177);
            GrpBox.TabIndex = 1;
            GrpBox.TabStop = false;
            // 
            // TxtRed
            // 
            TxtRed.BackColor = Color.FromArgb(192, 0, 0);
            TxtRed.Location = new Point(28, 22);
            TxtRed.Multiline = true;
            TxtRed.Name = "TxtRed";
            TxtRed.ReadOnly = true;
            TxtRed.Size = new Size(40, 40);
            TxtRed.TabIndex = 4;
            // 
            // TxtGreen
            // 
            TxtGreen.BackColor = Color.FromArgb(64, 64, 64);
            TxtGreen.Location = new Point(28, 114);
            TxtGreen.Multiline = true;
            TxtGreen.Name = "TxtGreen";
            TxtGreen.ReadOnly = true;
            TxtGreen.Size = new Size(40, 40);
            TxtGreen.TabIndex = 2;
            // 
            // TxtYellow
            // 
            TxtYellow.BackColor = Color.FromArgb(64, 64, 64);
            TxtYellow.Location = new Point(28, 68);
            TxtYellow.Multiline = true;
            TxtYellow.Name = "TxtYellow";
            TxtYellow.ReadOnly = true;
            TxtYellow.Size = new Size(40, 40);
            TxtYellow.TabIndex = 3;
            // 
            // CmdSchalten
            // 
            CmdSchalten.Location = new Point(85, 247);
            CmdSchalten.Name = "CmdSchalten";
            CmdSchalten.Size = new Size(98, 34);
            CmdSchalten.TabIndex = 5;
            CmdSchalten.Text = "Schalten";
            CmdSchalten.UseVisualStyleBackColor = true;
            CmdSchalten.Click += CmdSchalten_Click;
            // 
            // A4_2_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 374);
            Controls.Add(CmdSchalten);
            Controls.Add(GrpBox);
            Name = "A4_2_2";
            Text = "A4_2_2";
            GrpBox.ResumeLayout(false);
            GrpBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox GrpBox;
        private TextBox TxtRed;
        private TextBox TxtGreen;
        private TextBox TxtYellow;
        private Button CmdSchalten;
    }
}