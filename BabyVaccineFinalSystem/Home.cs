using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BabyVaccineFinalSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("CREATE TABLE IF NOT EXISTS baby_info (id INT AUTO_INCREMENT PRIMARY KEY, first_name VARCHAR(100) NOT NULL, middle_name VARCHAR(100) NOT NULL, last_name VARCHAR(100) NOT NULL, gender VARCHAR(100) NOT NULL, birthdate date)", Info.cnn);
            Info.cnn.Open();
            cmd.ExecuteNonQuery();
            Info.cnn.Close();
        }

        private void btnViewBaby_Click(object sender, EventArgs e)
        {
            Viewbaby vb = new Viewbaby();
            this.Hide();
            vb.Show();

        }

        private void aDDBABYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBaby ab = new AddBaby();
            this.Hide();
            ab.Show();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm Log-out? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UserLogin ul = new UserLogin();
                this.Hide();
                ul.Show();
            }
            else
            {

            }

           
        }

        private void vACCINEINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VaccineInfo vi = new VaccineInfo();
            this.Hide();
            vi.Show();
        }
    }
}
