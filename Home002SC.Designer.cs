namespace RESTAURANT
{
    partial class Home002SC
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem = new ToolStripMenuItem();
            bookingToolStripMenuItem = new ToolStripMenuItem();
            dashBoardToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            dailyPaymentToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            panelPage = new Panel();
            panel1 = new Panel();
            txtTime = new Label();
            userName = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, menuToolStripMenuItem, bookingToolStripMenuItem, dashBoardToolStripMenuItem, accountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1618, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // bookingToolStripMenuItem
            // 
            bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            bookingToolStripMenuItem.Size = new Size(78, 24);
            bookingToolStripMenuItem.Text = "Booking";
            bookingToolStripMenuItem.Click += bookingToolStripMenuItem_Click;
            // 
            // dashBoardToolStripMenuItem
            // 
            dashBoardToolStripMenuItem.Name = "dashBoardToolStripMenuItem";
            dashBoardToolStripMenuItem.Size = new Size(100, 24);
            dashBoardToolStripMenuItem.Text = "Dash Board";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dailyPaymentToolStripMenuItem, reportToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(77, 24);
            accountToolStripMenuItem.Text = "Account";
            // 
            // dailyPaymentToolStripMenuItem
            // 
            dailyPaymentToolStripMenuItem.Name = "dailyPaymentToolStripMenuItem";
            dailyPaymentToolStripMenuItem.Size = new Size(186, 26);
            dailyPaymentToolStripMenuItem.Text = "Daily Payment";
            dailyPaymentToolStripMenuItem.Click += dailyPaymentToolStripMenuItem_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(186, 26);
            reportToolStripMenuItem.Text = "Report";
            // 
            // panelPage
            // 
            panelPage.BackColor = Color.FromArgb(224, 224, 224);
            panelPage.Location = new Point(8, 40);
            panelPage.Name = "panelPage";
            panelPage.Size = new Size(1600, 832);
            panelPage.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTime);
            panel1.Controls.Add(userName);
            panel1.Location = new Point(8, 888);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 56);
            panel1.TabIndex = 2;
            // 
            // txtTime
            // 
            txtTime.AutoSize = true;
            txtTime.BackColor = Color.FromArgb(255, 255, 192);
            txtTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTime.Location = new Point(1504, 8);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(86, 28);
            txtTime.TabIndex = 1;
            txtTime.Text = "11:11:11";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userName.Location = new Point(1296, 8);
            userName.Name = "userName";
            userName.Size = new Size(163, 28);
            userName.TabIndex = 0;
            userName.Text = "My name's Saven";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Home002SC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1618, 948);
            Controls.Add(panel1);
            Controls.Add(panelPage);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1636, 1000);
            Name = "Home002SC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home002SC";
            Load += Home002SC_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem bookingToolStripMenuItem;
        private ToolStripMenuItem dashBoardToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem dailyPaymentToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private Panel panelPage;
        private Panel panel1;
        private Label userName;
        private System.Windows.Forms.Timer timer1;
        private Label txtTime;
    }
}