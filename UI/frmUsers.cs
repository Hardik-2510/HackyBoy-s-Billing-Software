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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            u.first_name = txtFirstName.Text;
            u.last_name = txtLastName.Text;
            u.email = txtEmail.Text;
            u.password = txtPassword.Text;
            u.gender = cmbGender.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.username = txtUsername.Text;
            u.user_type = cmbUserType.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1;

            bool success = dal.Insert(u);

            if (success == true)
            {
                MessageBox.Show("User Successfully Created");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to Create User");
            }

            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void clear()
        {
            txtUserID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            cmbGender.Text = "";
            cmbUserType.Text = "";
        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}