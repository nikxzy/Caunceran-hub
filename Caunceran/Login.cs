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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=TestLogin;Trusted_Connection=True;";
            string userId = txtUserID.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();

            

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("All fields must be filled.");
                return;
            }

            if (userId.Length != 10 || !userId.All(char.IsDigit))
            {
                MessageBox.Show("UserID must be exactly 10 digits.");
                return;
            }

            Main main = new Main(username, role);
            main.Show();
            this.Hide();




            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                
                string checkQuery = @"SELECT COUNT(*) FROM Users 
                              WHERE UserID = @UserID AND Username = @Username 
                              AND Password = @Password AND Role = @Role";

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@UserID", userId);
                    checkCmd.Parameters.AddWithValue("@Username", username);
                    checkCmd.Parameters.AddWithValue("@Password", password);
                    checkCmd.Parameters.AddWithValue("@Role", role);

                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("Login successful.");
                    }
                    else
                    {
                        
                        string insertQuery = @"INSERT INTO Users (UserID, Username, Password, Role)
                                       VALUES (@UserID, @Username, @Password, @Role)";

                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                        {
                            insertCmd.Parameters.AddWithValue("@UserID", userId);
                            insertCmd.Parameters.AddWithValue("@Username", username);
                            insertCmd.Parameters.AddWithValue("@Password", password);
                            insertCmd.Parameters.AddWithValue("@Role", role);

                            insertCmd.ExecuteNonQuery();
                            MessageBox.Show("New user created. Login successful.");

                        }
                        

                    }
                    
                   
                   
                    
                    
                }
            }
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUserID.Text))
            {
                lblUserHInt.Visible = false;
            }
            else
            {
                lblUserHInt.Visible =true;  
            }
        }
    }
    
    
}


