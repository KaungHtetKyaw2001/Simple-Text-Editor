using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTextEditor_L4DC_124_
{
    public partial class frmLogin : Form
    {
        dsTextEditiorTableAdapters.UsersTableAdapter udts = new dsTextEditiorTableAdapters.UsersTableAdapter();
        public static string uid,uname;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            frmUser fu = new frmUser();
            fu.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (txtUserID.Text=="")
            {
                MessageBox.Show("Please Enter your User's ID", " User Login Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserID.Focus();
            }
            else if (txtUsername.Text=="")
            {
                MessageBox.Show("Please enter your name", "User Login Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter your Email", "User Login Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your password", "User Login Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else
            {
               dt= udts.CheckUserLogin(txtEmail.Text, txtPassword.Text);
                if (dt.Rows.Count > 0)
                {
                    uid=dt.Rows[0][0].ToString();
                    uname = dt.Rows[0][1].ToString();
                    MessageBox.Show("User logged in successfully", "User login Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmSimpleTextEditior fste = new frmSimpleTextEditior();
                    fste.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid User Login", "User Login Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
