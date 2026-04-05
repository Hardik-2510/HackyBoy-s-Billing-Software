using Billing_Software.BLL;
using Billing_Software.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Billing_Software.UI
{
    public partial class frmLogin : Form
    {

        LoginBLL l = new LoginBLL();
        loginDAL dal = new loginDAL();
        public static string LoggedIn;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();
            l.user_type = cmbUserType.Text.Trim();

            bool success = dal.loginCheck(l);

            if(success == true)
            {
                MessageBox.Show("Login Successful");

                switch(l.user_type)
                {
                    case "ADMIN":
                        {
                            frmAdminDashboard admin = new frmAdminDashboard();
                            LoggedIn = l.username;
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "USER":
                        {
                            frmUserDashboard user = new frmUserDashboard();
                            LoggedIn = l.username;
                            user.Show();
                            this.Hide();
                        }
                        break;

                    default:
                        {
                            MessageBox.Show("Invalid User Type");
                        }
                        break;
                }

            }
            else
            {
                MessageBox.Show("Login Failed. Try Again.");
            }
        }
    }
}
