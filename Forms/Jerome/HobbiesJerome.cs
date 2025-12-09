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
    public partial class HobbiesJerome : Form
    {
        public HobbiesJerome()
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

        // Back -> return to SkillsJerome
        private void Back_Click(object sender, EventArgs e)
        {
            var skillsForm = new SkillsJerome();
            skillsForm.Show();
            this.Hide();
        }

        // Next -> go to MessageJerome
        private void Next_Click(object sender, EventArgs e)
        {
            var messageForm = new MessageJerome();
            messageForm.Show();
            this.Hide();
        }
    }
}
