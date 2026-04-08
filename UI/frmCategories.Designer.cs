namespace Billing_Software.UI
{
    partial class frmCategories
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBoxClose = new PictureBox();
            lblTop = new Label();
            lblCategoryID = new Label();
            lblTitle = new Label();
            lblDescription = new Label();
            txtCategoryID = new TextBox();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvCategories = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
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
            panel1.Size = new Size(1193, 52);
            panel1.TabIndex = 1;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = Properties.Resources.close_btn;
            pictureBoxClose.Location = new Point(1138, 2);
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
            lblTop.Size = new Size(182, 38);
            lblTop.TabIndex = 0;
            lblTop.Text = "CATEGORIES";
            // 
            // lblCategoryID
            // 
            lblCategoryID.AutoSize = true;
            lblCategoryID.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lblCategoryID.ForeColor = SystemColors.InfoText;
            lblCategoryID.Location = new Point(55, 97);
            lblCategoryID.Name = "lblCategoryID";
            lblCategoryID.Size = new Size(116, 30);
            lblCategoryID.TabIndex = 2;
            lblCategoryID.Text = "Category ID";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lblTitle.ForeColor = SystemColors.InfoText;
            lblTitle.Location = new Point(55, 182);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(50, 30);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lblDescription.ForeColor = SystemColors.InfoText;
            lblDescription.Location = new Point(55, 260);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(113, 30);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtCategoryID.Location = new Point(204, 94);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new Size(247, 35);
            txtCategoryID.TabIndex = 5;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtTitle.Location = new Point(204, 179);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(247, 35);
            txtTitle.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtDescription.Location = new Point(204, 260);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(247, 207);
            txtDescription.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Franklin Gothic Medium Cond", 12F);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(754, 489);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(251, 46);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Franklin Gothic Medium Cond", 12F);
            btnUpdate.Location = new Point(474, 489);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(251, 46);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LawnGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Franklin Gothic Medium Cond", 12F);
            btnAdd.Location = new Point(200, 489);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(251, 46);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtSearch.Location = new Point(573, 94);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(585, 35);
            txtSearch.TabIndex = 33;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = SystemColors.InfoText;
            lblSearch.Location = new Point(492, 97);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(75, 30);
            lblSearch.TabIndex = 32;
            lblSearch.Text = "Search";
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvCategories.DefaultCellStyle = dataGridViewCellStyle1;
            dgvCategories.Location = new Point(492, 158);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersWidth = 62;
            dgvCategories.Size = new Size(666, 309);
            dgvCategories.TabIndex = 34;
            dgvCategories.RowHeaderMouseClick += dgvCategories_RowHeaderMouseClick_1;
            // 
            // frmCategories
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1193, 551);
            Controls.Add(dgvCategories);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(txtCategoryID);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(lblCategoryID);
            Controls.Add(panel1);
            ForeColor = SystemColors.HighlightText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategories";
            Load += frmCategories_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxClose;
        private Label lblTop;
        private Label lblCategoryID;
        private Label lblTitle;
        private Label lblDescription;
        private TextBox txtCategoryID;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvCategories;
    }
}