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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=CaunceranDB; Integrated Security=True;";
            string selectedFilter = cmbFilter.SelectedItem.ToString();

            string query = @"SELECT RecordID, MaintenanceDate, MaintenanceType, MaintenanceCost 
                     FROM MaintenanceRecords";

            if (selectedFilter != "All")
            {
                query += " WHERE MaintenanceType = @Filter";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                if (selectedFilter != "All")
                {
                    da.SelectCommand.Parameters.AddWithValue("@Filter", selectedFilter);
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReport.DataSource = dt;
            }
        }
        

        private void ReportsForm_Load(object sender, EventArgs e)
        {
          
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("All");
            cmbFilter.Items.Add("Scheduled Inspection");
            cmbFilter.Items.Add("Repair");
            cmbFilter.Items.Add("Cleaning");
            cmbFilter.Items.Add("Software Update");
            cmbFilter.SelectedIndex = 0; 
        }

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    
    
 