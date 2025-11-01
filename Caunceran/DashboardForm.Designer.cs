namespace Caunceran
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelSummary1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblAssetCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalAssets = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picAssetsIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelSummary2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblAssignedToday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAssigned = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picAssignIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTitleAssigned = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblUpcomingMaintenance = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ygd = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblOverdueAlerts = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelSummary1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAssetsIcon)).BeginInit();
            this.panelSummary2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAssignIcon)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(383, 22);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(604, 39);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Asset Management System";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(107, 23);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(129, 34);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total Asset";
            // 
            // panelSummary1
            // 
            this.panelSummary1.BackColor = System.Drawing.Color.Transparent;
            this.panelSummary1.BorderColor = System.Drawing.Color.Black;
            this.panelSummary1.BorderRadius = 5;
            this.panelSummary1.BorderThickness = 2;
            this.panelSummary1.Controls.Add(this.lblAssetCount);
            this.panelSummary1.Controls.Add(this.lblTotalAssets);
            this.panelSummary1.Controls.Add(this.picAssetsIcon);
            this.panelSummary1.Controls.Add(this.lblTotal);
            this.panelSummary1.FillColor = System.Drawing.Color.SteelBlue;
            this.panelSummary1.FillColor2 = System.Drawing.Color.DarkSlateGray;
            this.panelSummary1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSummary1.Location = new System.Drawing.Point(191, 221);
            this.panelSummary1.Name = "panelSummary1";
            this.panelSummary1.Size = new System.Drawing.Size(336, 187);
            this.panelSummary1.TabIndex = 2;
            // 
            // lblAssetCount
            // 
            this.lblAssetCount.BackColor = System.Drawing.Color.Transparent;
            this.lblAssetCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetCount.Location = new System.Drawing.Point(28, 94);
            this.lblAssetCount.Name = "lblAssetCount";
            this.lblAssetCount.Size = new System.Drawing.Size(26, 56);
            this.lblAssetCount.TabIndex = 4;
            this.lblAssetCount.Text = "0";
            this.lblAssetCount.Click += new System.EventHandler(this.lblAssetCount_Click);
            // 
            // lblTotalAssets
            // 
            this.lblTotalAssets.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAssets.Location = new System.Drawing.Point(28, 82);
            this.lblTotalAssets.Name = "lblTotalAssets";
            this.lblTotalAssets.Size = new System.Drawing.Size(3, 2);
            this.lblTotalAssets.TabIndex = 3;
            this.lblTotalAssets.Text = null;
            // 
            // picAssetsIcon
            // 
            this.picAssetsIcon.Image = ((System.Drawing.Image)(resources.GetObject("picAssetsIcon.Image")));
            this.picAssetsIcon.ImageRotate = 0F;
            this.picAssetsIcon.Location = new System.Drawing.Point(47, 13);
            this.picAssetsIcon.Name = "picAssetsIcon";
            this.picAssetsIcon.Size = new System.Drawing.Size(54, 53);
            this.picAssetsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAssetsIcon.TabIndex = 2;
            this.picAssetsIcon.TabStop = false;
            this.picAssetsIcon.Click += new System.EventHandler(this.picAssetsIcon_Click);
            // 
            // panelSummary2
            // 
            this.panelSummary2.BackColor = System.Drawing.Color.Transparent;
            this.panelSummary2.BorderColor = System.Drawing.Color.Black;
            this.panelSummary2.BorderRadius = 5;
            this.panelSummary2.BorderThickness = 2;
            this.panelSummary2.Controls.Add(this.lblAssignedToday);
            this.panelSummary2.Controls.Add(this.lblAssigned);
            this.panelSummary2.Controls.Add(this.picAssignIcon);
            this.panelSummary2.Controls.Add(this.lblTitleAssigned);
            this.panelSummary2.FillColor = System.Drawing.Color.SteelBlue;
            this.panelSummary2.FillColor2 = System.Drawing.Color.DarkSlateGray;
            this.panelSummary2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSummary2.Location = new System.Drawing.Point(657, 221);
            this.panelSummary2.Name = "panelSummary2";
            this.panelSummary2.Size = new System.Drawing.Size(343, 187);
            this.panelSummary2.TabIndex = 3;
            // 
            // lblAssignedToday
            // 
            this.lblAssignedToday.BackColor = System.Drawing.Color.Transparent;
            this.lblAssignedToday.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignedToday.Location = new System.Drawing.Point(28, 94);
            this.lblAssignedToday.Name = "lblAssignedToday";
            this.lblAssignedToday.Size = new System.Drawing.Size(26, 56);
            this.lblAssignedToday.TabIndex = 9;
            this.lblAssignedToday.Text = "0";
            // 
            // lblAssigned
            // 
            this.lblAssigned.BackColor = System.Drawing.Color.Transparent;
            this.lblAssigned.Location = new System.Drawing.Point(28, 94);
            this.lblAssigned.Name = "lblAssigned";
            this.lblAssigned.Size = new System.Drawing.Size(3, 2);
            this.lblAssigned.TabIndex = 3;
            this.lblAssigned.Text = null;
            // 
            // picAssignIcon
            // 
            this.picAssignIcon.Image = ((System.Drawing.Image)(resources.GetObject("picAssignIcon.Image")));
            this.picAssignIcon.ImageRotate = 0F;
            this.picAssignIcon.Location = new System.Drawing.Point(38, 13);
            this.picAssignIcon.Name = "picAssignIcon";
            this.picAssignIcon.Size = new System.Drawing.Size(59, 61);
            this.picAssignIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAssignIcon.TabIndex = 2;
            this.picAssignIcon.TabStop = false;
            // 
            // lblTitleAssigned
            // 
            this.lblTitleAssigned.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleAssigned.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAssigned.Location = new System.Drawing.Point(103, 23);
            this.lblTitleAssigned.Name = "lblTitleAssigned";
            this.lblTitleAssigned.Size = new System.Drawing.Size(184, 34);
            this.lblTitleAssigned.TabIndex = 1;
            this.lblTitleAssigned.Text = " Assigned Today\r\n";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(476, 85);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(416, 40);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "TechLease Solutions Dashboard";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.guna2GradientPanel1.BorderRadius = 5;
            this.guna2GradientPanel1.BorderThickness = 2;
            this.guna2GradientPanel1.Controls.Add(this.lblUpcomingMaintenance);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2GradientPanel1.Controls.Add(this.ygd);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.DarkSlateGray;
            this.guna2GradientPanel1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(141, 500);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(431, 205);
            this.guna2GradientPanel1.TabIndex = 4;
            // 
            // lblUpcomingMaintenance
            // 
            this.lblUpcomingMaintenance.BackColor = System.Drawing.Color.Transparent;
            this.lblUpcomingMaintenance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcomingMaintenance.Location = new System.Drawing.Point(82, 108);
            this.lblUpcomingMaintenance.Name = "lblUpcomingMaintenance";
            this.lblUpcomingMaintenance.Size = new System.Drawing.Size(26, 56);
            this.lblUpcomingMaintenance.TabIndex = 9;
            this.lblUpcomingMaintenance.Text = "0";
            this.lblUpcomingMaintenance.Click += new System.EventHandler(this.guna2HtmlLabel12_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(28, 94);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = null;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(28, 13);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(61, 66);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ygd
            // 
            this.ygd.BackColor = System.Drawing.Color.Transparent;
            this.ygd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ygd.Location = new System.Drawing.Point(101, 22);
            this.ygd.Name = "ygd";
            this.ygd.Size = new System.Drawing.Size(276, 34);
            this.ygd.TabIndex = 1;
            this.ygd.Text = "Upcoming \r\n\r\nMaintenance";
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel2.BorderColor = System.Drawing.Color.Black;
            this.guna2GradientPanel2.BorderRadius = 5;
            this.guna2GradientPanel2.BorderThickness = 2;
            this.guna2GradientPanel2.Controls.Add(this.lblOverdueAlerts);
            this.guna2GradientPanel2.Controls.Add(this.guna2HtmlLabel4);
            this.guna2GradientPanel2.Controls.Add(this.guna2PictureBox2);
            this.guna2GradientPanel2.Controls.Add(this.guna2HtmlLabel5);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.DarkSlateGray;
            this.guna2GradientPanel2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientPanel2.Location = new System.Drawing.Point(629, 500);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(433, 205);
            this.guna2GradientPanel2.TabIndex = 5;
            // 
            // lblOverdueAlerts
            // 
            this.lblOverdueAlerts.BackColor = System.Drawing.Color.Transparent;
            this.lblOverdueAlerts.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverdueAlerts.Location = new System.Drawing.Point(88, 94);
            this.lblOverdueAlerts.Name = "lblOverdueAlerts";
            this.lblOverdueAlerts.Size = new System.Drawing.Size(26, 56);
            this.lblOverdueAlerts.TabIndex = 5;
            this.lblOverdueAlerts.Text = "0";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(28, 94);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel4.TabIndex = 3;
            this.guna2HtmlLabel4.Text = null;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(144, 13);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(64, 57);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 2;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(214, 22);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(70, 34);
            this.guna2HtmlLabel5.TabIndex = 1;
            this.guna2HtmlLabel5.Text = "Alerts";
            // 
            // DashboardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1490, 951);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.panelSummary2);
            this.Controls.Add(this.panelSummary1);
            this.Controls.Add(this.lblWelcome);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panelSummary1.ResumeLayout(false);
            this.panelSummary1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAssetsIcon)).EndInit();
            this.panelSummary2.ResumeLayout(false);
            this.panelSummary2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAssignIcon)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotal;
        private Guna.UI2.WinForms.Guna2GradientPanel panelSummary1;
        private Guna.UI2.WinForms.Guna2PictureBox picAssetsIcon;
        private Guna.UI2.WinForms.Guna2GradientPanel panelSummary2;
        private Guna.UI2.WinForms.Guna2PictureBox picAssignIcon;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitleAssigned;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalAssets;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAssigned;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel ygd;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAssetCount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAssignedToday;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUpcomingMaintenance;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOverdueAlerts;
    }
}