namespace MB02
{
    partial class A3_1_1
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
            CmdThursday = new Button();
            CmdFriday = new Button();
            CmdSaturday = new Button();
            CmdMonday = new Button();
            CmdTuesday = new Button();
            CmdWednesday = new Button();
            CmdSunday = new Button();
            LblDay = new Label();
            SuspendLayout();
            // 
            // CmdThursday
            // 
            CmdThursday.Location = new Point(35, 56);
            CmdThursday.Name = "CmdThursday";
            CmdThursday.Size = new Size(80, 23);
            CmdThursday.TabIndex = 0;
            CmdThursday.Text = "Thursday";
            CmdThursday.UseVisualStyleBackColor = true;
            CmdThursday.Click += CmdThursday_Click_1;
            // 
            // CmdFriday
            // 
            CmdFriday.Location = new Point(116, 56);
            CmdFriday.Name = "CmdFriday";
            CmdFriday.Size = new Size(80, 23);
            CmdFriday.TabIndex = 0;
            CmdFriday.Text = "Friday";
            CmdFriday.UseVisualStyleBackColor = true;
            CmdFriday.Click += CmdFriday_Click_1;
            // 
            // CmdSaturday
            // 
            CmdSaturday.Location = new Point(197, 56);
            CmdSaturday.Name = "CmdSaturday";
            CmdSaturday.Size = new Size(80, 23);
            CmdSaturday.TabIndex = 0;
            CmdSaturday.Text = "Saturday";
            CmdSaturday.UseVisualStyleBackColor = true;
            CmdSaturday.Click += this.CmdSaturday_Click_1;
            // 
            // CmdMonday
            // 
            CmdMonday.Location = new Point(35, 27);
            CmdMonday.Name = "CmdMonday";
            CmdMonday.Size = new Size(80, 23);
            CmdMonday.TabIndex = 0;
            CmdMonday.Text = "Monday";
            CmdMonday.UseVisualStyleBackColor = true;
            CmdMonday.Click += CmdMonday_Click_1;
            // 
            // CmdTuesday
            // 
            CmdTuesday.Location = new Point(116, 27);
            CmdTuesday.Name = "CmdTuesday";
            CmdTuesday.Size = new Size(80, 23);
            CmdTuesday.TabIndex = 0;
            CmdTuesday.Text = "Tuesday";
            CmdTuesday.UseVisualStyleBackColor = true;
            CmdTuesday.Click += CmdTuesday_Click_1;
            // 
            // CmdWednesday
            // 
            CmdWednesday.Location = new Point(197, 27);
            CmdWednesday.Name = "CmdWednesday";
            CmdWednesday.Size = new Size(80, 23);
            CmdWednesday.TabIndex = 0;
            CmdWednesday.Text = "Wednesday";
            CmdWednesday.UseVisualStyleBackColor = true;
            CmdWednesday.Click += CmdWednesday_Click_1;
            // 
            // CmdSunday
            // 
            CmdSunday.Location = new Point(116, 85);
            CmdSunday.Name = "CmdSunday";
            CmdSunday.Size = new Size(80, 23);
            CmdSunday.TabIndex = 0;
            CmdSunday.Text = "Sunday";
            CmdSunday.UseVisualStyleBackColor = true;
            CmdSunday.Click += this.CmdSunday_Click_1;
            // 
            // LblDay
            // 
            LblDay.AutoSize = true;
            LblDay.Location = new Point(35, 143);
            LblDay.Name = "LblDay";
            LblDay.Size = new Size(153, 15);
            LblDay.TabIndex = 1;
            LblDay.Text = "Nummerischer Wochentag:";
            // 
            // A3_1_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 281);
            Controls.Add(LblDay);
            Controls.Add(CmdSunday);
            Controls.Add(CmdWednesday);
            Controls.Add(CmdSaturday);
            Controls.Add(CmdTuesday);
            Controls.Add(CmdFriday);
            Controls.Add(CmdMonday);
            Controls.Add(CmdThursday);
            Name = "A3_1_1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdThursday;
        private Button CmdFriday;
        private Button CmdSaturday;
        private Button CmdMonday;
        private Button CmdTuesday;
        private Button CmdWednesday;
        private Button CmdSunday;
        private Label LblDay;
    }
}
