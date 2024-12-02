namespace AffaManagementSoftwave
{
    partial class UserPanel
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
            dataGridView1 = new DataGridView();
            oyunCedveli = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            home = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oyunCedveli).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1521, 275);
            dataGridView1.TabIndex = 0;
            // 
            // oyunCedveli
            // 
            oyunCedveli.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            oyunCedveli.Location = new Point(12, 466);
            oyunCedveli.Name = "oyunCedveli";
            oyunCedveli.RowHeadersWidth = 51;
            oyunCedveli.Size = new Size(764, 188);
            oyunCedveli.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(179, 35);
            label1.TabIndex = 2;
            label1.Text = "Turnir Cedveli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(12, 409);
            label2.Name = "label2";
            label2.Size = new Size(293, 35);
            label2.TabIndex = 3;
            label2.Text = "Oyun Neticeleri Cedveli";
            // 
            // home
            // 
            home.BackColor = Color.FromArgb(199, 82, 187);
            home.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            home.ForeColor = Color.White;
            home.Location = new Point(1320, 529);
            home.Name = "home";
            home.Size = new Size(213, 125);
            home.TabIndex = 15;
            home.Text = "Home";
            home.UseVisualStyleBackColor = false;
            home.Click += home_Click;
            // 
            // UserPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1545, 693);
            Controls.Add(home);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(oyunCedveli);
            Controls.Add(dataGridView1);
            Name = "UserPanel";
            Text = "UserPanel";
            Load += UserPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)oyunCedveli).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView oyunCedveli;
        private Label label1;
        private Label label2;
        private Button home;
    }
}