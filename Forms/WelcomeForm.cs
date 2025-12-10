using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CoolPalsPortfolioLoginTry.Forms
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["CoolPalsPortfolioLoginTry.Properties.Settings.CoolPalsPortfolioConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users", conn);
                    int userCount = (int)cmd.ExecuteScalar();
                    MessageBox.Show($"✅ Connected! Users in DB: {userCount}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"❌ Connection failed:\n{ex.Message}");
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignupForm signUpForm = new SignupForm();
            signUpForm.Show();
            this.Hide(); // optional: hides WelcomeForm
        }

        private void copyrightGroup7_Click(object sender, EventArgs e)
        {

        }
    }
}
