namespace CoolPalsPortfolioLoginTry.Forms.Clark
{
    partial class HobbiesQuijada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Back = new System.Windows.Forms.Button();
            this.ELEMSCHOOL = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentNamePort = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(671, 891);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(166, 102);
            this.Back.TabIndex = 83;
            this.Back.Text = "<";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ELEMSCHOOL
            // 
            this.ELEMSCHOOL.AutoSize = true;
            this.ELEMSCHOOL.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ELEMSCHOOL.Location = new System.Drawing.Point(34, 695);
            this.ELEMSCHOOL.Name = "ELEMSCHOOL";
            this.ELEMSCHOOL.Size = new System.Drawing.Size(518, 75);
            this.ELEMSCHOOL.TabIndex = 82;
            this.ELEMSCHOOL.Text = "Clark loves going out, enjoying the sun, and seeing new sights. \r\nHe finds happin" +
    "ess in exploring new places and soaking \r\nup the warmth of the outdoors.";
            this.ELEMSCHOOL.Click += new System.EventHandler(this.ELEMSCHOOL_Click);
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(1332, 891);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(166, 102);
            this.Next.TabIndex = 81;
            this.Next.Text = ">";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(26, 584);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 73);
            this.label1.TabIndex = 79;
            this.label1.Text = "HOBBIES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StudentNamePort
            // 
            this.StudentNamePort.AutoSize = true;
            this.StudentNamePort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StudentNamePort.Font = new System.Drawing.Font("Dubai", 36.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNamePort.ForeColor = System.Drawing.Color.Maroon;
            this.StudentNamePort.Location = new System.Drawing.Point(12, 9);
            this.StudentNamePort.Name = "StudentNamePort";
            this.StudentNamePort.Size = new System.Drawing.Size(400, 82);
            this.StudentNamePort.TabIndex = 80;
            this.StudentNamePort.Text = "CLARK QUIJADA";
            this.StudentNamePort.Click += new System.EventHandler(this.StudentNamePort_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoolPalsPortfolioLoginTry.Properties.Resources.HOBBIES;
            this.pictureBox1.Location = new System.Drawing.Point(39, 386);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CoolPalsPortfolioLoginTry.Properties.Resources.HobbiesClarkLayout;
            this.pictureBox2.Location = new System.Drawing.Point(679, -20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1851, 1070);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 85;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // HobbiesQuijada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ELEMSCHOOL);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentNamePort);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "HobbiesQuijada";
            this.Text = "HobbiesQuijada";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label ELEMSCHOOL;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StudentNamePort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}