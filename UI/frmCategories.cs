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
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        categoriesBLL c = new categoriesBLL();
        categoriesDAL dal = new categoriesDAL();
        userDAL user = new userDAL();

        private void frmCategories_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            c.title = txtTitle.Text;
            c.Description = txtDescription.Text;
            c.added_date = DateTime.Now;

            string loggedUser = frmLogin.LoggedIn;
            userBLL usr = user.GetIDFromUsername(loggedUser);
            c.added_by = usr.id;

            bool success = dal.Insert(c);

            if (success == true)
            {
                MessageBox.Show("New Category Added Successfully !!");
                clear();
            }
            else
            {
                MessageBox.Show("Failed To Add Category !!");
            }
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;
        }

        public void clear()
        {
            txtCategoryID.Text = "";
            txtDescription.Text = "";
            txtTitle.Text = "";
            txtSearch.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(txtCategoryID.Text);
            c.title = txtTitle.Text;
            c.Description = txtDescription.Text;
            c.added_date = DateTime.Now;

            string loggedUser = frmLogin.LoggedIn;
            userBLL usr = user.GetIDFromUsername(loggedUser);
            c.added_by = usr.id;

            bool success = dal.Update(c);

            if (success == true)
            {
                MessageBox.Show("Updated Successfully !!");
                clear();
            }
            else
            {
                MessageBox.Show("Updatation Failed !!");
                clear();
            }
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(txtCategoryID.Text);

            bool success = dal.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Category Removed Successfully !!");
                clear();
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Category Not Removed !!");
                clear();
            }
        }

        private void dgvCategories_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtCategoryID.Text = dgvCategories.Rows[RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dgvCategories.Rows[RowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[RowIndex].Cells[2].Value.ToString();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            if(keyword != null)
            {
                DataTable dt = dal.Search(keyword);
                dgvCategories.DataSource= dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
        }
    }
}
