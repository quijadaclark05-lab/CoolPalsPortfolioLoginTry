using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolPalsPortfolioLoginTry.Forms.Calderon
{
    public partial class SkillsCalderon : Form
    {
        public SkillsCalderon()
        {
            InitializeComponent();
        }

        private void ELEMSCHOOL_Click(object sender, EventArgs e)
        {

        }

        private void StudentNamePort_Click(object sender, EventArgs e)
        {

        }

        // Back -> return to EducationCalderon (no renames)
        private void Back_Click(object sender, EventArgs e)
        {
            var educationForm = new EducationCalderon();
            educationForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Next -> go to HobbiesCalderon
        private void Next_Click(object sender, EventArgs e)
        {
            var hobbiesForm = new HobbiesCalderon();
            hobbiesForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
