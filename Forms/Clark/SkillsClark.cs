using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolPalsPortfolioLoginTry.Forms.Clark
{
    public partial class SkillsClark : Form
    {
        public SkillsClark()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StudentNamePort_Click(object sender, EventArgs e)
        {

        }

        // Next -> go to HobbiesQuijada
        private void Next_Click(object sender, EventArgs e)
        {
            var hobbiesForm = new HobbiesQuijada();
            hobbiesForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        // Back -> return to EducationQuijada
        private void Back_Click(object sender, EventArgs e)
        {
            var educationForm = new EducationQuijada();
            educationForm.Show();
            this.Hide();
        }

        private void ELEMSCHOOL_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SkillsClark_Load(object sender, EventArgs e)
        {

        }
    }
}
