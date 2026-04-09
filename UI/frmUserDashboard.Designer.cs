namespace Billing_Software
{
    partial class frmUserDashboard
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
            menuStrip1 = new MenuStrip();
            purchaseToolStripMenuItem = new ToolStripMenuItem();
            salesFormsToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            lblAppFName = new Label();
            label1 = new Label();
            lblLoggedInUser = new Label();
            lblUser = new Label();
            pnlFooter = new Panel();
            lblFooter = new Label();
            ealerAndCustomerToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { purchaseToolStripMenuItem, salesFormsToolStripMenuItem, inventoryToolStripMenuItem, ealerAndCustomerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1701, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // purchaseToolStripMenuItem
            // 
            purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            purchaseToolStripMenuItem.Size = new Size(98, 29);
            purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // salesFormsToolStripMenuItem
            // 
            salesFormsToolStripMenuItem.Name = "salesFormsToolStripMenuItem";
            salesFormsToolStripMenuItem.Size = new Size(68, 29);
            salesFormsToolStripMenuItem.Text = "Sales";
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(103, 29);
            inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(847, 556);
            label2.Name = "label2";
            label2.Size = new Size(319, 24);
            label2.TabIndex = 12;
            label2.Text = "Eager To Learn Something New 📖";
            // 
            // lblAppFName
            // 
            lblAppFName.AutoSize = true;
            lblAppFName.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppFName.Location = new Point(958, 473);
            lblAppFName.Name = "lblAppFName";
            lblAppFName.Size = new Size(96, 39);
            lblAppFName.TabIndex = 10;
            lblAppFName.Text = "Hacky";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(947, 502);
            label1.Name = "label1";
            label1.Size = new Size(119, 54);
            label1.TabIndex = 11;
            label1.Text = "Store";
            // 
            // lblLoggedInUser
            // 
            lblLoggedInUser.AutoSize = true;
            lblLoggedInUser.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoggedInUser.ForeColor = Color.LimeGreen;
            lblLoggedInUser.Location = new Point(94, 58);
            lblLoggedInUser.Name = "lblLoggedInUser";
            lblLoggedInUser.Size = new Size(0, 28);
            lblLoggedInUser.TabIndex = 9;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(28, 58);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(60, 28);
            lblUser.TabIndex = 8;
            lblUser.Text = "User :";
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.Teal;
            pnlFooter.Controls.Add(lblFooter);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 793);
            pnlFooter.Margin = new Padding(2);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1701, 61);
            pnlFooter.TabIndex = 13;
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
            // ealerAndCustomerToolStripMenuItem
            // 
            ealerAndCustomerToolStripMenuItem.Name = "ealerAndCustomerToolStripMenuItem";
            ealerAndCustomerToolStripMenuItem.Size = new Size(198, 29);
            ealerAndCustomerToolStripMenuItem.Text = "Dealer And Customer";
            ealerAndCustomerToolStripMenuItem.Click += DealerAndCustomerToolStripMenuItem_Click;
            // 
            // frmUserDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1701, 854);
            Controls.Add(pnlFooter);
            Controls.Add(label2);
            Controls.Add(lblAppFName);
            Controls.Add(label1);
            Controls.Add(lblLoggedInUser);
            Controls.Add(lblUser);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmUserDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Dashboard";
            WindowState = FormWindowState.Maximized;
            FormClosed += frmUserDashboard_FormClosed;
            Load += frmUserDashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem purchaseToolStripMenuItem;
        private ToolStripMenuItem salesFormsToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private Label label2;
        private Label lblAppFName;
        private Label label1;
        private Label lblLoggedInUser;
        private Label lblUser;
        private Panel pnlFooter;
        private Label lblFooter;
        private ToolStripMenuItem ealerAndCustomerToolStripMenuItem;
    }
}