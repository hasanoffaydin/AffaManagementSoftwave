namespace AffaManagementSoftwave
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            login = new Button();
            signup = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(174, 85);
            label1.Name = "label1";
            label1.Size = new Size(110, 46);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 173);
            label2.Name = "label2";
            label2.Size = new Size(117, 30);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 228);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(359, 27);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(35, 286);
            label3.Name = "label3";
            label3.Size = new Size(112, 30);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(35, 347);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(359, 27);
            textBox2.TabIndex = 4;
            // 
            // login
            // 
            login.BackColor = Color.FromArgb(238, 128, 33);
            login.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            login.ForeColor = Color.White;
            login.Location = new Point(52, 430);
            login.Name = "login";
            login.Size = new Size(151, 43);
            login.TabIndex = 5;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // signup
            // 
            signup.BackColor = Color.FromArgb(238, 128, 33);
            signup.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            signup.ForeColor = Color.White;
            signup.Location = new Point(231, 430);
            signup.Name = "signup";
            signup.Size = new Size(151, 43);
            signup.TabIndex = 6;
            signup.Text = "Sign Up";
            signup.UseVisualStyleBackColor = false;
            signup.Click += signup_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 83, 202);
            ClientSize = new Size(444, 542);
            Controls.Add(signup);
            Controls.Add(login);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button login;
        private Button signup;
    }
}
