using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolPalsPortfolioLoginTry.Forms.Jerome
{
    public partial class SkillsJerome : Form
    {
        public SkillsJerome()
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

        // Back -> return to EducationJerome
        private void Back_Click(object sender, EventArgs e)
        {
            var educationForm = new EducationJerome();
            educationForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        // Next -> go to HobbiesJerome
        private void Next_Click(object sender, EventArgs e)
        {
            var hobbiesForm = new HobbiesJerome();
            hobbiesForm.Show();
            this.Hide();
        }

        private void SkillsJerome_Load(object sender, EventArgs e)
        {

        }
    }
}
