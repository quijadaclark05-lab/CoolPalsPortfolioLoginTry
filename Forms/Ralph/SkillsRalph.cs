using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolPalsPortfolioLoginTry.Forms.Ralph
{
    public partial class SkillsRalph : Form
    {
        public SkillsRalph()
        {
            InitializeComponent();
        }

        private void StudentNamePort_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ELEMSCHOOL_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        // Back -> return to EducationRalph
        private void Back_Click(object sender, EventArgs e)
        {
            var educationForm = new EducationRalph();
            educationForm.Show();
            this.Hide();
        }

        // Next -> go to HobbiesRalph
        private void Next_Click(object sender, EventArgs e)
        {
            var hobbiesForm = new HobbiesRalph();
            hobbiesForm.Show();
            this.Hide();
        }
    }
}
