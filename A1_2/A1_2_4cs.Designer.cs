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
            LblDimension = new Label();
            LblPosition = new Label();
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
            CmdBiggerHeight.Click += CmdBiggerHeight_Click;
            // 
            // CmdSmallerHeight
            // 
            CmdSmallerHeight.Location = new Point(29, 70);
            CmdSmallerHeight.Name = "CmdSmallerHeight";
            CmdSmallerHeight.Size = new Size(235, 23);
            CmdSmallerHeight.TabIndex = 0;
            CmdSmallerHeight.Text = "Smaller Height";
            CmdSmallerHeight.UseVisualStyleBackColor = true;
            CmdSmallerHeight.Click += CmdSmallerHeight_Click;
            // 
            // CmdBiggerWidth
            // 
            CmdBiggerWidth.Location = new Point(29, 99);
            CmdBiggerWidth.Name = "CmdBiggerWidth";
            CmdBiggerWidth.Size = new Size(235, 23);
            CmdBiggerWidth.TabIndex = 0;
            CmdBiggerWidth.Text = "Bigger Width";
            CmdBiggerWidth.UseVisualStyleBackColor = true;
            CmdBiggerWidth.Click += CmdBiggerWidth_Click;
            // 
            // CmdSmallerWidth
            // 
            CmdSmallerWidth.Location = new Point(29, 128);
            CmdSmallerWidth.Name = "CmdSmallerWidth";
            CmdSmallerWidth.Size = new Size(235, 23);
            CmdSmallerWidth.TabIndex = 0;
            CmdSmallerWidth.Text = "Smaller Width";
            CmdSmallerWidth.UseVisualStyleBackColor = true;
            CmdSmallerWidth.Click += CmdSmallerWidth_Click;
            // 
            // LblDimension
            // 
            LblDimension.AutoSize = true;
            LblDimension.Location = new Point(176, 426);
            LblDimension.Name = "LblDimension";
            LblDimension.Size = new Size(67, 15);
            LblDimension.TabIndex = 1;
            LblDimension.Text = "Dimension:";
            // 
            // LblPosition
            // 
            LblPosition.AutoSize = true;
            LblPosition.Location = new Point(12, 426);
            LblPosition.Name = "LblPosition";
            LblPosition.Size = new Size(53, 15);
            LblPosition.TabIndex = 1;
            LblPosition.Text = "Position:";
            // 
            // A1_2_4cs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 450);
            Controls.Add(LblPosition);
            Controls.Add(LblDimension);
            Controls.Add(CmdSmallerWidth);
            Controls.Add(CmdBiggerWidth);
            Controls.Add(CmdSmallerHeight);
            Controls.Add(CmdBiggerHeight);
            Name = "A1_2_4cs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A1_2_4cs";
            SizeChanged += A1_2_4cs_SizeChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdBiggerHeight;
        private Button CmdSmallerHeight;
        private Button CmdBiggerWidth;
        private Button CmdSmallerWidth;
        private Label LblDimension;
        private Label LblPosition;
    }
}