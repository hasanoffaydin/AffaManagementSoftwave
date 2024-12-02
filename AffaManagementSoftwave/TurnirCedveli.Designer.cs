namespace AffaManagementSoftwave
{
    partial class TurnirCedveli
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
            home = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1364, 353);
            dataGridView1.TabIndex = 0;
            // 
            // home
            // 
            home.BackColor = Color.FromArgb(199, 82, 187);
            home.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            home.ForeColor = Color.White;
            home.Location = new Point(1226, 396);
            home.Name = "home";
            home.Size = new Size(150, 48);
            home.TabIndex = 14;
            home.Text = "Home";
            home.UseVisualStyleBackColor = false;
            home.Click += home_Click;
            // 
            // TurnirCedveli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1388, 450);
            Controls.Add(home);
            Controls.Add(dataGridView1);
            Name = "TurnirCedveli";
            Text = "TurnirCedveli";
            Load += TurnirCedveli_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button home;
    }
}