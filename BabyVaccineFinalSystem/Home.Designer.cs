namespace BabyVaccineFinalSystem
{
    partial class Home
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
            this.LblLogin = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnViewBaby = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDBABYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vACCINEINFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.BackColor = System.Drawing.Color.Transparent;
            this.LblLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblLogin.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblLogin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LblLogin.Location = new System.Drawing.Point(245, 74);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(649, 96);
            this.LblLogin.TabIndex = 11;
            this.LblLogin.Text = "BABY VACCINE INFORMATION \r\n                     SYSTEM";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewBaby,
            this.aDDBABYToolStripMenuItem,
            this.vACCINEINFOToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1103, 38);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnViewBaby
            // 
            this.btnViewBaby.BackColor = System.Drawing.Color.Transparent;
            this.btnViewBaby.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewBaby.Image = global::BabyVaccineFinalSystem.Properties.Resources.ViewBabyFinal1;
            this.btnViewBaby.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnViewBaby.Name = "btnViewBaby";
            this.btnViewBaby.Size = new System.Drawing.Size(171, 34);
            this.btnViewBaby.Text = "VIEW BABIES";
            this.btnViewBaby.Click += new System.EventHandler(this.btnViewBaby_Click);
            // 
            // aDDBABYToolStripMenuItem
            // 
            this.aDDBABYToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.aDDBABYToolStripMenuItem.Image = global::BabyVaccineFinalSystem.Properties.Resources.AddBabyFinal1234;
            this.aDDBABYToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aDDBABYToolStripMenuItem.Name = "aDDBABYToolStripMenuItem";
            this.aDDBABYToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.aDDBABYToolStripMenuItem.Text = "ADD BABY";
            this.aDDBABYToolStripMenuItem.Click += new System.EventHandler(this.aDDBABYToolStripMenuItem_Click);
            // 
            // vACCINEINFOToolStripMenuItem
            // 
            this.vACCINEINFOToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.vACCINEINFOToolStripMenuItem.Image = global::BabyVaccineFinalSystem.Properties.Resources.about_iconF;
            this.vACCINEINFOToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vACCINEINFOToolStripMenuItem.Name = "vACCINEINFOToolStripMenuItem";
            this.vACCINEINFOToolStripMenuItem.Size = new System.Drawing.Size(181, 34);
            this.vACCINEINFOToolStripMenuItem.Text = "VACCINE INFO";
            this.vACCINEINFOToolStripMenuItem.Click += new System.EventHandler(this.vACCINEINFOToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.lOGOUTToolStripMenuItem.Image = global::BabyVaccineFinalSystem.Properties.Resources.logIn_icon12Final;
            this.lOGOUTToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(123, 34);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BabyVaccineFinalSystem.Properties.Resources.vaccine_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1103, 619);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnViewBaby;
        private System.Windows.Forms.ToolStripMenuItem aDDBABYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vACCINEINFOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}