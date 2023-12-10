namespace BabyVaccineFinalSystem
{
    partial class Viewbaby
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TbxSearch = new System.Windows.Forms.TextBox();
            this.DgvViewBaby = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.btnAddBaby = new System.Windows.Forms.Button();
            this.LblLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewBaby)).BeginInit();
            this.SuspendLayout();
            // 
            // TbxSearch
            // 
            this.TbxSearch.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxSearch.Location = new System.Drawing.Point(855, 95);
            this.TbxSearch.Name = "TbxSearch";
            this.TbxSearch.Size = new System.Drawing.Size(396, 28);
            this.TbxSearch.TabIndex = 40;
            this.TbxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxSearch_KeyDown);
            // 
            // DgvViewBaby
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvViewBaby.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvViewBaby.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvViewBaby.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvViewBaby.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvViewBaby.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvViewBaby.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvViewBaby.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvViewBaby.Location = new System.Drawing.Point(59, 140);
            this.DgvViewBaby.Name = "DgvViewBaby";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvViewBaby.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvViewBaby.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvViewBaby.RowTemplate.Height = 24;
            this.DgvViewBaby.Size = new System.Drawing.Size(1351, 571);
            this.DgvViewBaby.TabIndex = 39;
            this.DgvViewBaby.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Click a data to edit or add injected info";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.SlateGray;
            this.BtnBack.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Image = global::BabyVaccineFinalSystem.Properties.Resources._12626_20012;
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.Location = new System.Drawing.Point(7, 5);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(205, 44);
            this.BtnBack.TabIndex = 43;
            this.BtnBack.Text = "Back Home";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Turquoise;
            this.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Image = global::BabyVaccineFinalSystem.Properties.Resources.search1;
            this.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearch.Location = new System.Drawing.Point(1257, 89);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(153, 34);
            this.BtnSearch.TabIndex = 42;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            this.BtnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnSearch_KeyDown);
            // 
            // btnAddBaby
            // 
            this.btnAddBaby.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAddBaby.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddBaby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBaby.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBaby.ForeColor = System.Drawing.Color.White;
            this.btnAddBaby.Image = global::BabyVaccineFinalSystem.Properties.Resources.addmem1;
            this.btnAddBaby.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBaby.Location = new System.Drawing.Point(609, 731);
            this.btnAddBaby.Name = "btnAddBaby";
            this.btnAddBaby.Size = new System.Drawing.Size(206, 45);
            this.btnAddBaby.TabIndex = 41;
            this.btnAddBaby.Text = "Add Baby";
            this.btnAddBaby.UseVisualStyleBackColor = false;
            this.btnAddBaby.Click += new System.EventHandler(this.btnAddBaby_Click);
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.BackColor = System.Drawing.Color.Transparent;
            this.LblLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblLogin.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblLogin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LblLogin.Location = new System.Drawing.Point(596, 21);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(219, 55);
            this.LblLogin.TabIndex = 49;
            this.LblLogin.Text = "DATA\'S";
            // 
            // Viewbaby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1461, 788);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.btnAddBaby);
            this.Controls.Add(this.TbxSearch);
            this.Controls.Add(this.DgvViewBaby);
            this.Name = "Viewbaby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viewbaby";
            this.Load += new System.EventHandler(this.Viewbaby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewBaby)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button btnAddBaby;
        private System.Windows.Forms.TextBox TbxSearch;
        private System.Windows.Forms.DataGridView DgvViewBaby;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblLogin;
    }
}