namespace Billing_Software.UI
{
    partial class frmUsers
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
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtContact = new TextBox();
            lblContact = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            lblGender = new Label();
            cmbGender = new ComboBox();
            cmbUserType = new ComboBox();
            lblUserType = new Label();
            txtUserID = new TextBox();
            lblUserID = new Label();
            dgvUsers = new DataGridView();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
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
            panel1.Size = new Size(1330, 52);
            panel1.TabIndex = 0;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = Properties.Resources.close_btn;
            pictureBoxClose.Location = new Point(1278, 0);
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
            lblTop.Location = new Point(630, 6);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(102, 38);
            lblTop.TabIndex = 0;
            lblTop.Text = "USERS";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(51, 154);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(107, 30);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtFirstName.Location = new Point(209, 154);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(249, 35);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtLastName.Location = new Point(209, 207);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(249, 35);
            txtLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(51, 207);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(106, 30);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtEmail.Location = new Point(209, 264);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(249, 35);
            txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(51, 264);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 30);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtUsername.Location = new Point(209, 325);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(249, 35);
            txtUsername.TabIndex = 9;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(51, 325);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(103, 30);
            lblUsername.TabIndex = 8;
            lblUsername.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtPassword.Location = new Point(209, 389);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(249, 35);
            txtPassword.TabIndex = 11;
            txtPassword.TextChanged += textBox1_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(51, 389);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(96, 30);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtContact.Location = new Point(209, 459);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(249, 35);
            txtContact.TabIndex = 13;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContact.Location = new Point(51, 459);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(83, 30);
            lblContact.TabIndex = 12;
            lblContact.Text = "Contact";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtAddress.Location = new Point(209, 525);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(249, 132);
            txtAddress.TabIndex = 15;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(51, 525);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(83, 30);
            lblAddress.TabIndex = 14;
            lblAddress.Text = "Address";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(51, 684);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(78, 30);
            lblGender.TabIndex = 16;
            lblGender.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Franklin Gothic Medium Cond", 12F);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Not Specified" });
            cmbGender.Location = new Point(207, 681);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(251, 38);
            cmbGender.TabIndex = 17;
            // 
            // cmbUserType
            // 
            cmbUserType.Font = new Font("Franklin Gothic Medium Cond", 12F);
            cmbUserType.FormattingEnabled = true;
            cmbUserType.Items.AddRange(new object[] { "Admin", "User" });
            cmbUserType.Location = new Point(207, 734);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new Size(251, 38);
            cmbUserType.TabIndex = 19;
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserType.Location = new Point(51, 737);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(97, 30);
            lblUserType.TabIndex = 18;
            lblUserType.Text = "User Type";
            // 
            // txtUserID
            // 
            txtUserID.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtUserID.Location = new Point(209, 99);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(249, 35);
            txtUserID.TabIndex = 21;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(51, 99);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(76, 30);
            lblUserID.TabIndex = 20;
            lblUserID.Text = "User ID";
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(481, 154);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.Size = new Size(837, 618);
            dgvUsers.TabIndex = 22;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txtSearch.Location = new Point(578, 99);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(740, 35);
            txtSearch.TabIndex = 24;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(497, 102);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(75, 30);
            lblSearch.TabIndex = 23;
            lblSearch.Text = "Search";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LawnGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Franklin Gothic Medium Cond", 12F);
            btnAdd.Location = new Point(207, 795);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(251, 46);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Franklin Gothic Medium Cond", 12F);
            btnUpdate.Location = new Point(481, 795);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(251, 46);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Franklin Gothic Medium Cond", 12F);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(761, 795);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(251, 46);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1330, 859);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvUsers);
            Controls.Add(txtUserID);
            Controls.Add(lblUserID);
            Controls.Add(cmbUserType);
            Controls.Add(lblUserType);
            Controls.Add(cmbGender);
            Controls.Add(lblGender);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmUsers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTop;
        private PictureBox pictureBoxClose;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtUsername;
        private Label lblUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtContact;
        private Label lblContact;
        private TextBox txtAddress;
        private Label lblAddress;
        private Label lblGender;
        private ComboBox cmbGender;
        private ComboBox cmbUserType;
        private Label lblUserType;
        private TextBox txtUserID;
        private Label lblUserID;
        private DataGridView dgvUsers;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}