using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstBilakProject.View.PasswordRecovery
{
    public partial class PasswordRecoveryAccessForm : Form
    {
        public PasswordRecoveryAccessForm()
        {
            InitializeComponent();
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            PasswordRecoveryForm passwordRecoveryForm = new PasswordRecoveryForm();
            passwordRecoveryForm.Show();
        }
    }
}
