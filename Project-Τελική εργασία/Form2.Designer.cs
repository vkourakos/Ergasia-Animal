namespace Project_Τελική_εργασία
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label_User = new System.Windows.Forms.Label();
            this.label_Level = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_Score = new System.Windows.Forms.Label();
            this.animalPic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.animalPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.BackColor = System.Drawing.Color.Transparent;
            this.label_User.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_User.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_User.Location = new System.Drawing.Point(12, 1);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(77, 34);
            this.label_User.TabIndex = 0;
            this.label_User.Text = "User:";
            // 
            // label_Level
            // 
            this.label_Level.AutoSize = true;
            this.label_Level.BackColor = System.Drawing.Color.Transparent;
            this.label_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Level.ForeColor = System.Drawing.Color.Red;
            this.label_Level.Location = new System.Drawing.Point(326, 4);
            this.label_Level.Name = "label_Level";
            this.label_Level.Size = new System.Drawing.Size(157, 31);
            this.label_Level.TabIndex = 1;
            this.label_Level.Text = "Mode: Easy";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.BackColor = System.Drawing.Color.Transparent;
            this.label_Time.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Time.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_Time.Location = new System.Drawing.Point(561, 7);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(99, 29);
            this.label_Time.TabIndex = 2;
            this.label_Time.Text = "Time: 30";
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.BackColor = System.Drawing.Color.Transparent;
            this.label_Score.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Score.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_Score.Location = new System.Drawing.Point(691, 7);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(97, 29);
            this.label_Score.TabIndex = 3;
            this.label_Score.Text = "Score: 0";
            // 
            // animalPic
            // 
            this.animalPic.BackColor = System.Drawing.Color.Transparent;
            this.animalPic.Image = ((System.Drawing.Image)(resources.GetObject("animalPic.Image")));
            this.animalPic.Location = new System.Drawing.Point(332, 185);
            this.animalPic.Name = "animalPic";
            this.animalPic.Size = new System.Drawing.Size(100, 100);
            this.animalPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.animalPic.TabIndex = 4;
            this.animalPic.TabStop = false;
            this.animalPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.animal_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 700;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.animalPic);
            this.Controls.Add(this.label_Score);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label_Level);
            this.Controls.Add(this.label_User);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Label label_Level;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.PictureBox animalPic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}