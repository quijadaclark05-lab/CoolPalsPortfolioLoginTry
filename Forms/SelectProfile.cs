using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoolPalsPortfolioLoginTry.Forms.Adrian;
using CoolPalsPortfolioLoginTry.Forms.Jared;
using CoolPalsPortfolioLoginTry.Forms.Ralph;
using CoolPalsPortfolioLoginTry.Forms.Clark;
using CoolPalsPortfolioLoginTry.Forms.Jerome;

namespace CoolPalsPortfolioLoginTry.Forms
{
    public partial class SelectProfile : Form
    {
        // Field to store the username passed from the LoginForm
        private readonly string currentUsername;

        // ADD A CONSTRUCTOR that accepts the username (1 argument)
        public SelectProfile(string username)
        {
            InitializeComponent();
            this.currentUsername = username; // Store the passed username

            // Optional: Set the form title to confirm the username was received
            this.Text = $"Select Profile - Logged in as: {currentUsername}";
        }

        /* // DELETE THE EMPTY DEFAULT CONSTRUCTOR IF IT WAS PRESENT:
        public SelectProfile() 
        {
            InitializeComponent();
        } 
        */

        private void SelectProfile_Load(object sender, EventArgs e)
        {
            // This is where you will add code later to load the user's data
            // You can use the 'currentUsername' field here.
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Open Jerome
            var form = new SelectedJerome();
            form.FormBorderStyle = FormBorderStyle.Sizable; // or another style with borders
            form.WindowState = FormWindowState.Maximized;
            form.TopMost = true;
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Open Jared
            var form = new SelectedJared();
            form.FormBorderStyle = FormBorderStyle.Sizable; // or another style with borders
            form.WindowState = FormWindowState.Maximized;
            form.TopMost = true;
            form.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Open Ralph
            var form = new SelectedRalph();
            form.FormBorderStyle = FormBorderStyle.Sizable; // or another style with borders
            form.WindowState = FormWindowState.Maximized;
            form.TopMost = true;
            form.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Open Clark
            var form = new SelectedClark();
            form.FormBorderStyle = FormBorderStyle.Sizable; // or another style with borders
            form.WindowState = FormWindowState.Maximized;
            form.TopMost = true;
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Open Adrian
            var form = new SelectedAdrian();
            form.FormBorderStyle = FormBorderStyle.Sizable; // or another style with borders
            form.WindowState = FormWindowState.Maximized;
            form.TopMost = true;
            form.Show();
            this.Hide();
        }
    }
}