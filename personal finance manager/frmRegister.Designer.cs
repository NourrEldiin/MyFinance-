namespace personal_finance_manager
{
    partial class frmRegister
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
            tlpMain = new TableLayoutPanel();
            pnlPrand = new Panel();
            picChart = new PictureBox();
            label3 = new Label();
            LBLPersonal = new Label();
            lblMyfinance = new Label();
            pnlRegister = new Panel();
            lnkLogin = new LinkLabel();
            lblHaveAcount = new Label();
            btnRegister = new Button();
            txtConfirm = new TextBox();
            txtPassword = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            lblConfirm = new Label();
            lblPassword = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblFullName = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            tlpMain.SuspendLayout();
            pnlPrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChart).BeginInit();
            pnlRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpMain.Controls.Add(pnlPrand, 0, 0);
            tlpMain.Controls.Add(pnlRegister, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1040, 774);
            tlpMain.TabIndex = 1;
            // 
            // pnlPrand
            // 
            pnlPrand.BackColor = Color.FromArgb(25, 41, 82);
            pnlPrand.Controls.Add(picChart);
            pnlPrand.Controls.Add(label3);
            pnlPrand.Controls.Add(LBLPersonal);
            pnlPrand.Controls.Add(lblMyfinance);
            pnlPrand.Dock = DockStyle.Fill;
            pnlPrand.Location = new Point(0, 0);
            pnlPrand.Margin = new Padding(0);
            pnlPrand.Name = "pnlPrand";
            pnlPrand.Padding = new Padding(45, 0, 45, 0);
            pnlPrand.Size = new Size(416, 774);
            pnlPrand.TabIndex = 4;
            // 
            // picChart
            // 
            picChart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picChart.Image = Properties.Resources.chart;
            picChart.Location = new Point(45, 450);
            picChart.Name = "picChart";
            picChart.Size = new Size(332, 270);
            picChart.SizeMode = PictureBoxSizeMode.Zoom;
            picChart.TabIndex = 4;
            picChart.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(214, 222, 239);
            label3.Location = new Point(65, 300);
            label3.Name = "label3";
            label3.Size = new Size(400, 38);
            label3.TabIndex = 2;
            label3.Text = "A Cleaner View of your money.";
            // 
            // LBLPersonal
            // 
            LBLPersonal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBLPersonal.ForeColor = Color.FromArgb(214, 222, 239);
            LBLPersonal.Location = new Point(65, 220);
            LBLPersonal.Name = "LBLPersonal";
            LBLPersonal.Size = new Size(300, 45);
            LBLPersonal.TabIndex = 1;
            LBLPersonal.Text = "PERSONAL FINANCE";
            // 
            // lblMyfinance
            // 
            lblMyfinance.AutoSize = true;
            lblMyfinance.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMyfinance.ForeColor = Color.White;
            lblMyfinance.Location = new Point(65, 130);
            lblMyfinance.Name = "lblMyfinance";
            lblMyfinance.Size = new Size(307, 70);
            lblMyfinance.TabIndex = 0;
            lblMyfinance.Text = "My Finance";
            // 
            // pnlRegister
            // 
            pnlRegister.Controls.Add(lnkLogin);
            pnlRegister.Controls.Add(lblHaveAcount);
            pnlRegister.Controls.Add(btnRegister);
            pnlRegister.Controls.Add(txtConfirm);
            pnlRegister.Controls.Add(txtPassword);
            pnlRegister.Controls.Add(txtPhone);
            pnlRegister.Controls.Add(txtEmail);
            pnlRegister.Controls.Add(txtFullName);
            pnlRegister.Controls.Add(lblConfirm);
            pnlRegister.Controls.Add(lblPassword);
            pnlRegister.Controls.Add(lblPhone);
            pnlRegister.Controls.Add(lblEmail);
            pnlRegister.Controls.Add(lblFullName);
            pnlRegister.Controls.Add(lblSubtitle);
            pnlRegister.Controls.Add(lblTitle);
            pnlRegister.Dock = DockStyle.Fill;
            pnlRegister.Location = new Point(419, 3);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Padding = new Padding(20);
            pnlRegister.Size = new Size(618, 768);
            pnlRegister.TabIndex = 3;
            // 
            // lnkLogin
            // 
            lnkLogin.ActiveLinkColor = Color.FromArgb(29, 78, 216);
            lnkLogin.AutoSize = true;
            lnkLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkLogin.LinkColor = Color.FromArgb(59, 130, 246);
            lnkLogin.Location = new Point(637, 766);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(94, 32);
            lnkLogin.TabIndex = 15;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Sign In";
            // 
            // lblHaveAcount
            // 
            lblHaveAcount.AutoSize = true;
            lblHaveAcount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHaveAcount.ForeColor = Color.FromArgb(135, 145, 165);
            lblHaveAcount.Location = new Point(344, 766);
            lblHaveAcount.Name = "lblHaveAcount";
            lblHaveAcount.Size = new Size(287, 32);
            lblHaveAcount.TabIndex = 14;
            lblHaveAcount.Text = "Already have an account?";
            lblHaveAcount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegister.BackColor = Color.FromArgb(59, 130, 246);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(275, 707);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(242, 42);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Create Account";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // txtConfirm
            // 
            txtConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirm.BorderStyle = BorderStyle.FixedSingle;
            txtConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirm.ForeColor = Color.FromArgb(31, 41, 55);
            txtConfirm.Location = new Point(275, 644);
            txtConfirm.MaxLength = 15;
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '.';
            txtConfirm.PlaceholderText = "Confirm Password";
            txtConfirm.Size = new Size(242, 39);
            txtConfirm.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(31, 41, 55);
            txtPassword.Location = new Point(275, 552);
            txtPassword.MaxLength = 15;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '.';
            txtPassword.PlaceholderText = "Create Password";
            txtPassword.Size = new Size(242, 39);
            txtPassword.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.ForeColor = Color.FromArgb(31, 41, 55);
            txtPhone.Location = new Point(275, 447);
            txtPhone.MaxLength = 15;
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Enter Your Number";
            txtPhone.Size = new Size(242, 39);
            txtPhone.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(31, 41, 55);
            txtEmail.Location = new Point(275, 347);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter Your Email";
            txtEmail.Size = new Size(242, 39);
            txtEmail.TabIndex = 9;
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFullName.BackColor = Color.White;
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.ForeColor = Color.FromArgb(31, 41, 55);
            txtFullName.Location = new Point(275, 242);
            txtFullName.Margin = new Padding(0, 3, 0, 3);
            txtFullName.MaxLength = 100;
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Enter Full Name";
            txtFullName.Size = new Size(242, 39);
            txtFullName.TabIndex = 8;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirm.ForeColor = Color.FromArgb(31, 41, 55);
            lblConfirm.Location = new Point(275, 594);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(222, 32);
            lblConfirm.TabIndex = 6;
            lblConfirm.Text = "Confirm Password";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(31, 41, 55);
            lblPassword.Location = new Point(275, 502);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(122, 32);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.FromArgb(31, 41, 55);
            lblPhone.Location = new Point(275, 400);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(187, 32);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone Number";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(31, 41, 55);
            lblEmail.Location = new Point(275, 300);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(175, 32);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email Address";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFullName
            // 
            lblFullName.BackColor = Color.Transparent;
            lblFullName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.FromArgb(31, 41, 55);
            lblFullName.ImageAlign = ContentAlignment.TopLeft;
            lblFullName.Location = new Point(275, 184);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(142, 46);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name";
            lblFullName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(135, 145, 165);
            lblSubtitle.Location = new Point(175, 120);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(356, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Join MyFinance to Manage Your Money";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitle.Location = new Point(175, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(435, 67);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create Account";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 252);
            ClientSize = new Size(1040, 774);
            Controls.Add(tlpMain);
            MaximizeBox = false;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Account - MyFinance";
            WindowState = FormWindowState.Maximized;
            tlpMain.ResumeLayout(false);
            pnlPrand.ResumeLayout(false);
            pnlPrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChart).EndInit();
            pnlRegister.ResumeLayout(false);
            pnlRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tlpMain;
        private Panel pnlRegister;
        private LinkLabel lnkLogin;
        private Label lblHaveAcount;
        private Button btnRegister;
        private TextBox txtConfirm;
        private TextBox txtPassword;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private Label lblConfirm;
        private Label lblPassword;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblFullName;
        private Label lblSubtitle;
        private Label lblTitle;
        private Panel pnlPrand;
        private PictureBox picChart;
        private Label label3;
        private Label LBLPersonal;
        private Label lblMyfinance;
    }
}
