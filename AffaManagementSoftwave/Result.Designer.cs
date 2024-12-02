namespace AffaManagementSoftwave
{
    partial class Result
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
            label1 = new Label();
            games = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            team1 = new TextBox();
            team2 = new TextBox();
            team1Score = new TextBox();
            team2Score = new TextBox();
            netice = new Button();
            home = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(39, 42);
            label1.Name = "label1";
            label1.Size = new Size(161, 35);
            label1.TabIndex = 0;
            label1.Text = "Oyunu Secin";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // games
            // 
            games.FormattingEnabled = true;
            games.Location = new Point(39, 99);
            games.Name = "games";
            games.Size = new Size(381, 28);
            games.TabIndex = 1;
            games.SelectedIndexChanged += games_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(39, 164);
            label2.Name = "label2";
            label2.Size = new Size(146, 35);
            label2.TabIndex = 2;
            label2.Text = "Komanda 1";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(327, 164);
            label3.Name = "label3";
            label3.Size = new Size(146, 35);
            label3.TabIndex = 3;
            label3.Text = "Komanda 2";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // team1
            // 
            team1.Location = new Point(39, 226);
            team1.Name = "team1";
            team1.Size = new Size(237, 27);
            team1.TabIndex = 4;
            // 
            // team2
            // 
            team2.Location = new Point(327, 226);
            team2.Name = "team2";
            team2.Size = new Size(237, 27);
            team2.TabIndex = 5;
            // 
            // team1Score
            // 
            team1Score.Location = new Point(151, 283);
            team1Score.Name = "team1Score";
            team1Score.Size = new Size(125, 27);
            team1Score.TabIndex = 6;
            // 
            // team2Score
            // 
            team2Score.Location = new Point(327, 283);
            team2Score.Name = "team2Score";
            team2Score.Size = new Size(125, 27);
            team2Score.TabIndex = 7;
            // 
            // netice
            // 
            netice.BackColor = SystemColors.Highlight;
            netice.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            netice.ForeColor = Color.White;
            netice.Location = new Point(91, 363);
            netice.Name = "netice";
            netice.Size = new Size(227, 59);
            netice.TabIndex = 8;
            netice.Text = "Neticeni Elave Et";
            netice.UseVisualStyleBackColor = false;
            netice.Click += netice_Click;
            // 
            // home
            // 
            home.BackColor = Color.FromArgb(199, 82, 187);
            home.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            home.ForeColor = Color.White;
            home.Location = new Point(392, 374);
            home.Name = "home";
            home.Size = new Size(150, 48);
            home.TabIndex = 14;
            home.Text = "Home";
            home.UseVisualStyleBackColor = false;
            home.Click += home_Click;
            // 
            // Result
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(602, 470);
            Controls.Add(home);
            Controls.Add(netice);
            Controls.Add(team2Score);
            Controls.Add(team1Score);
            Controls.Add(team2);
            Controls.Add(team1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(games);
            Controls.Add(label1);
            Name = "Result";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Result";
            Load += Result_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox games;
        private Label label2;
        private Label label3;
        private TextBox team1;
        private TextBox team2;
        private TextBox team1Score;
        private TextBox team2Score;
        private Button netice;
        private Button home;
    }
}