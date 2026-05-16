namespace UserLoginApp.Forms
{
    partial class LoginForm
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
            LoginButton = new Button();
            passwordLoginBox = new TextBox();
            label7 = new Label();
            usernameLoginBox = new TextBox();
            label5 = new Label();
            label1 = new Label();
            GoRegister = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.HotTrack;
            LoginButton.Font = new Font("Segoe UI", 14F);
            LoginButton.ForeColor = SystemColors.ButtonFace;
            LoginButton.Location = new Point(135, 209);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(340, 49);
            LoginButton.TabIndex = 19;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // passwordLoginBox
            // 
            passwordLoginBox.Location = new Point(292, 158);
            passwordLoginBox.Name = "passwordLoginBox";
            passwordLoginBox.Size = new Size(183, 27);
            passwordLoginBox.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(135, 154);
            label7.Name = "label7";
            label7.Size = new Size(93, 28);
            label7.TabIndex = 17;
            label7.Text = "Password";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // usernameLoginBox
            // 
            usernameLoginBox.Location = new Point(292, 97);
            usernameLoginBox.Name = "usernameLoginBox";
            usernameLoginBox.Size = new Size(183, 27);
            usernameLoginBox.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(135, 93);
            label5.Name = "label5";
            label5.Size = new Size(99, 28);
            label5.TabIndex = 15;
            label5.Text = "Username";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(184, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 54);
            label1.TabIndex = 14;
            label1.Text = "Login Form";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // GoRegister
            // 
            GoRegister.BackColor = SystemColors.ButtonHighlight;
            GoRegister.Font = new Font("Segoe UI", 8F);
            GoRegister.ForeColor = SystemColors.ActiveCaptionText;
            GoRegister.Location = new Point(324, 264);
            GoRegister.Name = "GoRegister";
            GoRegister.Size = new Size(107, 30);
            GoRegister.TabIndex = 21;
            GoRegister.Text = "Register";
            GoRegister.UseVisualStyleBackColor = false;
            GoRegister.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(165, 271);
            label8.Name = "label8";
            label8.Size = new Size(104, 19);
            label8.TabIndex = 20;
            label8.Text = "Not a member?";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 450);
            Controls.Add(GoRegister);
            Controls.Add(label8);
            Controls.Add(LoginButton);
            Controls.Add(passwordLoginBox);
            Controls.Add(label7);
            Controls.Add(usernameLoginBox);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private TextBox passwordLoginBox;
        private Label label7;
        private TextBox usernameLoginBox;
        private Label label5;
        private Label label1;
        private Button GoRegister;
        private Label label8;
    }
}