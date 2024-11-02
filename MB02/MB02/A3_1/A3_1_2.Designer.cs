namespace MB02.A3_1
{
    partial class A3_1_2
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
            LblZahl = new Label();
            NumZahl = new NumericUpDown();
            TxtSolution = new TextBox();
            ((System.ComponentModel.ISupportInitialize)NumZahl).BeginInit();
            SuspendLayout();
            // 
            // LblZahl
            // 
            LblZahl.AutoSize = true;
            LblZahl.Location = new Point(37, 52);
            LblZahl.Name = "LblZahl";
            LblZahl.Size = new Size(119, 15);
            LblZahl.TabIndex = 0;
            LblZahl.Text = "Wählen Sie eine Zahl:";
            // 
            // NumZahl
            // 
            NumZahl.Location = new Point(159, 50);
            NumZahl.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            NumZahl.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumZahl.Name = "NumZahl";
            NumZahl.Size = new Size(106, 23);
            NumZahl.TabIndex = 2;
            NumZahl.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumZahl.ValueChanged += NumZahl_ValueChanged;
            // 
            // TxtSolution
            // 
            TxtSolution.BackColor = SystemColors.WindowText;
            TxtSolution.ForeColor = Color.White;
            TxtSolution.Location = new Point(37, 105);
            TxtSolution.Name = "TxtSolution";
            TxtSolution.Size = new Size(228, 23);
            TxtSolution.TabIndex = 3;
            // 
            // A3_1_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 450);
            Controls.Add(TxtSolution);
            Controls.Add(NumZahl);
            Controls.Add(LblZahl);
            Name = "A3_1_2";
            Text = "A3_1_2";
            ((System.ComponentModel.ISupportInitialize)NumZahl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblZahl;
        private NumericUpDown NumZahl;
        private TextBox TxtSolution;
    }
}