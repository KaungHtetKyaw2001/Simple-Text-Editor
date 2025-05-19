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
    public partial class frmUser : Form
    {
        dsTextEditiorTableAdapters.UsersTableAdapter udts = new dsTextEditiorTableAdapters.UsersTableAdapter();
        public frmUser()
        {
            InitializeComponent();
        }
        private void AutoID()
        {
            DataTable dt = new DataTable();
            dt = udts.GetData();
            if (dt.Rows.Count == 0)
            {
                lblUserID.Text = "U_00001";
            }
            else
            {
                int size = dt.Rows.Count - 1;
                string oldid = dt.Rows[size][0].ToString();
                int newid = Convert.ToInt16(oldid.Substring(2, 5));
                if (newid >= 1 && newid <= 9)
                {
                    lblUserID.Text = "U_0000" + (newid + 1);
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            clsUserRegister ur = new clsUserRegister();
            ur.UID=lblUserID.Text;
            ur.UName=txtUserName.Text;
            ur.UAge=txtAge.Text;
            ur.UAddress = txtaddress.Text;
            ur.UEmail = txtEmail.Text;
            ur.UPassword = txtPassword.Text;
            ur.UPhone = txtPhoneNumber.Text;
            if (txtUserName.Text=="")
            {
                MessageBox.Show("Please Enter User's Name","User Register",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                txtUserName.Focus();
            }
            else if (txtAge.Text=="")
            {
                MessageBox.Show("Please Enter User's Age","User Register",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                txtAge.Focus();
            }
            else if (txtPhoneNumber.Text=="")
            {
                MessageBox.Show("Please Enter User's Phone Number","User Register",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
            }
            else if (txtEmail.Text=="")
            {
                MessageBox.Show("Please Enter User's Email Address","User Register",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                txtEmail.Focus();
            }
            else if (txtPassword.Text=="")
            {
                MessageBox.Show("Please Enter User's Password","User Register",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else if (txtaddress.Text == "")
            {
                MessageBox.Show("Please Enter User's Address", "User Register", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtaddress.Focus();
            }
            else
            {
                int result = udts.RegisterUserData(ur.UID, ur.UName, ur.UEmail, ur.UPassword, ur.UAddress, Convert.ToInt32(ur.UAge), ur.UPhone);
                if (result > 0)
                {
                    MessageBox.Show("User Registered Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserName.Focus();
                    txtUserName.Text = "";
                    txtAge.Text = "";
                    txtPhoneNumber.Text = "";
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                    txtaddress.Text = "";
                    //frmSimpleTextEditior fste = new frmSimpleTextEditior();
                    //fste.Show();
                }

            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            AutoID();
        }
    }
}
