namespace BabyVaccineFinalSystem
{
    partial class UserLogin
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
            this.TbxPass = new System.Windows.Forms.TextBox();
            this.CkbSeePass = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TbxUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbxPass
            // 
            this.TbxPass.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxPass.Location = new System.Drawing.Point(208, 290);
            this.TbxPass.Name = "TbxPass";
            this.TbxPass.Size = new System.Drawing.Size(209, 28);
            this.TbxPass.TabIndex = 18;
            this.TbxPass.Text = "Password";
            this.TbxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TbxPass_MouseClick);
            this.TbxPass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TbxPass.MouseLeave += new System.EventHandler(this.TbxPass_MouseLeave);
            // 
            // CkbSeePass
            // 
            this.CkbSeePass.AutoSize = true;
            this.CkbSeePass.BackColor = System.Drawing.Color.Transparent;
            this.CkbSeePass.Location = new System.Drawing.Point(213, 320);
            this.CkbSeePass.Name = "CkbSeePass";
            this.CkbSeePass.Size = new System.Drawing.Size(55, 21);
            this.CkbSeePass.TabIndex = 22;
            this.CkbSeePass.Text = "See";
            this.CkbSeePass.UseVisualStyleBackColor = false;
            this.CkbSeePass.CheckedChanged += new System.EventHandler(this.CkbSeePass_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BabyVaccineFinalSystem.Properties.Resources.healthWorkerLogo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(213, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 123);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Turquoise;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Image = global::BabyVaccineFinalSystem.Properties.Resources.logIn_out12Final;
            this.BtnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogin.Location = new System.Drawing.Point(233, 394);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(171, 42);
            this.BtnLogin.TabIndex = 19;
            this.BtnLogin.Text = "LOGIN";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TbxUser
            // 
            this.TbxUser.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxUser.Location = new System.Drawing.Point(208, 249);
            this.TbxUser.Name = "TbxUser";
            this.TbxUser.Size = new System.Drawing.Size(209, 28);
            this.TbxUser.TabIndex = 23;
            this.TbxUser.Text = "User";
            this.TbxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TbxUser_MouseClick);
            this.TbxUser.MouseLeave += new System.EventHandler(this.TbxUser_MouseLeave);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(625, 520);
            this.Controls.Add(this.TbxUser);
            this.Controls.Add(this.CkbSeePass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TbxPass);
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TbxPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox CkbSeePass;
        private System.Windows.Forms.TextBox TbxUser;
    }
}

