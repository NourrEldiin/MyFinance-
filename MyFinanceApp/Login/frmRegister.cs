namespace MyFinance.Login
{
    public partial class frmRegister : Form
    {
        private readonly frmLogin loginForm;

        public frmRegister(frmLogin login)
        {
            InitializeComponent();

            loginForm = login;

            FormClosed += (_, _) =>
            {
                if (!loginForm.IsDisposed)
                    loginForm.Show();
            };
        }

        private void lnkLogin_LinkClicked(
            object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
