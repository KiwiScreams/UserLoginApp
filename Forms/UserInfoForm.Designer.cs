using UserLoginApp.Models;
namespace UserLoginApp.Forms
{
    partial class UserInfoForm
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

        private User currentUser;
        public UserInfoForm(User user)
        {
            InitializeComponent();

            currentUser = user;

            fnameInfo.Text = user.FName;
            lnameInfo.Text = user.LName;
            emailInfo.Text = user.Email;
            usernameInfo.Text = user.UserName;
            phoneInfo.Text = user.Phone;
            passwordInfo.Text = user.Password;

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            registerButton = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            fnameInfo = new Label();
            lnameInfo = new Label();
            emailInfo = new Label();
            usernameInfo = new Label();
            phoneInfo = new Label();
            passwordInfo = new Label();
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.BackColor = SystemColors.ActiveCaption;
            registerButton.Font = new Font("Segoe UI", 14F);
            registerButton.ForeColor = SystemColors.ActiveCaptionText;
            registerButton.Location = new Point(567, 389);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(173, 49);
            registerButton.TabIndex = 27;
            registerButton.Text = "Log Out";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(230, 350);
            label7.Name = "label7";
            label7.Size = new Size(93, 28);
            label7.TabIndex = 25;
            label7.Text = "Password";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(230, 303);
            label6.Name = "label6";
            label6.Size = new Size(144, 28);
            label6.TabIndex = 23;
            label6.Text = "Phone Number";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(230, 246);
            label5.Name = "label5";
            label5.Size = new Size(99, 28);
            label5.TabIndex = 21;
            label5.Text = "Username";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(230, 194);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 19;
            label4.Text = "Email";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(230, 137);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 17;
            label3.Text = "Last Name";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(230, 90);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 15;
            label2.Text = "First Name";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(277, 14);
            label1.Name = "label1";
            label1.Size = new Size(183, 54);
            label1.TabIndex = 14;
            label1.Text = "User Info";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // fnameInfo
            // 
            fnameInfo.AutoSize = true;
            fnameInfo.Font = new Font("Segoe UI", 12F);
            fnameInfo.ForeColor = SystemColors.ActiveCaptionText;
            fnameInfo.Location = new Point(397, 90);
            fnameInfo.Name = "fnameInfo";
            fnameInfo.Size = new Size(106, 28);
            fnameInfo.TabIndex = 28;
            fnameInfo.Text = "First Name";
            fnameInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lnameInfo
            // 
            lnameInfo.AutoSize = true;
            lnameInfo.Font = new Font("Segoe UI", 12F);
            lnameInfo.ForeColor = SystemColors.ActiveCaptionText;
            lnameInfo.Location = new Point(397, 137);
            lnameInfo.Name = "lnameInfo";
            lnameInfo.Size = new Size(103, 28);
            lnameInfo.TabIndex = 29;
            lnameInfo.Text = "Last Name";
            lnameInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // emailInfo
            // 
            emailInfo.AutoSize = true;
            emailInfo.Font = new Font("Segoe UI", 12F);
            emailInfo.ForeColor = SystemColors.ActiveCaptionText;
            emailInfo.Location = new Point(401, 194);
            emailInfo.Name = "emailInfo";
            emailInfo.Size = new Size(59, 28);
            emailInfo.TabIndex = 30;
            emailInfo.Text = "Email";
            emailInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // usernameInfo
            // 
            usernameInfo.AutoSize = true;
            usernameInfo.Font = new Font("Segoe UI", 12F);
            usernameInfo.ForeColor = SystemColors.ActiveCaptionText;
            usernameInfo.Location = new Point(397, 246);
            usernameInfo.Name = "usernameInfo";
            usernameInfo.Size = new Size(99, 28);
            usernameInfo.TabIndex = 31;
            usernameInfo.Text = "Username";
            usernameInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // phoneInfo
            // 
            phoneInfo.AutoSize = true;
            phoneInfo.Font = new Font("Segoe UI", 12F);
            phoneInfo.ForeColor = SystemColors.ActiveCaptionText;
            phoneInfo.Location = new Point(401, 303);
            phoneInfo.Name = "phoneInfo";
            phoneInfo.Size = new Size(144, 28);
            phoneInfo.TabIndex = 32;
            phoneInfo.Text = "Phone Number";
            phoneInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // passwordInfo
            // 
            passwordInfo.AutoSize = true;
            passwordInfo.Font = new Font("Segoe UI", 12F);
            passwordInfo.ForeColor = SystemColors.ActiveCaptionText;
            passwordInfo.Location = new Point(401, 350);
            passwordInfo.Name = "passwordInfo";
            passwordInfo.Size = new Size(144, 28);
            passwordInfo.TabIndex = 33;
            passwordInfo.Text = "Phone Number";
            passwordInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // UserInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passwordInfo);
            Controls.Add(phoneInfo);
            Controls.Add(usernameInfo);
            Controls.Add(emailInfo);
            Controls.Add(lnameInfo);
            Controls.Add(fnameInfo);
            Controls.Add(registerButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserInfoForm";
            Text = "UserInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerButton;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label fnameInfo;
        private Label lnameInfo;
        private Label emailInfo;
        private Label usernameInfo;
        private Label phoneInfo;
        private Label passwordInfo;
    }
}