namespace sport_shop
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pnLogin = new Panel();
            btnGuest = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lbPassword = new Label();
            txtLogin = new TextBox();
            lbLogin = new Label();
            pictureBox1 = new PictureBox();
            pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnLogin
            // 
            pnLogin.Anchor = AnchorStyles.Bottom;
            pnLogin.Controls.Add(btnGuest);
            pnLogin.Controls.Add(btnLogin);
            pnLogin.Controls.Add(txtPassword);
            pnLogin.Controls.Add(lbPassword);
            pnLogin.Controls.Add(txtLogin);
            pnLogin.Controls.Add(lbLogin);
            pnLogin.Location = new Point(15, 176);
            pnLogin.Margin = new Padding(4);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(450, 291);
            pnLogin.TabIndex = 0;
            // 
            // btnGuest
            // 
            btnGuest.Anchor = AnchorStyles.Top;
            btnGuest.BackColor = Color.FromArgb(233, 245, 255);
            btnGuest.FlatAppearance.BorderSize = 0;
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Location = new Point(150, 196);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(150, 29);
            btnGuest.TabIndex = 10;
            btnGuest.Text = "Войти как гость";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += btnGuest_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.BackColor = Color.FromArgb(233, 245, 255);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(150, 164);
            btnLogin.Margin = new Padding(3, 3, 3, 6);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 29);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top;
            txtPassword.Location = new Point(100, 131);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 26);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            lbPassword.Anchor = AnchorStyles.Top;
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(196, 105);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(58, 19);
            lbPassword.TabIndex = 7;
            lbPassword.Text = "Пароль";
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.Top;
            txtLogin.Location = new Point(100, 72);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(250, 26);
            txtLogin.TabIndex = 6;
            // 
            // lbLogin
            // 
            lbLogin.Anchor = AnchorStyles.Top;
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(191, 43);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(52, 19);
            lbLogin.TabIndex = 1;
            lbLogin.Text = "Логин";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(168, 39);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(494, 482);
            Controls.Add(pictureBox1);
            Controls.Add(pnLogin);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormLogin";
            Text = "Вход";
            Load += FormLogin_Load;
            pnLogin.ResumeLayout(false);
            pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnLogin;
        private PictureBox pictureBox1;
        private Button btnGuest;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label lbPassword;
        private TextBox txtLogin;
        private Label lbLogin;
    }
}
