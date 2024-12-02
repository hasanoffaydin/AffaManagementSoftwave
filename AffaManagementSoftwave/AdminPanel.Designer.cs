namespace AffaManagementSoftwave
{
    partial class AdminPanel
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
            komandaAdi = new TextBox();
            elaveEt = new Button();
            label2 = new Label();
            ilkKomanda = new ComboBox();
            label3 = new Label();
            ikinciKomanda = new ComboBox();
            gameTime = new DateTimePicker();
            oyunElaveEt = new Button();
            button1 = new Button();
            home = new Button();
            turniket = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(52, 72);
            label1.Name = "label1";
            label1.Size = new Size(152, 30);
            label1.TabIndex = 1;
            label1.Text = "Komanda Adi";
            // 
            // komandaAdi
            // 
            komandaAdi.Location = new Point(236, 77);
            komandaAdi.Name = "komandaAdi";
            komandaAdi.Size = new Size(253, 27);
            komandaAdi.TabIndex = 2;
            // 
            // elaveEt
            // 
            elaveEt.BackColor = Color.Green;
            elaveEt.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            elaveEt.ForeColor = Color.White;
            elaveEt.Location = new Point(569, 67);
            elaveEt.Name = "elaveEt";
            elaveEt.Size = new Size(124, 46);
            elaveEt.TabIndex = 5;
            elaveEt.Text = "Elave et";
            elaveEt.UseVisualStyleBackColor = false;
            elaveEt.Click += elaveEt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 205);
            label2.Name = "label2";
            label2.Size = new Size(142, 30);
            label2.TabIndex = 6;
            label2.Text = "Ilk Komanda";
            // 
            // ilkKomanda
            // 
            ilkKomanda.FormattingEnabled = true;
            ilkKomanda.Location = new Point(52, 261);
            ilkKomanda.Name = "ilkKomanda";
            ilkKomanda.Size = new Size(191, 28);
            ilkKomanda.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(383, 205);
            label3.Name = "label3";
            label3.Size = new Size(172, 30);
            label3.TabIndex = 8;
            label3.Text = "Ikinci Komanda";
            // 
            // ikinciKomanda
            // 
            ikinciKomanda.FormattingEnabled = true;
            ikinciKomanda.Location = new Point(383, 261);
            ikinciKomanda.Name = "ikinciKomanda";
            ikinciKomanda.Size = new Size(191, 28);
            ikinciKomanda.TabIndex = 9;
            // 
            // gameTime
            // 
            gameTime.Location = new Point(52, 327);
            gameTime.Name = "gameTime";
            gameTime.Size = new Size(311, 27);
            gameTime.TabIndex = 10;
            // 
            // oyunElaveEt
            // 
            oyunElaveEt.BackColor = Color.Green;
            oyunElaveEt.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            oyunElaveEt.ForeColor = Color.White;
            oyunElaveEt.Location = new Point(462, 327);
            oyunElaveEt.Name = "oyunElaveEt";
            oyunElaveEt.Size = new Size(231, 46);
            oyunElaveEt.TabIndex = 11;
            oyunElaveEt.Text = "Oyun Elave Et";
            oyunElaveEt.UseVisualStyleBackColor = false;
            oyunElaveEt.Click += oyunElaveEt_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 192);
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(52, 395);
            button1.Name = "button1";
            button1.Size = new Size(243, 47);
            button1.TabIndex = 12;
            button1.Text = "Netice Elave Et";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // home
            // 
            home.BackColor = Color.FromArgb(199, 82, 187);
            home.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            home.ForeColor = Color.White;
            home.Location = new Point(543, 409);
            home.Name = "home";
            home.Size = new Size(150, 48);
            home.TabIndex = 13;
            home.Text = "Home";
            home.UseVisualStyleBackColor = false;
            home.Click += home_Click_1;
            // 
            // turniket
            // 
            turniket.BackColor = Color.FromArgb(199, 82, 187);
            turniket.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            turniket.ForeColor = Color.White;
            turniket.Location = new Point(351, 399);
            turniket.Name = "turniket";
            turniket.Size = new Size(150, 68);
            turniket.TabIndex = 15;
            turniket.Text = "Turniket Cedveli";
            turniket.UseVisualStyleBackColor = false;
            turniket.Click += turniket_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 0, 51);
            ClientSize = new Size(721, 482);
            Controls.Add(turniket);
            Controls.Add(home);
            Controls.Add(button1);
            Controls.Add(oyunElaveEt);
            Controls.Add(gameTime);
            Controls.Add(ikinciKomanda);
            Controls.Add(label3);
            Controls.Add(ilkKomanda);
            Controls.Add(label2);
            Controls.Add(elaveEt);
            Controls.Add(komandaAdi);
            Controls.Add(label1);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanel";
            Load += AdminPanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox komandaAdi;
        private Button elaveEt;
        private Label label2;
        private ComboBox ilkKomanda;
        private Label label3;
        private ComboBox ikinciKomanda;
        private DateTimePicker gameTime;
        private Button oyunElaveEt;
        private Button button1;
        private Button home;
        private Button turniket;
    }
}