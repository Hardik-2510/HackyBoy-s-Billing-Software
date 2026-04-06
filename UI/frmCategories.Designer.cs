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
            panel1 = new Panel();
            pictureBoxClose = new PictureBox();
            lblTop = new Label();
            lblCategoryID = new Label();
            lblTitle = new Label();
            lblDescription = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
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
            panel1.Size = new Size(1348, 52);
            panel1.TabIndex = 1;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = Properties.Resources.close_btn;
            pictureBoxClose.Location = new Point(1293, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(52, 52);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxClose.TabIndex = 1;
            pictureBoxClose.TabStop = false;
            // 
            // lblTop
            // 
            lblTop.AutoSize = true;
            lblTop.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTop.ForeColor = Color.Black;
            lblTop.Location = new Point(630, 6);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(182, 38);
            lblTop.TabIndex = 0;
            lblTop.Text = "CATEGORIES";
            // 
            // lblCategoryID
            // 
            lblCategoryID.AutoSize = true;
            lblCategoryID.Font = new Font("Franklin Gothic Medium Cond", 16F);
            lblCategoryID.ForeColor = SystemColors.InfoText;
            lblCategoryID.Location = new Point(55, 97);
            lblCategoryID.Name = "lblCategoryID";
            lblCategoryID.Size = new Size(153, 37);
            lblCategoryID.TabIndex = 2;
            lblCategoryID.Text = "Category ID";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Franklin Gothic Medium Cond", 16F);
            lblTitle.ForeColor = SystemColors.InfoText;
            lblTitle.Location = new Point(55, 182);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(66, 37);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Franklin Gothic Medium Cond", 16F);
            lblDescription.ForeColor = SystemColors.InfoText;
            lblDescription.Location = new Point(55, 260);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(152, 37);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // frmCategories
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1348, 600);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(lblCategoryID);
            Controls.Add(panel1);
            ForeColor = SystemColors.HighlightText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategories";
            Text = "frmCategories";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
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
    }
}