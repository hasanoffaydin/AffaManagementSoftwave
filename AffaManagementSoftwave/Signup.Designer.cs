namespace AffaManagementSoftwave
{
    partial class Signup
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
            name = new Label();
            lastname = new Label();
            firstname = new TextBox();
            surname = new TextBox();
            label2 = new Label();
            gmail = new TextBox();
            label3 = new Label();
            password = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(157, 46);
            label1.Name = "label1";
            label1.Size = new Size(146, 46);
            label1.TabIndex = 1;
            label1.Text = "Sign Up";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            name.ForeColor = Color.White;
            name.Location = new Point(37, 118);
            name.Name = "name";
            name.Size = new Size(74, 30);
            name.TabIndex = 2;
            name.Text = "Name";
            // 
            // lastname
            // 
            lastname.AutoSize = true;
            lastname.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lastname.ForeColor = Color.White;
            lastname.Location = new Point(241, 118);
            lastname.Name = "lastname";
            lastname.Size = new Size(122, 30);
            lastname.TabIndex = 3;
            lastname.Text = "Last Name";
            // 
            // firstname
            // 
            firstname.Location = new Point(37, 191);
            firstname.Name = "firstname";
            firstname.Size = new Size(152, 27);
            firstname.TabIndex = 4;
            // 
            // surname
            // 
            surname.Location = new Point(241, 191);
            surname.Name = "surname";
            surname.Size = new Size(152, 27);
            surname.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 256);
            label2.Name = "label2";
            label2.Size = new Size(73, 30);
            label2.TabIndex = 6;
            label2.Text = "Gmail";
            // 
            // gmail
            // 
            gmail.Location = new Point(37, 309);
            gmail.Name = "gmail";
            gmail.Size = new Size(356, 27);
            gmail.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(37, 373);
            label3.Name = "label3";
            label3.Size = new Size(112, 30);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // password
            // 
            password.Location = new Point(37, 426);
            password.Name = "password";
            password.Size = new Size(356, 27);
            password.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(67, 166, 140);
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(37, 484);
            button1.Name = "button1";
            button1.Size = new Size(157, 41);
            button1.TabIndex = 10;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(67, 166, 140);
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(236, 484);
            button2.Name = "button2";
            button2.Size = new Size(157, 41);
            button2.TabIndex = 11;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 159, 77);
            ClientSize = new Size(445, 566);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(label3);
            Controls.Add(gmail);
            Controls.Add(label2);
            Controls.Add(surname);
            Controls.Add(firstname);
            Controls.Add(lastname);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            Load += Signup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label name;
        private Label lastname;
        private TextBox firstname;
        private TextBox surname;
        private Label label2;
        private TextBox gmail;
        private Label label3;
        private TextBox password;
        private Button button1;
        private Button button2;
    }
}