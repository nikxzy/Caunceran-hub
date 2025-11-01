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
    public partial class MaintenanceForm : Form
    {
        public MaintenanceForm()
        {
            InitializeComponent();

        }

        private void MaintenanceForm_Load(object sender, EventArgs e)
        {
          
            RefreshRecordIDComboBox();

            int RecordID = 1;
            string connectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=CaunceranDB; Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand getMaxID = new SqlCommand("SELECT ISNULL(MAX(RecordID), 1) + 1 FROM MaintenanceRecords", conn);
                RecordID = Convert.ToInt32(getMaxID.ExecuteScalar());
                



            }
        }
        

        private void btnSaveMaintenance_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaintenanceType.Text) || string.IsNullOrWhiteSpace(txtMaintenanceCost.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(txtMaintenanceCost.Text, out float cost))
            {
                MessageBox.Show("Please enter a valid cost.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string connectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=CaunceranDB; Integrated Security=True;";
            int RecordID;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand getMaxID = new SqlCommand("SELECT MAX(RecordID) FROM MaintenanceRecords", conn);
                object result = getMaxID.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    RecordID = Convert.ToInt32(result) + 1;
                }
                else
                {
                    RecordID = 1; 
                }

                string query = @"INSERT INTO MaintenanceRecords 
            (RecordID, MaintenanceDate, MaintenanceType, MaintenanceCost) 
            VALUES (@RecordID, @MaintenanceDate, @MaintenanceType, @MaintenanceCost)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RecordID", RecordID);
                cmd.Parameters.AddWithValue("@MaintenanceDate", dtpMaintenanceDate.Value);
                cmd.Parameters.AddWithValue("@MaintenanceType", txtMaintenanceType.Text);
                cmd.Parameters.AddWithValue("@MaintenanceCost", cost);
                cmd.ExecuteNonQuery();
                RefreshRecordIDComboBox();

                if (cmbRecordID.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a record.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            MessageBox.Show("Maintenance record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaintenanceType.Text = "";
            txtMaintenanceCost.Text = "";
        }
        private void RefreshRecordIDComboBox()
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=CaunceranDB; Integrated Security=True;";
            string query = "SELECT RecordID, MaintenanceType FROM MaintenanceRecords";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dt.Columns.Add("DisplayText", typeof(string));
                foreach (DataRow row in dt.Rows)
                {
                    row["DisplayText"] = $"{row["RecordID"]} - {row["MaintenanceType"]}";
                }

                cmbRecordID.DataSource = dt;
                cmbRecordID.DisplayMember = "DisplayText";
                cmbRecordID.ValueMember = "RecordID";

            }
        }
    }
}



    