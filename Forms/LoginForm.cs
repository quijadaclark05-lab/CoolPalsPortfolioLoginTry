using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration; // Required for ConfigurationManager

namespace CoolPalsPortfolioLoginTry.Forms
{
    public partial class LoginForm : Form
    {
        // 1. **CORRECT THE CONNECTION STRING NAME HERE**
        // Use the clean, simplified name "PortfolioDB" from the updated App.config
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["PortfolioDB"].ConnectionString;

        public LoginForm()
        {
            InitializeComponent();

            // Optional: Run a connection test when the form loads
            TestDatabaseConnection();
        }

        // --- Database Connection Test Method ---
        private void TestDatabaseConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // conn.Open() attempts to connect to the database
                    conn.Open();

                    // Display success message
                    MessageBox.Show("Database connection successful! You can now log in.",
                                    "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                // Display failure message if connection fails
                MessageBox.Show($"Database connection FAILED. Please contact support. \n\nError: {ex.Message}",
                                "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Disable login button if connection failed
                btnLogin.Enabled = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Start try-catch block to handle errors during the login attempt
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // This is where the code will try to connect and execute the query
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password", conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        // ✅ Login successful
                        MessageBox.Show("Login Successful! Opening Portfolio...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SelectProfile selectProfileForm = new SelectProfile(username);
                        selectProfileForm.Show();
                        this.Hide(); 
                    }
                    else
                    {
                        // Login failed (incorrect credentials)
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPassword.Clear();
                    }
                }
            }
            catch (SqlException ex)
            {
                // ❌ Catch any SQL errors that happen during the execution (e.g., table not found)
                MessageBox.Show($"A critical error occurred during login. Please ensure the database is running. Error: {ex.Message}",
                                "Fatal Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Catch any other non-SQL errors
                MessageBox.Show($"An unexpected error occurred: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ensure you remove the old txtUsername_TextChanged method if it's empty
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // Empty method removed for brevity, but keep it if you use it later
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}