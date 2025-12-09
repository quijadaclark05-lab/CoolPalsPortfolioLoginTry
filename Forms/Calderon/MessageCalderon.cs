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
    public partial class MessageCalderon : Form
    {
        public MessageCalderon()
        {
            InitializeComponent();
        }

        private void StudentNamePort_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ELEMSCHOOL_Click(object sender, EventArgs e)
        {

        }

        // Back -> return to HobbiesCalderon
        private void Back_Click(object sender, EventArgs e)
        {
            var hobbiesForm = new HobbiesCalderon();
            hobbiesForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Leave this empty per your instruction
        private void BackToSelectProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
