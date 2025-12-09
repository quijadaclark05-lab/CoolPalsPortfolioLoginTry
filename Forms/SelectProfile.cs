using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}