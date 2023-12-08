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
    public partial class AddBaby : Form
    {
        public AddBaby()
        {
            InitializeComponent();
        }
        int id = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            id = int.Parse(LblID.Text);
            string firstName = TbxFirstName.Text;
            string midName = TbxMidName.Text;
            string lastName = TbxLastName.Text;
            string gender = CbxGender.Text;
            DateTime birth = DtpBirth.Value;
            if (firstName == "" || midName == ""|| lastName == "" || gender == "")
            {
                MessageBox.Show("Please fill blank information!");
            }
            else
            {
                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO baby_info (id, first_name, middle_name, last_name, gender, birthdate) VALUES (@id, @firstName, @midName, @lastName, @gender, @birth)", Info.cnn);
                Info.cnn.Open();
                cmd1.Parameters.AddWithValue("@id", id);
                cmd1.Parameters.AddWithValue("@firstName", firstName);
                cmd1.Parameters.AddWithValue("@midName", midName);
                cmd1.Parameters.AddWithValue("@lastName", lastName);
                cmd1.Parameters.AddWithValue("@gender", gender);
                cmd1.Parameters.AddWithValue("@birth", birth);

                MySqlCommand cmd2 = new MySqlCommand("CREATE TABLE Baby_" + id + " (vac_no INT PRIMARY KEY, vac_name VARCHAR(100) NOT NULL, dose INT NOT NULL, Dose_1_date_injected Varchar(50) not null, Dose_2_date_injected Varchar(50) not null, Dose_3_date_injected Varchar(50) not null);", Info.cnn);
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Successfully saved");
                Info.cnn.Close();
                Viewbaby vb = new Viewbaby();
                this.Hide();
                vb.Show();
                try
                {

                    MySqlCommand cmd3 = new MySqlCommand("INSERT INTO Baby_" + int.Parse(LblID.Text) + " (vac_no, vac_name, dose, Dose_1_date_injected, Dose_2_date_injected, Dose_3_date_injected) VALUES (1, 'BCG', 1,'Not_yet','N/A','N/A'), (2, 'Hepatitis_B', 1,'Not_yet','N/A','N/A'), (3, 'Pentavalent', 3,'Not_yet','Not_yet','Not_yet'), (4, 'Oral_Polio', 3,'Not_yet','Not_yet','Not_yet'), (5, 'Pneumococcal_Conjugate', 3,'Not_yet','Not_yet','Not_yet'), (6, 'Inactive_Polio', 1,'Not_yet','N/A','N/A'), (7, 'MMR', 2,'Not_yet','Not_yet','N/A')", Info.cnn);
                    Info.cnn.Open();
                    cmd3.ExecuteNonQuery();
                    Info.cnn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            
        }

        private void AddBaby_Load(object sender, EventArgs e)
        {
            MySqlCommand cmdd2 = new MySqlCommand("SELECT count(*) from baby_info;", Info.cnn);
            Info.cnn.Open();
            long rowCount = (long)cmdd2.ExecuteScalar();
            Info.cnn.Close();
            if (rowCount == 0)
            {
                LblID.Text = id.ToString();

            }
            else
            {
                MySqlCommand cmdd = new MySqlCommand("Select id from baby_info order by id desc limit 1;", Info.cnn);
                Info.cnn.Open();
                id = (int)cmdd.ExecuteScalar();
                id = id + 1;
                LblID.Text = id.ToString();
                Info.cnn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Hide();
            hm.Show();
        }
    }
}
