using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Caunceran
{
    public partial class Main : Form
    {
        private string user;
        private string userrole;


        public Main(string username, string role)
        {
            InitializeComponent();
            user = username;
            userrole = role;



        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"Welcome, {user} ({userrole})";

        }
        private void OpenChildForm(Form childForm)
        {
            picUser.Controls.Clear(); 
            childForm.TopLevel = false;      
            childForm.FormBorderStyle = FormBorderStyle.None; 
            childForm.Dock = DockStyle.Fill; 
            picUser.Controls.Add(childForm); 
            childForm.Show(); 
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashboardForm());
        }

        private void btnRegisterAsset_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AssetRegistrationForm());
        }

       

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MaintenanceForm());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportsForm());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); 
                Login login = new Login(); 
                login.Show(); 
            }

        }
    }
}
