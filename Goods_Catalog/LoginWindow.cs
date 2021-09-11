using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goods_Catalog
{
    public partial class LoginWindow : Form
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Login = username_textBox.Text;
            Password = password_textBox.Text;
            if (String.IsNullOrWhiteSpace(Login) || String.IsNullOrWhiteSpace(Password))
                MessageBox.Show("Login or password is null", "Wrong data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                this.DialogResult = DialogResult.OK;
            }
    }
}
