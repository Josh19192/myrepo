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
            this.LblPass = new System.Windows.Forms.Label();
            this.CbxUser = new System.Windows.Forms.ComboBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.CkbSeePass = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbxPass
            // 
            this.TbxPass.Location = new System.Drawing.Point(222, 293);
            this.TbxPass.Name = "TbxPass";
            this.TbxPass.Size = new System.Drawing.Size(209, 22);
            this.TbxPass.TabIndex = 18;
            this.TbxPass.UseSystemPasswordChar = true;
            this.TbxPass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.BackColor = System.Drawing.Color.Transparent;
            this.LblPass.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPass.Location = new System.Drawing.Point(113, 295);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(92, 21);
            this.LblPass.TabIndex = 17;
            this.LblPass.Text = "Password: ";
            this.LblPass.Click += new System.EventHandler(this.LblPass_Click);
            // 
            // CbxUser
            // 
            this.CbxUser.FormattingEnabled = true;
            this.CbxUser.Items.AddRange(new object[] {
            "Nurse",
            "BHW"});
            this.CbxUser.Location = new System.Drawing.Point(222, 237);
            this.CbxUser.Name = "CbxUser";
            this.CbxUser.Size = new System.Drawing.Size(209, 24);
            this.CbxUser.TabIndex = 16;
            this.CbxUser.SelectedIndexChanged += new System.EventHandler(this.CbxUser_SelectedIndexChanged);
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.BackColor = System.Drawing.Color.Transparent;
            this.LblUser.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.Location = new System.Drawing.Point(155, 241);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(55, 21);
            this.LblUser.TabIndex = 15;
            this.LblUser.Text = "User: ";
            this.LblUser.Click += new System.EventHandler(this.LblUser_Click);
            // 
            // CkbSeePass
            // 
            this.CkbSeePass.AutoSize = true;
            this.CkbSeePass.BackColor = System.Drawing.Color.Transparent;
            this.CkbSeePass.Location = new System.Drawing.Point(222, 321);
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
            this.BtnLogin.BackColor = System.Drawing.Color.LightBlue;
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
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(625, 520);
            this.Controls.Add(this.CkbSeePass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TbxPass);
            this.Controls.Add(this.LblPass);
            this.Controls.Add(this.CbxUser);
            this.Controls.Add(this.LblUser);
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TbxPass;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.ComboBox CbxUser;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox CkbSeePass;
    }
}

