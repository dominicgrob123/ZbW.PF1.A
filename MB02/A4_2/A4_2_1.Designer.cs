namespace MB02.A4_2
{
    partial class A4_2_1
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
            LblZahl2 = new Label();
            LblAusgabe2 = new Label();
            LblZahl1 = new Label();
            LblAusgabe1 = new Label();
            NumZahl2 = new NumericUpDown();
            NumZahl1 = new NumericUpDown();
            CmdBerechne = new Button();
            ((System.ComponentModel.ISupportInitialize)NumZahl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumZahl1).BeginInit();
            SuspendLayout();
            // 
            // LblZahl2
            // 
            LblZahl2.AutoSize = true;
            LblZahl2.Location = new Point(21, 107);
            LblZahl2.Name = "LblZahl2";
            LblZahl2.Size = new Size(42, 15);
            LblZahl2.TabIndex = 0;
            LblZahl2.Text = "Zahl 2:";
            // 
            // LblAusgabe2
            // 
            LblAusgabe2.AutoSize = true;
            LblAusgabe2.Location = new Point(106, 82);
            LblAusgabe2.Name = "LblAusgabe2";
            LblAusgabe2.Size = new Size(0, 15);
            LblAusgabe2.TabIndex = 0;
            // 
            // LblZahl1
            // 
            LblZahl1.AutoSize = true;
            LblZahl1.Location = new Point(21, 53);
            LblZahl1.Name = "LblZahl1";
            LblZahl1.Size = new Size(42, 15);
            LblZahl1.TabIndex = 0;
            LblZahl1.Text = "Zahl 1:";
            // 
            // LblAusgabe1
            // 
            LblAusgabe1.AutoSize = true;
            LblAusgabe1.Location = new Point(106, 26);
            LblAusgabe1.Name = "LblAusgabe1";
            LblAusgabe1.Size = new Size(0, 15);
            LblAusgabe1.TabIndex = 0;
            // 
            // NumZahl2
            // 
            NumZahl2.Location = new Point(106, 105);
            NumZahl2.Name = "NumZahl2";
            NumZahl2.Size = new Size(229, 23);
            NumZahl2.TabIndex = 1;
            NumZahl2.ValueChanged += NumZahl2_ValueChanged;
            // 
            // NumZahl1
            // 
            NumZahl1.Location = new Point(106, 51);
            NumZahl1.Name = "NumZahl1";
            NumZahl1.Size = new Size(229, 23);
            NumZahl1.TabIndex = 1;
            NumZahl1.ValueChanged += NumZahl1_ValueChanged;
            // 
            // CmdBerechne
            // 
            CmdBerechne.Location = new Point(106, 159);
            CmdBerechne.Name = "CmdBerechne";
            CmdBerechne.Size = new Size(229, 23);
            CmdBerechne.TabIndex = 2;
            CmdBerechne.Text = "Bestimme die grössere Zahl";
            CmdBerechne.UseVisualStyleBackColor = true;
            CmdBerechne.Click += CmdBerechne_Click;
            // 
            // A4_2_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdBerechne);
            Controls.Add(NumZahl1);
            Controls.Add(NumZahl2);
            Controls.Add(LblAusgabe1);
            Controls.Add(LblZahl1);
            Controls.Add(LblAusgabe2);
            Controls.Add(LblZahl2);
            Name = "A4_2_1";
            Text = "A4_2_1";
            ((System.ComponentModel.ISupportInitialize)NumZahl2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumZahl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblZahl2;
        private Label LblAusgabe2;
        private Label LblZahl1;
        private Label LblAusgabe1;
        private NumericUpDown NumZahl2;
        private NumericUpDown NumZahl1;
        private Button CmdBerechne;
    }
}