namespace Billing_Software.UI
{
    partial class frmLogin
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
            btnLogin = new Button();
            cmbUserType = new ComboBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblUserType = new Label();
            lblPassword = new Label();
            lbUsername = new Label();
            lblHeader = new Label();
            pictureBoxClose = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(cmbUserType);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lblUserType);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lbUsername);
            panel1.Controls.Add(lblHeader);
            panel1.Location = new Point(47, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 659);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightSeaGreen;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(39, 491);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(408, 71);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // cmbUserType
            // 
            cmbUserType.Font = new Font("Franklin Gothic Medium Cond", 16F);
            cmbUserType.FormattingEnabled = true;
            cmbUserType.Items.AddRange(new object[] { "ADMIN", "USER" });
            cmbUserType.Location = new Point(39, 425);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new Size(408, 45);
            cmbUserType.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Franklin Gothic Medium Cond", 16F);
            txtPassword.Location = new Point(39, 293);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(408, 44);
            txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Franklin Gothic Medium Cond", 16F);
            txtUsername.Location = new Point(39, 180);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(408, 44);
            txtUsername.TabIndex = 4;
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.Font = new Font("Franklin Gothic Medium Cond", 16F);
            lblUserType.Location = new Point(39, 370);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(144, 37);
            lblUserType.TabIndex = 3;
            lblUserType.Text = "USER TYPE";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Franklin Gothic Medium Cond", 16F);
            lblPassword.Location = new Point(37, 253);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(156, 37);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "PASSWORD";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Franklin Gothic Medium Cond", 16F);
            lbUsername.Location = new Point(39, 140);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(154, 37);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "USERNAME";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Franklin Gothic Medium Cond", 23F);
            lblHeader.Location = new Point(169, 18);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(131, 53);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "LOGIN";
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = Properties.Resources.close_btn;
            pictureBoxClose.Location = new Point(524, 2);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(52, 52);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxClose.TabIndex = 8;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(577, 758);
            ControlBox = false;
            Controls.Add(pictureBoxClose);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblHeader;
        private Label lbUsername;
        private Label lblUserType;
        private Label lblPassword;
        private ComboBox cmbUserType;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
        private PictureBox pictureBoxClose;
    }
}