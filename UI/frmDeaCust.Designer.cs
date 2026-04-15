namespace Billing_Software.UI
{
    partial class frmDeaCust
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
            txtID = new TextBox();
            lblType = new Label();
            lblDeaCust = new Label();
            cmbType = new ComboBox();
            txtName = new TextBox();
            lblName = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtContact = new TextBox();
            lblContact = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            dgvDeaCust = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeaCust).BeginInit();
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
            panel1.Size = new Size(1293, 52);
            panel1.TabIndex = 3;
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
            lblTop.Size = new Size(298, 38);
            lblTop.TabIndex = 0;
            lblTop.Text = "Dealer And Customer";
            // 
            // txtID
            // 
            txtID.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtID.Location = new Point(185, 79);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(340, 35);
            txtID.TabIndex = 15;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lblType.ForeColor = SystemColors.InfoText;
            lblType.Location = new Point(36, 133);
            lblType.Name = "lblType";
            lblType.Size = new Size(53, 30);
            lblType.TabIndex = 14;
            lblType.Text = "Type";
            // 
            // lblDeaCust
            // 
            lblDeaCust.AutoSize = true;
            lblDeaCust.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lblDeaCust.ForeColor = SystemColors.InfoText;
            lblDeaCust.Location = new Point(36, 82);
            lblDeaCust.Name = "lblDeaCust";
            lblDeaCust.Size = new Size(122, 30);
            lblDeaCust.TabIndex = 13;
            lblDeaCust.Text = "Dea/Cust ID";
            // 
            // cmbType
            // 
            cmbType.Font = new Font("Franklin Gothic Medium Cond", 12F);
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Dealer", "Customer" });
            cmbType.Location = new Point(185, 130);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(340, 38);
            cmbType.TabIndex = 16;
            // 
            // txtName
            // 
            txtName.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtName.Location = new Point(185, 184);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(340, 35);
            txtName.TabIndex = 18;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lblName.ForeColor = SystemColors.InfoText;
            lblName.Location = new Point(36, 187);
            lblName.Name = "lblName";
            lblName.Size = new Size(65, 30);
            lblName.TabIndex = 17;
            lblName.Text = "Name";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtEmail.Location = new Point(185, 238);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(340, 35);
            txtEmail.TabIndex = 20;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lblEmail.ForeColor = SystemColors.InfoText;
            lblEmail.Location = new Point(39, 241);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 30);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "Email";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtContact.Location = new Point(185, 292);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(340, 35);
            txtContact.TabIndex = 22;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lblContact.ForeColor = SystemColors.InfoText;
            lblContact.Location = new Point(39, 295);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(83, 30);
            lblContact.TabIndex = 21;
            lblContact.Text = "Contact";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtAddress.Location = new Point(185, 349);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(340, 153);
            txtAddress.TabIndex = 24;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lblAddress.ForeColor = SystemColors.InfoText;
            lblAddress.Location = new Point(39, 352);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(83, 30);
            lblAddress.TabIndex = 23;
            lblAddress.Text = "Address";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Franklin Gothic Medium Cond", 12F);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(831, 519);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(251, 46);
            btnDelete.TabIndex = 36;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Franklin Gothic Medium Cond", 12F);
            btnUpdate.Location = new Point(551, 519);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(251, 46);
            btnUpdate.TabIndex = 35;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LawnGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Franklin Gothic Medium Cond", 12F);
            btnAdd.Location = new Point(277, 519);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(251, 46);
            btnAdd.TabIndex = 34;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtSearch.Location = new Point(632, 79);
            txtSearch.Name = "txtSearch";
            txtSearch.ReadOnly = true;
            txtSearch.Size = new Size(641, 35);
            txtSearch.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 12F);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(551, 82);
            label1.Name = "label1";
            label1.Size = new Size(75, 30);
            label1.TabIndex = 37;
            label1.Text = "Search";
            // 
            // dgvDeaCust
            // 
            dgvDeaCust.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeaCust.Location = new Point(551, 133);
            dgvDeaCust.Name = "dgvDeaCust";
            dgvDeaCust.RowHeadersWidth = 62;
            dgvDeaCust.Size = new Size(722, 369);
            dgvDeaCust.TabIndex = 39;
            // 
            // frmDeaCust
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1293, 582);
            Controls.Add(dgvDeaCust);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(cmbType);
            Controls.Add(txtID);
            Controls.Add(lblType);
            Controls.Add(lblDeaCust);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDeaCust";
            StartPosition = FormStartPosition.CenterParent;
            Text = " ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeaCust).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxClose;
        private Label lblTop;
        private TextBox txtID;
        private Label lblType;
        private Label lblDeaCust;
        private ComboBox cmbType;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtContact;
        private Label lblContact;
        private TextBox txtAddress;
        private Label lblAddress;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgvDeaCust;
    }
}