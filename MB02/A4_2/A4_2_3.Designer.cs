namespace MB02.A4_2
{
    partial class A4_2_3
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
            CmdZeichne = new Button();
            LblLänge = new Label();
            LblBreite = new Label();
            LblLängePanel = new Label();
            LblBreitePanel = new Label();
            LblLB = new Label();
            TxtLänge = new TextBox();
            TxtBreite = new TextBox();
            PnlBLue = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            LblQuadrat = new Label();
            SuspendLayout();
            // 
            // CmdZeichne
            // 
            CmdZeichne.Location = new Point(95, 179);
            CmdZeichne.Name = "CmdZeichne";
            CmdZeichne.Size = new Size(100, 23);
            CmdZeichne.TabIndex = 0;
            CmdZeichne.Text = "Zeichne";
            CmdZeichne.UseVisualStyleBackColor = true;
            CmdZeichne.Click += CmdZeichne_Click;
            // 
            // LblLänge
            // 
            LblLänge.AutoSize = true;
            LblLänge.Location = new Point(29, 41);
            LblLänge.Name = "LblLänge";
            LblLänge.Size = new Size(42, 15);
            LblLänge.TabIndex = 1;
            LblLänge.Text = "Länge:";
            // 
            // LblBreite
            // 
            LblBreite.AutoSize = true;
            LblBreite.Location = new Point(29, 81);
            LblBreite.Name = "LblBreite";
            LblBreite.Size = new Size(40, 15);
            LblBreite.TabIndex = 1;
            LblBreite.Text = "Breite:";
            // 
            // LblLängePanel
            // 
            LblLängePanel.AutoSize = true;
            LblLängePanel.Location = new Point(392, 23);
            LblLängePanel.Name = "LblLängePanel";
            LblLängePanel.Size = new Size(45, 15);
            LblLängePanel.TabIndex = 1;
            LblLängePanel.Text = "200 cm";
            // 
            // LblBreitePanel
            // 
            LblBreitePanel.AutoSize = true;
            LblBreitePanel.Location = new Point(521, 84);
            LblBreitePanel.Name = "LblBreitePanel";
            LblBreitePanel.Size = new Size(45, 15);
            LblBreitePanel.TabIndex = 1;
            LblBreitePanel.Text = "100 cm";
            // 
            // LblLB
            // 
            LblLB.AutoSize = true;
            LblLB.Location = new Point(29, 142);
            LblLB.Name = "LblLB";
            LblLB.Size = new Size(192, 15);
            LblLB.TabIndex = 1;
            LblLB.Text = "Werte zwischen 50 und 200 erlaubt:";
            // 
            // TxtLänge
            // 
            TxtLänge.Location = new Point(95, 38);
            TxtLänge.Name = "TxtLänge";
            TxtLänge.Size = new Size(100, 23);
            TxtLänge.TabIndex = 2;
            // 
            // TxtBreite
            // 
            TxtBreite.Location = new Point(95, 78);
            TxtBreite.Name = "TxtBreite";
            TxtBreite.Size = new Size(100, 23);
            TxtBreite.TabIndex = 3;
            // 
            // PnlBLue
            // 
            PnlBLue.BackColor = Color.DeepSkyBlue;
            PnlBLue.Location = new Point(315, 41);
            PnlBLue.Name = "PnlBLue";
            PnlBLue.Size = new Size(200, 100);
            PnlBLue.TabIndex = 4;
            // 
            // LblQuadrat
            // 
            LblQuadrat.AutoSize = true;
            LblQuadrat.Location = new Point(392, 144);
            LblQuadrat.Name = "LblQuadrat";
            LblQuadrat.Size = new Size(53, 15);
            LblQuadrat.TabIndex = 5;
            LblQuadrat.Text = "Quadrat!";
            LblQuadrat.Visible = false;
            // 
            // A4_2_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 246);
            Controls.Add(LblQuadrat);
            Controls.Add(PnlBLue);
            Controls.Add(TxtBreite);
            Controls.Add(TxtLänge);
            Controls.Add(LblBreitePanel);
            Controls.Add(LblLB);
            Controls.Add(LblLängePanel);
            Controls.Add(LblBreite);
            Controls.Add(LblLänge);
            Controls.Add(CmdZeichne);
            Name = "A4_2_3";
            Text = "A4_2_3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdZeichne;
        private Label LblLänge;
        private Label LblBreite;
        private Label LblLängePanel;
        private Label LblBreitePanel;
        private Label LblLB;
        private TextBox TxtLänge;
        private TextBox TxtBreite;
        private Panel PnlBLue;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label LblQuadrat;
    }
}