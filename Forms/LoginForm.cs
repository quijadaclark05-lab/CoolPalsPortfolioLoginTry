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

namespace CoolPalsPortfolioLoginTry.Forms
{
    public partial class LoginForm : Form
    {
        string connectionString =
     System.Configuration.ConfigurationManager
     .ConnectionStrings["CoolPalsPortfolioLoginTry.Properties.Settings.CoolPalsPortfolioConnectionString"]
     .ConnectionString;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    // ✅ Login successful → open EducationForm
                    EducationForm eduForm = new EducationForm(username);
                    eduForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }
    }
}
