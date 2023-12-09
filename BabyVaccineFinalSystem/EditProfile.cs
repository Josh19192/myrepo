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
    public partial class EditProfile : Form
    {
        public EditProfile(int id, string firstName, string midName, string lastName, string gender, DateTime birth)
        {
            InitializeComponent();
            LblID.Text = id.ToString();
            TbxFirstName.Text = firstName;
            TbxMidName.Text = midName;
            TbxLastName.Text = lastName;
            CbxGender.Text = gender;
            DtpBirth.Value = birth;
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TbxFirstName.Text == "" || TbxMidName.Text == "" || TbxLastName.Text == "" || CbxGender.Text == "")
            {
                MessageBox.Show("Please fill blank information!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you want sure you want to update this data? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Info.cnn.Open();
                    MySqlCommand cmd1 = new MySqlCommand("Update baby_info set first_name = @Value2, middle_name = @Value3, last_name = @Value4, gender = @Value5, birthdate = @Value6 where ID = @Value1", Info.cnn);

                    cmd1.Parameters.AddWithValue("@Value1", int.Parse(LblID.Text));
                    cmd1.Parameters.AddWithValue("@value2", TbxFirstName.Text);
                    cmd1.Parameters.AddWithValue("@value3", TbxMidName.Text);
                    cmd1.Parameters.AddWithValue("@value4", TbxLastName.Text);
                    cmd1.Parameters.AddWithValue("@value5", CbxGender.Text);
                    cmd1.Parameters.AddWithValue("@value6", DtpBirth.Value);
                    try
                    {
                        cmd1.ExecuteNonQuery();
                        Info.cnn.Close();
                        MessageBox.Show("Update Successful");
                        Update up = new Update(int.Parse(LblID.Text), TbxFirstName.Text, TbxMidName.Text, TbxLastName.Text, CbxGender.Text, DtpBirth.Value);
                        up.Show();
                        this.Hide();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                }
            }
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Update up = new Update(int.Parse(LblID.Text), TbxFirstName.Text, TbxMidName.Text, TbxLastName.Text, CbxGender.Text, DtpBirth.Value);
            up.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want sure you want to delete this data? ", "Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MySqlCommand cmd2 = new MySqlCommand("Delete from baby_info where id = " + LblID.Text + ";", Info.cnn);
                MySqlCommand cmd3 = new MySqlCommand("Drop table Baby_" + LblID.Text + ";", Info.cnn);
                Info.cnn.Open();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                Info.cnn.Close();
                MessageBox.Show("Delete Successfully");
                Viewbaby vb = new Viewbaby();
                this.Hide();
                vb.Show();
            }
            else {

            }
        }
    }
}
