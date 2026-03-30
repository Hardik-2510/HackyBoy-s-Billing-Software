namespace Billing_Software
{
    partial class frmAdminDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlFooter = new Panel();
            lblFooter = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStripTop = new MenuStrip();
            usersToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            lblUser = new Label();
            lblLoggedInUser = new Label();
            lblAppFName = new Label();
            label1 = new Label();
            label2 = new Label();
            pnlFooter.SuspendLayout();
            menuStripTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.Teal;
            pnlFooter.Controls.Add(lblFooter);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 880);
            pnlFooter.Margin = new Padding(2);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1478, 61);
            pnlFooter.TabIndex = 0;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFooter.ForeColor = SystemColors.ButtonFace;
            lblFooter.Location = new Point(788, 21);
            lblFooter.Margin = new Padding(2, 0, 2, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(443, 26);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Developed By Hardik Patel ( HackyBoy )";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStripTop
            // 
            menuStripTop.ImageScalingSize = new Size(24, 24);
            menuStripTop.Items.AddRange(new ToolStripItem[] { usersToolStripMenuItem, categoryToolStripMenuItem, productsToolStripMenuItem, inventoryToolStripMenuItem, transactionsToolStripMenuItem });
            menuStripTop.Location = new Point(0, 0);
            menuStripTop.Name = "menuStripTop";
            menuStripTop.Size = new Size(1478, 33);
            menuStripTop.TabIndex = 2;
            menuStripTop.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(71, 29);
            usersToolStripMenuItem.Text = "Users";
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(100, 29);
            categoryToolStripMenuItem.Text = "Category";
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(98, 29);
            productsToolStripMenuItem.Text = "Products";
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(103, 29);
            inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(124, 29);
            transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(8, 50);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(60, 28);
            lblUser.TabIndex = 3;
            lblUser.Text = "User :";
            // 
            // lblLoggedInUser
            // 
            lblLoggedInUser.AutoSize = true;
            lblLoggedInUser.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoggedInUser.ForeColor = Color.LimeGreen;
            lblLoggedInUser.Location = new Point(74, 50);
            lblLoggedInUser.Name = "lblLoggedInUser";
            lblLoggedInUser.Size = new Size(110, 28);
            lblLoggedInUser.TabIndex = 4;
            lblLoggedInUser.Text = "HackyBoy";
            // 
            // lblAppFName
            // 
            lblAppFName.AutoSize = true;
            lblAppFName.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppFName.Location = new Point(969, 496);
            lblAppFName.Name = "lblAppFName";
            lblAppFName.Size = new Size(96, 39);
            lblAppFName.TabIndex = 5;
            lblAppFName.Text = "Hacky";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(958, 525);
            label1.Name = "label1";
            label1.Size = new Size(119, 54);
            label1.TabIndex = 6;
            label1.Text = "Store";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(858, 579);
            label2.Name = "label2";
            label2.Size = new Size(319, 24);
            label2.TabIndex = 7;
            label2.Text = "Eager To Learn Something New 📖";
            // 
            // frmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 941);
            Controls.Add(label2);
            Controls.Add(lblAppFName);
            Controls.Add(label1);
            Controls.Add(lblLoggedInUser);
            Controls.Add(lblUser);
            Controls.Add(menuStripTop);
            Controls.Add(pnlFooter);
            MainMenuStrip = menuStripTop;
            Margin = new Padding(2);
            Name = "frmAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            WindowState = FormWindowState.Maximized;
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            menuStripTop.ResumeLayout(false);
            menuStripTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlFooter;
        private Label lblFooter;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStripTop;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private Label lblUser;
        private Label lblLoggedInUser;
        private Label lblAppFName;
        private Label label1;
        private Label label2;
    }
}
