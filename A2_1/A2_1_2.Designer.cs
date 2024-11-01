namespace MB01.A2_1
{
    partial class A2_1_2
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
            TxtLastname = new TextBox();
            TxtFirstname = new TextBox();
            LblFirstname = new Label();
            LblLastname = new Label();
            LblAlter = new Label();
            LblAusgabe = new Label();
            NumAlter = new NumericUpDown();
            CmdAusgabe = new Button();
            CmdLöschen = new Button();
            ((System.ComponentModel.ISupportInitialize)NumAlter).BeginInit();
            SuspendLayout();
            // 
            // TxtLastname
            // 
            TxtLastname.Location = new Point(96, 50);
            TxtLastname.Name = "TxtLastname";
            TxtLastname.Size = new Size(214, 23);
            TxtLastname.TabIndex = 0;
            // 
            // TxtFirstname
            // 
            TxtFirstname.Location = new Point(96, 21);
            TxtFirstname.Name = "TxtFirstname";
            TxtFirstname.Size = new Size(214, 23);
            TxtFirstname.TabIndex = 0;
            // 
            // LblFirstname
            // 
            LblFirstname.AutoSize = true;
            LblFirstname.Location = new Point(28, 29);
            LblFirstname.Name = "LblFirstname";
            LblFirstname.Size = new Size(62, 15);
            LblFirstname.TabIndex = 1;
            LblFirstname.Text = "Firstname:";
            // 
            // LblLastname
            // 
            LblLastname.AutoSize = true;
            LblLastname.Location = new Point(28, 58);
            LblLastname.Name = "LblLastname";
            LblLastname.Size = new Size(61, 15);
            LblLastname.TabIndex = 1;
            LblLastname.Text = "Lastname:";
            // 
            // LblAlter
            // 
            LblAlter.AutoSize = true;
            LblAlter.Location = new Point(28, 87);
            LblAlter.Name = "LblAlter";
            LblAlter.Size = new Size(31, 15);
            LblAlter.TabIndex = 1;
            LblAlter.Text = "Age:";
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(96, 169);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(16, 15);
            LblAusgabe.TabIndex = 1;
            LblAusgabe.Text = "...";
            // 
            // NumAlter
            // 
            NumAlter.Location = new Point(96, 79);
            NumAlter.Name = "NumAlter";
            NumAlter.Size = new Size(214, 23);
            NumAlter.TabIndex = 2;
            // 
            // CmdAusgabe
            // 
            CmdAusgabe.Location = new Point(96, 124);
            CmdAusgabe.Name = "CmdAusgabe";
            CmdAusgabe.Size = new Size(103, 23);
            CmdAusgabe.TabIndex = 3;
            CmdAusgabe.Text = "Ausgeben";
            CmdAusgabe.UseVisualStyleBackColor = true;
            CmdAusgabe.Click += CmdAusgabe_Click;
            // 
            // CmdLöschen
            // 
            CmdLöschen.Location = new Point(205, 124);
            CmdLöschen.Name = "CmdLöschen";
            CmdLöschen.Size = new Size(105, 23);
            CmdLöschen.TabIndex = 3;
            CmdLöschen.Text = "Löschen";
            CmdLöschen.UseVisualStyleBackColor = true;
            CmdLöschen.Click += CmdLöschen_Click;
            // 
            // A2_1_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdLöschen);
            Controls.Add(CmdAusgabe);
            Controls.Add(NumAlter);
            Controls.Add(LblAusgabe);
            Controls.Add(LblAlter);
            Controls.Add(LblLastname);
            Controls.Add(LblFirstname);
            Controls.Add(TxtFirstname);
            Controls.Add(TxtLastname);
            Name = "A2_1_2";
            Text = "A2_1_2";
            ((System.ComponentModel.ISupportInitialize)NumAlter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtLastname;
        private TextBox TxtFirstname;
        private Label LblFirstname;
        private Label LblLastname;
        private Label LblAlter;
        private Label LblAusgabe;
        private NumericUpDown NumAlter;
        private Button CmdAusgabe;
        private Button CmdLöschen;
    }
}