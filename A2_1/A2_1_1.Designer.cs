namespace MB01.A2_1
{
    partial class A2_1_1
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
            CmdDelete = new Button();
            CmdAusgeben = new Button();
            TxtLastname = new TextBox();
            TxtFirstname = new TextBox();
            LblFirstname = new Label();
            LblLastname = new Label();
            LblAusgabe = new Label();
            SuspendLayout();
            // 
            // CmdDelete
            // 
            CmdDelete.Location = new Point(226, 73);
            CmdDelete.Name = "CmdDelete";
            CmdDelete.Size = new Size(106, 23);
            CmdDelete.TabIndex = 0;
            CmdDelete.Text = "Löschen";
            CmdDelete.UseVisualStyleBackColor = true;
            CmdDelete.Click += CmdDelete_Click;
            // 
            // CmdAusgeben
            // 
            CmdAusgeben.Location = new Point(116, 73);
            CmdAusgeben.Name = "CmdAusgeben";
            CmdAusgeben.Size = new Size(104, 23);
            CmdAusgeben.TabIndex = 0;
            CmdAusgeben.Text = "Ausgeben";
            CmdAusgeben.UseVisualStyleBackColor = true;
            CmdAusgeben.Click += CmdAusgabe_Click;
            // 
            // TxtLastname
            // 
            TxtLastname.Location = new Point(116, 44);
            TxtLastname.Name = "TxtLastname";
            TxtLastname.Size = new Size(216, 23);
            TxtLastname.TabIndex = 1;
            // 
            // TxtFirstname
            // 
            TxtFirstname.Location = new Point(116, 13);
            TxtFirstname.Name = "TxtFirstname";
            TxtFirstname.Size = new Size(216, 23);
            TxtFirstname.TabIndex = 1;
            // 
            // LblFirstname
            // 
            LblFirstname.AutoSize = true;
            LblFirstname.Location = new Point(23, 21);
            LblFirstname.Name = "LblFirstname";
            LblFirstname.Size = new Size(62, 15);
            LblFirstname.TabIndex = 2;
            LblFirstname.Text = "Firstname:";
            // 
            // LblLastname
            // 
            LblLastname.AutoSize = true;
            LblLastname.Location = new Point(23, 52);
            LblLastname.Name = "LblLastname";
            LblLastname.Size = new Size(61, 15);
            LblLastname.TabIndex = 2;
            LblLastname.Text = "Lastname:";
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(116, 136);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(16, 15);
            LblAusgabe.TabIndex = 2;
            LblAusgabe.Text = "...";
            // 
            // A2_1_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 290);
            Controls.Add(LblAusgabe);
            Controls.Add(LblLastname);
            Controls.Add(LblFirstname);
            Controls.Add(TxtFirstname);
            Controls.Add(TxtLastname);
            Controls.Add(CmdAusgeben);
            Controls.Add(CmdDelete);
            Name = "A2_1_1";
            Text = "A2_1_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdDelete;
        private Button CmdAusgeben;
        private TextBox TxtLastname;
        private TextBox TxtFirstname;
        private Label LblFirstname;
        private Label LblLastname;
        private Label LblAusgabe;
    }
}