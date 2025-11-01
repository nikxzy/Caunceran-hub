using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caunceran
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadTotalAssets();
            LoadAssignedToday();
            LoadUpcomingMaintenance();
            LoadOverdueAlerts();
            LoadAssignSchedule();
        }
        private void LoadTotalAssets()
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=DashboardDB; Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Assets";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int assetCount = (int)cmd.ExecuteScalar();
                lblAssetCount.Text = assetCount.ToString();
            }
        }
        private void LoadAssignedToday()
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=DashboardDB; Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM AssetAssignments WHERE CAST(AssignmentDate AS DATE) = CAST(GETDATE() AS DATE)";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                lblAssignedToday.Text = count.ToString();
            }
        }
        private void LoadUpcomingMaintenance()
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=DashboardDB; Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM MaintenanceSchedule WHERE MaintenanceDate BETWEEN GETDATE() AND DATEADD(DAY, 7, GETDATE())";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                ygd.Text = count.ToString();
            }
        }
        private void LoadOverdueAlerts()
        {

            string connectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=DashboardDB; Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM AssetAssignments WHERE ReturnDate < GETDATE() AND Status != 'Returned'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                lblOverdueAlerts.Text = count.ToString();
            }
        }
        private void LoadAssignSchedule()
        {

            string connectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=DashboardDB; Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM AssetAssignments";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
              ;
            }
        }

        private void guna2HtmlLabel12_Click(object sender, EventArgs e)
        {

        }

        private void lblAssetCount_Click(object sender, EventArgs e)
        {

        }

        private void picAssetsIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
