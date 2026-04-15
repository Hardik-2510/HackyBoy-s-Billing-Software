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
    public partial class frmDeaCust : Form
    {
        public frmDeaCust()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DeaCustBLL dc = new DeaCustBLL();
        DeaCustDAL dcDAL = new DeaCustDAL();
        userDAL uDAL = new userDAL();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dc.type = cmbType.Text;
            dc.name = txtName.Text;
            dc.email = txtEmail.Text;
            dc.contact = txtContact.Text;
            dc.address = txtAddress.Text;
            dc.added_date = DateTime.Now;

            string loggedUsr = frmLogin.LoggedIn;
            userBLL usr = uDAL.GetIDFromUsername(loggedUsr);
            dc.added_by = usr.id;

            bool success = dcDAL.Insert(dc);
            if (success == true)
            {
                MessageBox.Show("Added Successfully !");
                clear();
                DataTable dt = dcDAL.Select();
                dgvDeaCust.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed !!");
            }
        }

        public void clear()
        {
            cmbType.Items.Clear();
            txtName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtID.Text = "";
            txtSearch.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }
    }
}
