using CoolPalsPortfolioLoginTry.Forms.Adrian;
using CoolPalsPortfolioLoginTry.Forms.Jared;
using CoolPalsPortfolioLoginTry.Forms.Jerome;
using CoolPalsPortfolioLoginTry.Forms.Ralph;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CoolPalsPortfolioLoginTry.Forms.Clark
{
    public partial class SelectedClark : Form
    {
        private Panel overlayPanel;
        private Button btnMinimize;
        private Button btnMaxRestore;
        private Button btnClose;

        public SelectedClark()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += SelectedClark_KeyDown;
            this.Load += SelectedClark_Load;
            this.FormClosed += Selected_FormClosed;

            CreateOverlayControls();
            this.Resize += Selected_Resize;
            this.MouseMove += Selected_MouseMove;
        }

        private void SelectedClark_Load(object sender, EventArgs e)
        {
            GoFullscreen();
        }

        private void CreateOverlayControls()
        {
            overlayPanel = new Panel();
            overlayPanel.Size = new Size(150, 36);
            overlayPanel.BackColor = Color.FromArgb(40, Color.Black);
            overlayPanel.Visible = true;

            btnMinimize = new Button();
            btnMinimize.Text = "—";
            btnMinimize.ForeColor = Color.White;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.Size = new Size(40, 28);
            btnMinimize.Location = new Point(0, 4);
            btnMinimize.Click += (s, e) => this.WindowState = FormWindowState.Minimized;

            btnMaxRestore = new Button();
            btnMaxRestore.Text = "?";
            btnMaxRestore.ForeColor = Color.White;
            btnMaxRestore.FlatStyle = FlatStyle.Flat;
            btnMaxRestore.FlatAppearance.BorderSize = 0;
            btnMaxRestore.Size = new Size(40, 28);
            btnMaxRestore.Location = new Point(48, 4);
            btnMaxRestore.Click += (s, e) => ToggleMaxRestore();

            btnClose = new Button();
            btnClose.Text = "X";
            btnClose.ForeColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Size = new Size(40, 28);
            btnClose.Location = new Point(96, 4);
            btnClose.Click += (s, e) => this.Close();

            overlayPanel.Controls.Add(btnMinimize);
            overlayPanel.Controls.Add(btnMaxRestore);
            overlayPanel.Controls.Add(btnClose);

            this.Controls.Add(overlayPanel);
            PositionOverlay();
            overlayPanel.BringToFront();
        }

        private void PositionOverlay()
        {
            if (overlayPanel == null) return;
            overlayPanel.Left = Math.Max(10, this.ClientSize.Width - overlayPanel.Width - 10);
            overlayPanel.Top = 10;
        }

        private void Selected_Resize(object sender, EventArgs e)
        {
            PositionOverlay();
        }

        private void Selected_MouseMove(object sender, MouseEventArgs e)
        {
            // Show overlay when mouse near top
            if (e.Y <= 40)
            {
                overlayPanel.Visible = true;
            }
            else
            {
                overlayPanel.Visible = !this.WindowState.Equals(FormWindowState.Normal) && false;
            }
        }

        private void ToggleMaxRestore()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                ExitFullscreen();
            }
            else
            {
                GoFullscreen();
            }
        }

        private void GoFullscreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            this.Bounds = Screen.FromControl(this).Bounds;
            overlayPanel.Visible = true;
        }

        private void ExitFullscreen()
        {
            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
            overlayPanel.Visible = true;
        }

        private void SelectedClark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ExitFullscreen();
            }
        }

        private void Selected_FormClosed(object sender, FormClosedEventArgs e)
        {
            bool otherSelectedOpen = Application.OpenForms.Cast<Form>()
                .Any(f => f != this && f.Name.StartsWith("Selected") && f.Visible);

            if (!otherSelectedOpen)
            {
                var selectProfile = Application.OpenForms.Cast<Form>()
                    .FirstOrDefault(f => f.GetType().Name == "SelectProfile");

                if (selectProfile != null && !selectProfile.Visible)
                {
                    selectProfile.Show();
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var form = new SelectedJerome();
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.TopMost = true;
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var form = new SelectedJared();
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.TopMost = true;
            form.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var form = new SelectedRalph();
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.TopMost = true;
            form.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Already on Clark
            return;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var form = new SelectedAdrian();
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.TopMost = true;
            form.Show();
            this.Hide();
        }
    }
}
