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
    public partial class AddInject : Form
    {
        public AddInject(int id, string fName, string w1, string w2, string w3, string w4, string w5, string w6)
        {
            InitializeComponent();
            LblID.Text = id.ToString();
            LblName.Text = fName;
            if (w1 == "Not_yet")
            {
                CbxBirth.Text = w1;
            }
            else 
            {
                dtpAtBirth.Value = DateTime.Parse(w1);
                CbxBirth.Text = w1;
            }
            CbxOneAndHalf.Text = w2;
            CbxTwoAndHalf.Text = w3;
            CbxThreeAndHalf.Text = w4;
            CbxNineMonth.Text = w5;
            CbxOneYear.Text = w6;
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (CbxBirth.Text == "")
            {
                CbxBirth.Text = "Not_yet";
            }

            if (CbxOneAndHalf.Text == "")
            {
                CbxOneAndHalf.Text = "Not_yet";
            }

            if (CbxTwoAndHalf.Text == "")
            {
                CbxTwoAndHalf.Text = "Not_yet";
            }

            if (CbxThreeAndHalf.Text == "")
            {
                CbxThreeAndHalf.Text = "Not_yet";
            }

            if (CbxNineMonth.Text == "")
            {
                CbxNineMonth.Text = "Not_yet";
            }

            if (CbxOneYear.Text == "")
            {
                CbxOneYear.Text = "Not_yet";
            }



            Info.cnn.Open();
            MySqlCommand cmd1 = new MySqlCommand("Update baby_" + int.Parse(LblID.Text) + " set dose_1_date_injected = @date1 where vac_no = @id", Info.cnn);
            cmd1.Parameters.AddWithValue("@id", "1");
            cmd1.Parameters.AddWithValue("@date1", CbxBirth.Text);

            MySqlCommand cmd2 = new MySqlCommand("Update baby_" + int.Parse(LblID.Text) + " set dose_1_date_injected = @date1 where vac_no = @id", Info.cnn);
            cmd2.Parameters.AddWithValue("@id", "2");
            cmd2.Parameters.AddWithValue("@date1", CbxBirth.Text);

            MySqlCommand cmd3 = new MySqlCommand("Update baby_" + int.Parse(LblID.Text) + " set dose_1_date_injected = @date1 where vac_no = @id", Info.cnn);
            cmd3.Parameters.AddWithValue("@id", "3");
            cmd3.Parameters.AddWithValue("@date1", CbxOneAndHalf.Text);

            MySqlCommand cmd4 = new MySqlCommand("Update baby_" + int.Parse(LblID.Text) + " set dose_1_date_injected = @date1 where vac_no = @id", Info.cnn);
            cmd4.Parameters.AddWithValue("@id", "4");
            cmd4.Parameters.AddWithValue("@date1", CbxOneAndHalf.Text);

            MySqlCommand cmd5 = new MySqlCommand("Update baby_" + int.Parse(LblID.Text) + " set dose_1_date_injected = @date1 where vac_no = @id", Info.cnn);
            cmd5.Parameters.AddWithValue("@id", "5");
            cmd5.Parameters.AddWithValue("@date1", CbxOneAndHalf.Text);

            MySqlCommand cmd6 = new MySqlCommand("Update baby_" + int.Parse(LblID.Text) + " set dose_2_date_injected = @date2 where vac_no = @id", Info.cnn);
            cmd6.Parameters.AddWithValue("@id", "3");
            cmd6.Parameters.AddWithValue("@date2", CbxTwoAndHalf.Text);

            MySqlCommand cmd7 = new MySqlCommand("Update baby_" + int.Parse(LblID.Text) + " set dose_2_date_injected = @date2 where vac_no = @id", Info.cnn);
            cmd7.Parameters.AddWithValue("@id", "4");
            cmd7.Parameters.AddWithValue("@date2", CbxTwoAndHalf.Text);

            MySqlCommand cmd8 = new MySqlCommand("Update baby_" + int.Parse(LblID.Text) + " set dose_2_date_injected = @date2 where vac_no = @id", Info.cnn);
            cmd8.Parameters.AddWithValue("@id", "5");
            cmd8.Parameters.AddWithValue("@date2", CbxTwoAndHalf.Text);

            MySqlCommand cmd9 = new MySqlCommand("Update baby_" + int.Parse(LblID.Text) + " set dose_3_date_injected = @date3 where vac_no = @id", Info.cnn);
            cmd9.Parameters.AddWithValue("@id", "3");
            cmd9.Parameters.AddWithValue("@date3", CbxThreeAndHalf.Text);

            MySqlCommand cmd10 = new MySqlCommand("Update baby_" + int.Parse(LblID.Text) + " set dose_3_date_injected = @date3 where vac_no = @id", Info.cnn);
            cmd10.Parameters.AddWithValue("@id", "4");
            cmd10.Parameters.AddWithValue("@date3", CbxThreeAndHalf.Text);

            MySqlCommand cmd11 = new MySqlCommand("Update baby_" + int.Parse(LblID.Text) + " set dose_3_date_injected = @date3 where vac_no = @id", Info.cnn);
            cmd11.Parameters.AddWithValue("@id", "5");
            cmd11.Parameters.AddWithValue("@date3", CbxThreeAndHalf.Text);

            MySqlCommand cmd12 = new MySqlCommand("Update baby_" + int.Parse(LblID.Text) + " set dose_1_date_injected = @date1 where vac_no = @id", Info.cnn);
            cmd12.Parameters.AddWithValue("@id", "6");
            cmd12.Parameters.AddWithValue("@date1", CbxThreeAndHalf.Text);


            MySqlCommand cmd13 = new MySqlCommand("Update baby_" + int.Parse(LblID.Text) + " set dose_1_date_injected = @date1 where vac_no = @id", Info.cnn);
            cmd13.Parameters.AddWithValue("@id", "7");
            cmd13.Parameters.AddWithValue("@date1", CbxNineMonth.Text);

            MySqlCommand cmd14 = new MySqlCommand("Update baby_" + int.Parse(LblID.Text) + " set dose_2_date_injected = @date2 where vac_no = @id", Info.cnn);
            cmd14.Parameters.AddWithValue("@id", "7");
            cmd14.Parameters.AddWithValue("@date2", CbxOneYear.Text);

            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
            cmd5.ExecuteNonQuery();
            cmd6.ExecuteNonQuery();
            cmd7.ExecuteNonQuery();
            cmd8.ExecuteNonQuery();
            cmd9.ExecuteNonQuery();
            cmd10.ExecuteNonQuery();
            cmd11.ExecuteNonQuery();
            cmd12.ExecuteNonQuery();
            cmd13.ExecuteNonQuery();
            cmd14.ExecuteNonQuery();
            Info.cnn.Close();
            MessageBox.Show("Update Successful");



            MySqlCommand cmd = new MySqlCommand("select * from baby_info where id = " + int.Parse(LblID.Text), Info.cnn);
            Info.cnn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int idb = Convert.ToInt32(reader["id"]);
                string fName = reader["first_name"].ToString();
                string mName = reader["middle_name"].ToString();
                string lName = reader["last_name"].ToString();
                string gend = reader["gender"].ToString();
                DateTime born = Convert.ToDateTime(reader["birthdate"]);
                Info.cnn.Close();
                Update ud = new Update(idb, fName, mName, lName, gend, born);
                this.Hide();
                ud.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("select * from baby_info where id = " + int.Parse(LblID.Text), Info.cnn);
            Info.cnn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int idb = Convert.ToInt32(reader["id"]);
                string fName = reader["first_name"].ToString();
                string mName = reader["middle_name"].ToString();
                string lName = reader["last_name"].ToString();
                string gend = reader["gender"].ToString();
                DateTime born = Convert.ToDateTime(reader["birthdate"]);
                Info.cnn.Close();
                Update ud = new Update(idb, fName, mName, lName, gend, born);
                this.Hide();
                ud.Show();
            }
        }

        private void AddInject_Load(object sender, EventArgs e)
        {

        }

        private void CbxBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbxOneAndHalf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbxTwoAndHalf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbxThreeAndHalf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbxNineMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbxOneYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dtpAtBirth_ValueChanged(object sender, EventArgs e)
        {
            CbxBirth.Text = dtpAtBirth.Value.ToShortDateString();
        }

        private void dtpOneAndHalf_ValueChanged(object sender, EventArgs e)
        {
            CbxOneAndHalf.Text = dtpOneAndHalf.Value.ToShortDateString();
        }

        private void dtpTwoAndHalf_ValueChanged(object sender, EventArgs e)
        {
            CbxTwoAndHalf.Text = dtpTwoAndHalf.Value.ToShortDateString();
        }

        private void dtpThreeAndHalf_ValueChanged(object sender, EventArgs e)
        {
            CbxThreeAndHalf.Text = dtpThreeAndHalf.Value.ToShortDateString();
        }

        private void dtpNineMonth_ValueChanged(object sender, EventArgs e)
        {
            CbxNineMonth.Text = dtpNineMonth.Value.ToShortDateString();
        }

        private void dtpOneYear_ValueChanged(object sender, EventArgs e)
        {
            CbxOneYear.Text = dtpOneYear.Value.ToShortDateString();
        }
    }
}
