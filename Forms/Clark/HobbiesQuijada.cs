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
    public partial class HobbiesQuijada : Form
    {
        public HobbiesQuijada()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ELEMSCHOOL_Click(object sender, EventArgs e)
        {

        }

        // Next -> go to MessageQuijada
        private void Next_Click(object sender, EventArgs e)
        {
            var messageForm = new MessageQuijada();
            messageForm.Show();
            this.Hide();
        }

        private void StudentNamePort_Click(object sender, EventArgs e)
        {

        }

        // Back -> return to SkillsClark
        private void Back_Click(object sender, EventArgs e)
        {
            var skillsForm = new SkillsClark();
            skillsForm.Show();
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
