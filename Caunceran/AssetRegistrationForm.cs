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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Caunceran
{
    public partial class AssetRegistrationForm : Form
    {
        public AssetRegistrationForm()
        {
            InitializeComponent();

        }

        private void btnSaveAsset_Click(object sender, EventArgs e)
        {

            LoadAssets();

            decimal cost;
            if (!decimal.TryParse(txtCost.Text, out cost))
            {
                MessageBox.Show("Please enter a valid number for Cost.");
                return;
            }

            using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS; Initial Catalog=DashboardDB; Integrated Security=True;"))
            {
                string query = @"INSERT INTO Assets 
            (AssetName, SerialNumber, Category, PurchaseDate, Location, Cost, Condition)
            VALUES (@AssetName, @SerialNumber, @Category, @PurchaseDate, @Location, @Cost, @Condition)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AssetName", txtAssetName.Text);
                cmd.Parameters.AddWithValue("@SerialNumber", txtSerialNumber.Text);
                cmd.Parameters.AddWithValue("@Category", cmbCategory.SelectedItem?.ToString());
                cmd.Parameters.AddWithValue("@PurchaseDate", dtpPurchaseDate.Value.Date);
                cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                cmd.Parameters.AddWithValue("@Cost", cost);
                cmd.Parameters.AddWithValue("@Condition", cmbCondition.SelectedItem?.ToString());




                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadAssets();
            }
        }
        private void ClearForm()
        {
            txtAssetName.Clear();
            txtSerialNumber.Clear();
            cmbCategory.SelectedIndex = -1;
            dtpPurchaseDate.Value = DateTime.Today;
            txtLocation.Clear();
            txtCost.Clear();
            cmbCondition.Text = "Select condition";
        }
        private void AssetRegistrationForm_Load(object sender, EventArgs e)
        {
            cmbCondition.Items.Clear();
            cmbCondition.Items.Add("New");
            cmbCondition.Items.Add("Used");
            cmbCondition.Items.Add("Refurbished");
            cmbCondition.Items.Add("Damaged");
            cmbCondition.Items.Add("Under Repair");
            cmbCondition.Items.Add("Retired");
        }
        private void LoadAssets()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS; Initial Catalog=DashboardDB; Integrated Security=True;"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Assets", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvAssets.DataSource = dt;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          
           

        }
    }
}

       
   