namespace Billing_Software.UI
{
    partial class frmProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBoxClose = new PictureBox();
            lblTop = new Label();
            txtDescription = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            lblDescription = new Label();
            lblName = new Label();
            lblProductID = new Label();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblRate = new Label();
            txtRate = new TextBox();
            dgvProducts = new DataGridView();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(pictureBoxClose);
            panel1.Controls.Add(lblTop);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1291, 52);
            panel1.TabIndex = 2;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = Properties.Resources.close_btn;
            pictureBoxClose.Location = new Point(1239, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(52, 52);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxClose.TabIndex = 1;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // lblTop
            // 
            lblTop.AutoSize = true;
            lblTop.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTop.ForeColor = Color.Black;
            lblTop.Location = new Point(520, 6);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(163, 38);
            lblTop.TabIndex = 0;
            lblTop.Text = "PRODUCTS";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtDescription.Location = new Point(182, 286);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(340, 207);
            txtDescription.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtName.Location = new Point(182, 132);
            txtName.Name = "txtName";
            txtName.Size = new Size(340, 35);
            txtName.TabIndex = 12;
            // 
            // txtID
            // 
            txtID.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtID.Location = new Point(182, 65);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(340, 35);
            txtID.TabIndex = 11;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lblDescription.ForeColor = SystemColors.InfoText;
            lblDescription.Location = new Point(33, 286);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(113, 30);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Description";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lblName.ForeColor = SystemColors.InfoText;
            lblName.Location = new Point(33, 135);
            lblName.Name = "lblName";
            lblName.Size = new Size(65, 30);
            lblName.TabIndex = 9;
            lblName.Text = "Name";
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lblProductID.ForeColor = SystemColors.InfoText;
            lblProductID.Location = new Point(33, 68);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(105, 30);
            lblProductID.TabIndex = 8;
            lblProductID.Text = "Product ID";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lblCategory.ForeColor = SystemColors.InfoText;
            lblCategory.Location = new Point(33, 211);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(93, 30);
            lblCategory.TabIndex = 14;
            lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Franklin Gothic Medium Cond", 12F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(182, 208);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(340, 38);
            cmbCategory.TabIndex = 15;
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lblRate.ForeColor = SystemColors.InfoText;
            lblRate.Location = new Point(33, 518);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(55, 30);
            lblRate.TabIndex = 16;
            lblRate.Text = "Rate";
            // 
            // txtRate
            // 
            txtRate.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtRate.Location = new Point(182, 515);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(340, 35);
            txtRate.TabIndex = 17;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(545, 135);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(734, 415);
            dgvProducts.TabIndex = 18;
            dgvProducts.RowHeaderMouseClick += dgvProducts_RowHeaderMouseClick;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtSearch.Location = new Point(626, 65);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(653, 35);
            txtSearch.TabIndex = 20;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lblSearch.ForeColor = SystemColors.InfoText;
            lblSearch.Location = new Point(545, 68);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(75, 30);
            lblSearch.TabIndex = 19;
            lblSearch.Text = "Search";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Franklin Gothic Medium Cond", 12F);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(825, 568);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(251, 46);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Franklin Gothic Medium Cond", 12F);
            btnUpdate.Location = new Point(545, 568);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(251, 46);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LawnGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Franklin Gothic Medium Cond", 12F);
            btnAdd.Location = new Point(271, 568);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(251, 46);
            btnAdd.TabIndex = 31;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1291, 630);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvProducts);
            Controls.Add(txtRate);
            Controls.Add(lblRate);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(lblProductID);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProducts";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmProducts";
            Load += frmProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxClose;
        private Label lblTop;
        private TextBox txtDescription;
        private TextBox txtName;
        private TextBox txtID;
        private Label lblDescription;
        private Label lblName;
        private Label lblProductID;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblRate;
        private TextBox txtRate;
        private DataGridView dgvProducts;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
    }
}