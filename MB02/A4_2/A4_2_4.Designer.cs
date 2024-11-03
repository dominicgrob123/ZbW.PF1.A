namespace MB02.A4_2
{
    partial class A4_2_4
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
            TxtResult = new TextBox();
            TxtOp = new TextBox();
            LblResult = new Label();
            LblOp = new Label();
            LblZahl2 = new Label();
            LblZahl1 = new Label();
            CmdDurchführen = new Button();
            SuspendLayout();
            // 
            // TxtZahl1
            // 
            TxtZahl1.Location = new Point(97, 37);
            TxtZahl1.Name = "TxtZahl1";
            TxtZahl1.Size = new Size(112, 23);
            TxtZahl1.TabIndex = 0;
            // 
            // TxtZahl2
            // 
            TxtZahl2.Location = new Point(97, 80);
            TxtZahl2.Name = "TxtZahl2";
            TxtZahl2.Size = new Size(112, 23);
            TxtZahl2.TabIndex = 0;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(27, 191);
            TxtResult.Name = "TxtResult";
            TxtResult.ReadOnly = true;
            TxtResult.Size = new Size(232, 23);
            TxtResult.TabIndex = 0;
            TxtResult.TextChanged += textBox3_TextChanged;
            // 
            // TxtOp
            // 
            TxtOp.Location = new Point(207, 118);
            TxtOp.Name = "TxtOp";
            TxtOp.Size = new Size(52, 23);
            TxtOp.TabIndex = 0;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Location = new Point(27, 173);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(139, 15);
            LblResult.TabIndex = 1;
            LblResult.Text = "Resultat der Berechnung:";
            // 
            // LblOp
            // 
            LblOp.AutoSize = true;
            LblOp.Location = new Point(27, 121);
            LblOp.Name = "LblOp";
            LblOp.Size = new Size(174, 15);
            LblOp.TabIndex = 1;
            LblOp.Text = "Gewünschte Operation (+,-,*,/):";
            // 
            // LblZahl2
            // 
            LblZahl2.AutoSize = true;
            LblZahl2.Location = new Point(27, 83);
            LblZahl2.Name = "LblZahl2";
            LblZahl2.Size = new Size(45, 15);
            LblZahl2.TabIndex = 1;
            LblZahl2.Text = "2. Zahl:";
            // 
            // LblZahl1
            // 
            LblZahl1.AutoSize = true;
            LblZahl1.Location = new Point(27, 40);
            LblZahl1.Name = "LblZahl1";
            LblZahl1.Size = new Size(45, 15);
            LblZahl1.TabIndex = 1;
            LblZahl1.Text = "1. Zahl:";
            // 
            // CmdDurchführen
            // 
            CmdDurchführen.Location = new Point(27, 234);
            CmdDurchführen.Name = "CmdDurchführen";
            CmdDurchführen.Size = new Size(232, 23);
            CmdDurchführen.TabIndex = 2;
            CmdDurchführen.Text = "Berechnung durchführen";
            CmdDurchführen.UseVisualStyleBackColor = true;
            CmdDurchführen.Click += CmdDurchführen_Click;
            // 
            // A4_2_4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdDurchführen);
            Controls.Add(LblZahl1);
            Controls.Add(LblZahl2);
            Controls.Add(LblOp);
            Controls.Add(LblResult);
            Controls.Add(TxtOp);
            Controls.Add(TxtResult);
            Controls.Add(TxtZahl2);
            Controls.Add(TxtZahl1);
            Name = "A4_2_4";
            Text = "A4_2_4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtZahl1;
        private TextBox TxtZahl2;
        private TextBox TxtResult;
        private TextBox TxtOp;
        private Label LblResult;
        private Label LblOp;
        private Label LblZahl2;
        private Label LblZahl1;
        private Button CmdDurchführen;
    }
}