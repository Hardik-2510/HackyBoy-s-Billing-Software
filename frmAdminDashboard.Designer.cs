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
            pnlFooter = new Panel();
            lblFooter = new Label();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.Teal;
            pnlFooter.Controls.Add(lblFooter);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 607);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1563, 61);
            pnlFooter.TabIndex = 0;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFooter.ForeColor = SystemColors.ButtonFace;
            lblFooter.Location = new Point(586, 14);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(443, 26);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Developed By Hardik Patel ( HackyBoy )";
            // 
            // frmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1563, 668);
            Controls.Add(pnlFooter);
            Name = "frmAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            WindowState = FormWindowState.Maximized;
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFooter;
        private Label lblFooter;
    }
}
