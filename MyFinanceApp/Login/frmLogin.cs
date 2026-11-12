using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyFinance.Login
{

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            btnLogin.Click += btnLogin_Click;
        }
        private void btnLogin_Click(object? sender, EventArgs e)
            {
                Form1 main = new Form1();

                main.FormClosed += (_, _) => Close();

                main.Show();
                Hide();
            }
        private void lnkRegister_LinkClicked(
            object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister register = new frmRegister(this);
            register.Show();
            Hide();
        }
    }
}
