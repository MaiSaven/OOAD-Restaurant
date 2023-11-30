namespace RESTAURANT
{
    partial class Login001SC
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
            login = new Label();
            user = new Label();
            password = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            fogetPassword = new LinkLabel();
            txtAlt = new Label();
            SuspendLayout();
            // 
            // login
            // 
            login.AutoSize = true;
            login.Font = new Font("STCaiyun", 28F, FontStyle.Regular, GraphicsUnit.Point);
            login.ForeColor = SystemColors.MenuHighlight;
            login.Location = new Point(744, 225);
            login.Name = "login";
            login.Size = new Size(130, 49);
            login.TabIndex = 0;
            login.Text = "Login";
            // 
            // user
            // 
            user.AutoSize = true;
            user.Font = new Font("Rondalo", 14F, FontStyle.Regular, GraphicsUnit.Point);
            user.Location = new Point(504, 312);
            user.Name = "user";
            user.Size = new Size(51, 28);
            user.TabIndex = 2;
            user.Text = "User";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Rondalo", 14F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(504, 384);
            password.Name = "password";
            password.Size = new Size(102, 28);
            password.TabIndex = 3;
            password.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUser.Location = new Point(633, 309);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(352, 34);
            txtUser.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(633, 380);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(352, 34);
            txtPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.MenuHighlight;
            btnLogin.Font = new Font("Rondalo", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(736, 465);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(147, 50);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // fogetPassword
            // 
            fogetPassword.AutoSize = true;
            fogetPassword.Font = new Font("Rondalo", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            fogetPassword.Location = new Point(747, 430);
            fogetPassword.Name = "fogetPassword";
            fogetPassword.Size = new Size(122, 20);
            fogetPassword.TabIndex = 7;
            fogetPassword.TabStop = true;
            fogetPassword.Text = "Forget Password?";
            // 
            // txtAlt
            // 
            txtAlt.AutoSize = true;
            txtAlt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtAlt.ForeColor = Color.FromArgb(192, 0, 0);
            txtAlt.Location = new Point(679, 544);
            txtAlt.Name = "txtAlt";
            txtAlt.Size = new Size(261, 28);
            txtAlt.TabIndex = 8;
            txtAlt.Text = "Incorrect User or Password!";
            // 
            // Login001SC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1618, 871);
            Controls.Add(txtAlt);
            Controls.Add(fogetPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(password);
            Controls.Add(user);
            Controls.Add(login);
            MaximumSize = new Size(1636, 918);
            Name = "Login001SC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login001SC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label login;
        private Label user;
        private Label password;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel fogetPassword;
        private Label txtAlt;
    }
}