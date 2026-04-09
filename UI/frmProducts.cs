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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        productDAL pdal = new productDAL();
        productsBLL p = new productsBLL();
        categoriesDAL cdal = new categoriesDAL();
        userDAL udal = new userDAL();

        private void frmProducts_Load(object sender, EventArgs e)
        {
            DataTable categoryDT = cdal.Select();
            cmbCategory.DataSource = categoryDT;
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = (int)decimal.Parse(txtRate.Text);
            p.qty = 0; // Default quantity for new products
            p.added_date = DateTime.Now;

            string loggedInUser = frmLogin.LoggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedInUser);
            p.added_by = usr.id; // Replace with the actual user ID


            bool success = pdal.Insert(p);
            if (success)
            {
                MessageBox.Show("Product added successfully.");
                clear();
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to add product.");
            }
        }

        public void clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            cmbCategory.Text = "";
            txtDescription.Text = "";
            txtRate.Text = "";
        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtID.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
            cmbCategory.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgvProducts.Rows[rowIndex].Cells[3].Value.ToString();
            txtRate.Text = dgvProducts.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(txtID.Text);
            p.name = txtName.Text;
            p.description = txtDescription.Text;
            p.category = cmbCategory.Text;
            p.rate = (int)decimal.Parse(txtRate.Text);
            p.added_date = DateTime.Now;

            string loggedInUser = frmLogin.LoggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedInUser);

            p.added_by = usr.id; // Replace with the actual user ID

            bool success = pdal.Update(p);
            if (success)
            {
                MessageBox.Show("Product updated successfully.");
                clear();
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to update product.");
                clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(txtID.Text);

            bool success = pdal.Delete(p);
            if (success)
            {
                MessageBox.Show("Product deleted successfully.");
                clear();

                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to delete product.");
                clear();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = pdal.Search(keywords);
                dgvProducts.DataSource = dt;
            }
            else
            {
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
        }
    }
}
