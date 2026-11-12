namespace MyFinance.Login
{
    partial class frmLogin
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
            tlpMain = new TableLayoutPanel();
            pnlBrand = new Panel();
            pnlLogin = new Panel();
            lnkRegister = new LinkLabel();
            lblNoAccount = new Label();
            btnLogin = new Button();
            lnkForgotPassword = new LinkLabel();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            lblBrandName = new Label();
            lblBrandSubtitle = new Label();
            lblSlogan = new Label();
            pictureBox1 = new PictureBox();
            tlpMain.SuspendLayout();
            pnlBrand.SuspendLayout();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpMain.Controls.Add(pnlBrand, 0, 0);
            tlpMain.Controls.Add(pnlLogin, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1040, 774);
            tlpMain.TabIndex = 0;
            // 
            // pnlBrand
            // 
            pnlBrand.BackColor = Color.FromArgb(25, 41, 82);
            pnlBrand.Controls.Add(pictureBox1);
            pnlBrand.Controls.Add(lblSlogan);
            pnlBrand.Controls.Add(lblBrandSubtitle);
            pnlBrand.Controls.Add(lblBrandName);
            pnlBrand.Dock = DockStyle.Fill;
            pnlBrand.Location = new Point(0, 0);
            pnlBrand.Margin = new Padding(0);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new Size(416, 774);
            pnlBrand.TabIndex = 0;
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(lnkRegister);
            pnlLogin.Controls.Add(lblNoAccount);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(lnkForgotPassword);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(txtEmail);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(lblEmail);
            pnlLogin.Controls.Add(lblSubtitle);
            pnlLogin.Controls.Add(lblTitle);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(416, 0);
            pnlLogin.Margin = new Padding(0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(624, 774);
            pnlLogin.TabIndex = 1;
            // 
            // lnkRegister
            // 
            lnkRegister.ActiveLinkColor = Color.FromArgb(29, 78, 216);
            lnkRegister.AutoSize = true;
            lnkRegister.Location = new Point(514, 650);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(98, 32);
            lnkRegister.TabIndex = 9;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Sign Up";
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;
            // 
            // lblNoAccount
            // 
            lblNoAccount.AutoSize = true;
            lblNoAccount.Location = new Point(245, 650);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(274, 32);
            lblNoAccount.TabIndex = 8;
            lblNoAccount.Text = "Donot have an account?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(59, 130, 246);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(175, 513);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(406, 48);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.ActiveLinkColor = Color.FromArgb(29, 78, 216);
            lnkForgotPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkForgotPassword.Location = new Point(300, 570);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(199, 30);
            lnkForgotPassword.TabIndex = 6;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot Password?";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(175, 450);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(406, 39);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(173, 330);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(408, 39);
            txtEmail.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(31, 41, 55);
            lblPassword.Location = new Point(173, 390);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(153, 45);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(31, 41, 55);
            lblEmail.Location = new Point(175, 280);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(96, 45);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblSubtitle.Location = new Point(175, 220);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(518, 45);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Sign in to Your Cash Sense account";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitle.Location = new Point(175, 150);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(375, 70);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcom Back!";
            // 
            // lblBrandName
            // 
            lblBrandName.AutoSize = true;
            lblBrandName.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrandName.ForeColor = Color.White;
            lblBrandName.Location = new Point(65, 140);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new Size(293, 70);
            lblBrandName.TabIndex = 0;
            lblBrandName.Text = "MyFinance";
            // 
            // lblBrandSubtitle
            // 
            lblBrandSubtitle.AutoSize = true;
            lblBrandSubtitle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrandSubtitle.ForeColor = Color.FromArgb(214, 222, 239);
            lblBrandSubtitle.Location = new Point(65, 230);
            lblBrandSubtitle.Name = "lblBrandSubtitle";
            lblBrandSubtitle.Size = new Size(272, 38);
            lblBrandSubtitle.TabIndex = 1;
            lblBrandSubtitle.Text = "PERSONAL FINANCE";
            // 
            // lblSlogan
            // 
            lblSlogan.AutoSize = true;
            lblSlogan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSlogan.ForeColor = Color.FromArgb(214, 222, 239);
            lblSlogan.Location = new Point(65, 300);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(332, 32);
            lblSlogan.TabIndex = 2;
            lblSlogan.Text = "A clearer view of your money.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.chart1;
            pictureBox1.Location = new Point(65, 441);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 252);
            ClientSize = new Size(1040, 774);
            Controls.Add(tlpMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            tlpMain.ResumeLayout(false);
            pnlBrand.ResumeLayout(false);
            pnlBrand.PerformLayout();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel pnlBrand;
        private Panel pnlLogin;
        private Label lblEmail;
        private Label lblSubtitle;
        private Label lblTitle;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private LinkLabel lnkForgotPassword;
        private LinkLabel lnkRegister;
        private Label lblNoAccount;
        private Button btnLogin;
        private Label lblBrandName;
        private Label lblBrandSubtitle;
        private PictureBox pictureBox1;
        private Label lblSlogan;
    }
}
