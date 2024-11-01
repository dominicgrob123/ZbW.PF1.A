namespace MB01.A1_2
{
    partial class A1_2_4cs
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
            CmdBiggerHeight = new Button();
            CmdSmallerHeight = new Button();
            CmdBiggerWidth = new Button();
            CmdSmallerWidth = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // CmdBiggerHeight
            // 
            CmdBiggerHeight.Location = new Point(29, 41);
            CmdBiggerHeight.Name = "CmdBiggerHeight";
            CmdBiggerHeight.Size = new Size(235, 23);
            CmdBiggerHeight.TabIndex = 0;
            CmdBiggerHeight.Text = "Bigger Heigth";
            CmdBiggerHeight.UseVisualStyleBackColor = true;
            // 
            // CmdSmallerHeight
            // 
            CmdSmallerHeight.Location = new Point(29, 70);
            CmdSmallerHeight.Name = "CmdSmallerHeight";
            CmdSmallerHeight.Size = new Size(235, 23);
            CmdSmallerHeight.TabIndex = 0;
            CmdSmallerHeight.Text = "Smaller Height";
            CmdSmallerHeight.UseVisualStyleBackColor = true;
            // 
            // CmdBiggerWidth
            // 
            CmdBiggerWidth.Location = new Point(29, 99);
            CmdBiggerWidth.Name = "CmdBiggerWidth";
            CmdBiggerWidth.Size = new Size(235, 23);
            CmdBiggerWidth.TabIndex = 0;
            CmdBiggerWidth.Text = "Bigger Width";
            CmdBiggerWidth.UseVisualStyleBackColor = true;
            // 
            // CmdSmallerWidth
            // 
            CmdSmallerWidth.Location = new Point(29, 128);
            CmdSmallerWidth.Name = "CmdSmallerWidth";
            CmdSmallerWidth.Size = new Size(235, 23);
            CmdSmallerWidth.TabIndex = 0;
            CmdSmallerWidth.Text = "Smaller Width";
            CmdSmallerWidth.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 426);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 426);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Position:";
            // 
            // A1_2_4cs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CmdSmallerWidth);
            Controls.Add(CmdBiggerWidth);
            Controls.Add(CmdSmallerHeight);
            Controls.Add(CmdBiggerHeight);
            Name = "A1_2_4cs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A1_2_4cs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdBiggerHeight;
        private Button CmdSmallerHeight;
        private Button CmdBiggerWidth;
        private Button CmdSmallerWidth;
        private Label label1;
        private Label label2;
    }
}