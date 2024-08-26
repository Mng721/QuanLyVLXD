namespace QuanLyVLXD
{
    partial class SignUp
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
        private void InitializeComponent() {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            btnSignIn = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label6 = new Label();
            tbRePassword = new TextBox();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.CustomizableEdges = customizableEdges1;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.DarkCyan;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(99, 481);
            btnBack.Name = "btnBack";
            btnBack.PressedColor = Color.Teal;
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBack.Size = new Size(180, 37);
            btnBack.TabIndex = 7;
            btnBack.Text = "Quay lại";
            btnBack.Click += guna2Button1_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.CustomizableEdges = customizableEdges3;
            btnSignIn.DisabledState.BorderColor = Color.DarkGray;
            btnSignIn.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSignIn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSignIn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSignIn.FillColor = Color.DarkCyan;
            btnSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(99, 426);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.PressedColor = Color.Teal;
            btnSignIn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSignIn.Size = new Size(180, 37);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "Đăng ký";
            btnSignIn.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 159);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 10;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 95);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 9;
            label2.Text = "Họ và tên:";
            // 
            // txtName
            // 
            txtName.Location = new Point(44, 123);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 23);
            txtName.TabIndex = 1;
            txtName.TextChanged += textBox2_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(44, 187);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 23);
            txtEmail.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 30);
            label1.Name = "label1";
            label1.Size = new Size(300, 51);
            label1.TabIndex = 6;
            label1.Text = "Đăng ký";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 222);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 14;
            label4.Text = "Tên đăng nhập";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(44, 250);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 23);
            txtUsername.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 287);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 16;
            label5.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(44, 315);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(300, 23);
            txtPassword.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(42, 355);
            label6.Name = "label6";
            label6.Size = new Size(202, 25);
            label6.TabIndex = 18;
            label6.Text = "Xác nhận lại mật khẩu:";
            // 
            // tbRePassword
            // 
            tbRePassword.Location = new Point(42, 383);
            tbRePassword.Name = "tbRePassword";
            tbRePassword.PasswordChar = '*';
            tbRePassword.Size = new Size(300, 23);
            tbRePassword.TabIndex = 5;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 555);
            Controls.Add(label6);
            Controls.Add(tbRePassword);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(btnBack);
            Controls.Add(btnSignIn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnSignIn;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private TextBox txtEmail;
        private Label label1;
        private Label label4;
        private TextBox txtUsername;
        private Label label5;
        private TextBox txtPassword;
        private Label label6;
        private TextBox tbRePassword;
    }
}