namespace MB01.A1_2
{
    partial class A1_2_3
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
            CmdUp = new Button();
            Cmdhome = new Button();
            CmdDown = new Button();
            CmdLeft = new Button();
            CmdRight = new Button();
            CmdPoint = new Button();
            SuspendLayout();
            // 
            // CmdUp
            // 
            CmdUp.Location = new Point(322, 12);
            CmdUp.Name = "CmdUp";
            CmdUp.Size = new Size(50, 50);
            CmdUp.TabIndex = 0;
            CmdUp.Text = "up";
            CmdUp.UseVisualStyleBackColor = true;
            CmdUp.Click += CmdUp_Click;
            // 
            // Cmdhome
            // 
            Cmdhome.Location = new Point(322, 68);
            Cmdhome.Name = "Cmdhome";
            Cmdhome.Size = new Size(50, 50);
            Cmdhome.TabIndex = 0;
            Cmdhome.Text = "home";
            Cmdhome.UseVisualStyleBackColor = true;
            Cmdhome.Click += Cmdhome_Click;
            // 
            // CmdDown
            // 
            CmdDown.Location = new Point(322, 124);
            CmdDown.Name = "CmdDown";
            CmdDown.Size = new Size(50, 50);
            CmdDown.TabIndex = 0;
            CmdDown.Text = "down";
            CmdDown.UseVisualStyleBackColor = true;
            CmdDown.Click += CmdDown_Click;
            // 
            // CmdLeft
            // 
            CmdLeft.Location = new Point(266, 68);
            CmdLeft.Name = "CmdLeft";
            CmdLeft.Size = new Size(50, 50);
            CmdLeft.TabIndex = 0;
            CmdLeft.Text = "left";
            CmdLeft.UseVisualStyleBackColor = true;
            CmdLeft.Click += CmdLeft_Click;
            // 
            // CmdRight
            // 
            CmdRight.Location = new Point(378, 68);
            CmdRight.Name = "CmdRight";
            CmdRight.Size = new Size(50, 50);
            CmdRight.TabIndex = 0;
            CmdRight.Text = "right";
            CmdRight.UseVisualStyleBackColor = true;
            CmdRight.Click += CmdRight_Click;
            // 
            // CmdPoint
            // 
            CmdPoint.Location = new Point(322, 271);
            CmdPoint.Name = "CmdPoint";
            CmdPoint.Size = new Size(50, 50);
            CmdPoint.TabIndex = 0;
            CmdPoint.UseVisualStyleBackColor = true;
            // 
            // A1_2_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdPoint);
            Controls.Add(CmdRight);
            Controls.Add(CmdLeft);
            Controls.Add(CmdDown);
            Controls.Add(Cmdhome);
            Controls.Add(CmdUp);
            Name = "A1_2_3";
            Text = "A1_2_3";
            ResumeLayout(false);
        }

        #endregion

        private Button CmdUp;
        private Button Cmdhome;
        private Button CmdDown;
        private Button CmdLeft;
        private Button CmdRight;
        private Button CmdPoint;
    }
}