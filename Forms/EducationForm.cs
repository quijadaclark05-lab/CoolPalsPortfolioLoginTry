using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolPalsPortfolioLoginTry.Forms
{
    public partial class EducationForm : Form
    {
        private string currentUsername;
        public EducationForm(string username)
        {
            InitializeComponent();
            currentUsername = username;

        }


        private void EducationForm_Load(object sender, EventArgs e)
        {

            string connStr = ConfigurationManager.ConnectionStrings["CoolPalsPortfolioLoginTry.Properties.Settings.CoolPalsPortfolioConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Get UserID from Username
                SqlCommand getUserIdCmd = new SqlCommand("SELECT UserID FROM Users WHERE Username = @username", conn);
                getUserIdCmd.Parameters.AddWithValue("@username", currentUsername);
                int userId = (int)getUserIdCmd.ExecuteScalar();

                // Get education data
                SqlCommand getProfileCmd = new SqlCommand("SELECT Elementary, JuniorHigh, SeniorHigh, College FROM Profiles WHERE UserID = @userId", conn);
                getProfileCmd.Parameters.AddWithValue("@userId", userId);
                SqlDataReader reader = getProfileCmd.ExecuteReader();

                if (reader.Read())
                {
                    labelElementary.Text = reader["Elementary"].ToString();
                    labelJuniorHigh.Text = reader["JuniorHigh"].ToString();
                    labelSeniorHigh.Text = reader["SeniorHigh"].ToString();
                    labelCollege.Text = reader["College"].ToString();
                }

                reader.Close();

                string layoutPath = Path.Combine(Application.StartupPath, "Assets", "EducationLayouts", $"{currentUsername}.png");

                if (File.Exists(layoutPath))
                {
                    SchoolPic.Image = Image.FromFile(layoutPath);
                }
                else
                {
                    SchoolPic.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Assets", "EducationLayouts", "default.png"));
                }

            }
        }

        private string GetLayoutFilename(string username)
        {
            switch (username.ToLower())
            {
                case "clark": return "QuijadaSchoolwRect.png";
                case "ralph": return "RalphSchoolPic.png";
                case "jared": return "SchoolPicChua.png";
                case "jerome": return "SchoolPicJerom.png";
                default: return "default.png";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ElementaryLabel_Click(object sender, EventArgs e)
        {

        }

        private void JHSLabel_Click(object sender, EventArgs e)
        {

        }

        private void SHSLabel_Click(object sender, EventArgs e)
        {

        }

        private void CollegeLabel_Click(object sender, EventArgs e)
        {

        }

        private void SchoolPic_Click(object sender, EventArgs e)
        {

        }
    }
}
