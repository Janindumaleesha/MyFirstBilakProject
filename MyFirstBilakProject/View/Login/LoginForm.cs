using MyFirstBilakProject.View.Home;
using MyFirstBilakProject.View.PasswordRecovery;
using MyFirstBilakProject.View.Register;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstBilakProject.View.Login
{
    public partial class LoginForm : Form
    {
        private static LoginForm _instance;
        public LoginForm()
        {
            InitializeComponent();
        }

        public static LoginForm loginForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new LoginForm();
                return _instance;
            }
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        private void kryptonLinkLabel2_LinkClicked(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            PasswordRecoveryAccessForm passwordRecoveryAccessForm = new PasswordRecoveryAccessForm();
            passwordRecoveryAccessForm.Show();
        }
    }
}
