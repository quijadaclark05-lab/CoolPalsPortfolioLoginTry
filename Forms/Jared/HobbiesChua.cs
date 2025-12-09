using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolPalsPortfolioLoginTry.Forms.Jared
{
    public partial class HobbiesChua : Form
    {
        public HobbiesChua()
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

        // Back -> return to SkillsChua
        private void Back_Click(object sender, EventArgs e)
        {
            var skillsForm = new SkillsChua();
            skillsForm.Show();
            this.Hide();
        }

        // Next -> go to MessageChua
        private void Next_Click(object sender, EventArgs e)
        {
            var messageForm = new MessageChua();
            messageForm.Show();
            this.Hide();
        }
    }
}
