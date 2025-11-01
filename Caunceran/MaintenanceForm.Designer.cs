namespace Caunceran
{
    partial class MaintenanceForm
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
            this.cmbRecordID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpMaintenanceDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.c = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMaintenanceType = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaintenanceCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSaveMaintenance = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRecordID
            // 
            this.cmbRecordID.BackColor = System.Drawing.Color.Transparent;
            this.cmbRecordID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRecordID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecordID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRecordID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRecordID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRecordID.ForeColor = System.Drawing.Color.Black;
            this.cmbRecordID.ItemHeight = 30;
            this.cmbRecordID.Location = new System.Drawing.Point(374, 85);
            this.cmbRecordID.Name = "cmbRecordID";
            this.cmbRecordID.Size = new System.Drawing.Size(310, 36);
            this.cmbRecordID.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(146, 85);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(198, 65);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Record ID";
            // 
            // dtpMaintenanceDate
            // 
            this.dtpMaintenanceDate.Checked = true;
            this.dtpMaintenanceDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtpMaintenanceDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpMaintenanceDate.ForeColor = System.Drawing.Color.Black;
            this.dtpMaintenanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpMaintenanceDate.Location = new System.Drawing.Point(374, 156);
            this.dtpMaintenanceDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpMaintenanceDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpMaintenanceDate.Name = "dtpMaintenanceDate";
            this.dtpMaintenanceDate.Size = new System.Drawing.Size(310, 36);
            this.dtpMaintenanceDate.TabIndex = 2;
            this.dtpMaintenanceDate.Value = new System.DateTime(2025, 10, 30, 1, 15, 10, 246);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(113, 156);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(287, 68);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Maintenance date\r\n\r\n";
            // 
            // c
            // 
            this.c.AutoSize = false;
            this.c.BackColor = System.Drawing.Color.Transparent;
            this.c.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.ForeColor = System.Drawing.Color.Black;
            this.c.Location = new System.Drawing.Point(113, 231);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(318, 77);
            this.c.TabIndex = 4;
            this.c.Text = "Maintenance notes";
            // 
            // txtMaintenanceType
            // 
            this.txtMaintenanceType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaintenanceType.DefaultText = "";
            this.txtMaintenanceType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaintenanceType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaintenanceType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaintenanceType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaintenanceType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaintenanceType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaintenanceType.ForeColor = System.Drawing.Color.Black;
            this.txtMaintenanceType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaintenanceType.Location = new System.Drawing.Point(374, 225);
            this.txtMaintenanceType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaintenanceType.Name = "txtMaintenanceType";
            this.txtMaintenanceType.PlaceholderText = "";
            this.txtMaintenanceType.SelectedText = "";
            this.txtMaintenanceType.Size = new System.Drawing.Size(310, 52);
            this.txtMaintenanceType.TabIndex = 5;
            // 
            // txtMaintenanceCost
            // 
            this.txtMaintenanceCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaintenanceCost.DefaultText = "";
            this.txtMaintenanceCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaintenanceCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaintenanceCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaintenanceCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaintenanceCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaintenanceCost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaintenanceCost.ForeColor = System.Drawing.Color.Black;
            this.txtMaintenanceCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaintenanceCost.Location = new System.Drawing.Point(374, 314);
            this.txtMaintenanceCost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaintenanceCost.Name = "txtMaintenanceCost";
            this.txtMaintenanceCost.PlaceholderText = "";
            this.txtMaintenanceCost.SelectedText = "";
            this.txtMaintenanceCost.Size = new System.Drawing.Size(310, 52);
            this.txtMaintenanceCost.TabIndex = 6;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(113, 314);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(254, 63);
            this.guna2HtmlLabel3.TabIndex = 7;
            this.guna2HtmlLabel3.Text = "Maintenance cost";
            // 
            // btnSaveMaintenance
            // 
            this.btnSaveMaintenance.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveMaintenance.BorderRadius = 7;
            this.btnSaveMaintenance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveMaintenance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveMaintenance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveMaintenance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveMaintenance.FillColor = System.Drawing.Color.SteelBlue;
            this.btnSaveMaintenance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnSaveMaintenance.Location = new System.Drawing.Point(615, 489);
            this.btnSaveMaintenance.Name = "btnSaveMaintenance";
            this.btnSaveMaintenance.Size = new System.Drawing.Size(180, 52);
            this.btnSaveMaintenance.TabIndex = 8;
            this.btnSaveMaintenance.Text = "Save record";
            this.btnSaveMaintenance.Click += new System.EventHandler(this.btnSaveMaintenance_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.btnSaveMaintenance);
            this.guna2GroupBox1.Controls.Add(this.cmbRecordID);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox1.Controls.Add(this.dtpMaintenanceDate);
            this.guna2GroupBox1.Controls.Add(this.txtMaintenanceCost);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.Controls.Add(this.txtMaintenanceType);
            this.guna2GroupBox1.Controls.Add(this.c);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.CadetBlue;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(363, 264);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(916, 603);
            this.guna2GroupBox1.TabIndex = 9;
            this.guna2GroupBox1.Text = "Maintenance Details";
            // 
            // MaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1924, 1170);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "MaintenanceForm";
            this.Text = "MaintenanceForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MaintenanceForm_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbRecordID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpMaintenanceDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel c;
        private Guna.UI2.WinForms.Guna2TextBox txtMaintenanceType;
        private Guna.UI2.WinForms.Guna2TextBox txtMaintenanceCost;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button btnSaveMaintenance;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
    }
}