namespace UserLoginApp.Forms
{
    partial class RegistrationForm
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
            label2 = new Label();
            fnameBox = new TextBox();
            lnameBox = new TextBox();
            label3 = new Label();
            emailBox = new TextBox();
            label4 = new Label();
            usernameBox = new TextBox();
            label5 = new Label();
            phoneBox = new TextBox();
            label6 = new Label();
            passwordBox = new TextBox();
            label7 = new Label();
            registerButton = new Button();
            label8 = new Label();
            GoLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(121, 9);
            label1.Name = "label1";
            label1.Size = new Size(269, 54);
            label1.TabIndex = 0;
            label1.Text = "Register Form";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(74, 85);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // fnameBox
            // 
            fnameBox.Location = new Point(231, 89);
            fnameBox.Name = "fnameBox";
            fnameBox.Size = new Size(183, 27);
            fnameBox.TabIndex = 2;
            // 
            // lnameBox
            // 
            lnameBox.Location = new Point(231, 136);
            lnameBox.Name = "lnameBox";
            lnameBox.Size = new Size(183, 27);
            lnameBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(74, 132);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(231, 193);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(183, 27);
            emailBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(74, 189);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 5;
            label4.Text = "Email";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(231, 245);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(183, 27);
            usernameBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(74, 241);
            label5.Name = "label5";
            label5.Size = new Size(99, 28);
            label5.TabIndex = 7;
            label5.Text = "Username";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(231, 302);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(183, 27);
            phoneBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(74, 298);
            label6.Name = "label6";
            label6.Size = new Size(144, 28);
            label6.TabIndex = 9;
            label6.Text = "Phone Number";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(231, 349);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(183, 27);
            passwordBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(74, 345);
            label7.Name = "label7";
            label7.Size = new Size(93, 28);
            label7.TabIndex = 11;
            label7.Text = "Password";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // registerButton
            // 
            registerButton.BackColor = SystemColors.HotTrack;
            registerButton.Font = new Font("Segoe UI", 14F);
            registerButton.ForeColor = SystemColors.ButtonFace;
            registerButton.Location = new Point(74, 382);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(340, 49);
            registerButton.TabIndex = 13;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(150, 444);
            label8.Name = "label8";
            label8.Size = new Size(127, 19);
            label8.TabIndex = 14;
            label8.Text = "Already a member?";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // GoLogin
            // 
            GoLogin.BackColor = SystemColors.ButtonHighlight;
            GoLogin.Font = new Font("Segoe UI", 8F);
            GoLogin.ForeColor = SystemColors.ActiveCaptionText;
            GoLogin.Location = new Point(283, 437);
            GoLogin.Name = "GoLogin";
            GoLogin.Size = new Size(107, 30);
            GoLogin.TabIndex = 15;
            GoLogin.Text = "Login";
            GoLogin.UseVisualStyleBackColor = false;
            GoLogin.Click += GoLogin_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 518);
            Controls.Add(GoLogin);
            Controls.Add(label8);
            Controls.Add(registerButton);
            Controls.Add(passwordBox);
            Controls.Add(label7);
            Controls.Add(phoneBox);
            Controls.Add(label6);
            Controls.Add(usernameBox);
            Controls.Add(label5);
            Controls.Add(emailBox);
            Controls.Add(label4);
            Controls.Add(lnameBox);
            Controls.Add(label3);
            Controls.Add(fnameBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox fnameBox;
        private TextBox lnameBox;
        private Label label3;
        private TextBox emailBox;
        private Label label4;
        private TextBox usernameBox;
        private Label label5;
        private TextBox phoneBox;
        private Label label6;
        private TextBox passwordBox;
        private Label label7;
        private Button registerButton;
        private Label label8;
        private Button GoLogin;
    }
}