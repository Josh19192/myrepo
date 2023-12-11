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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM user_login WHERE user = @user AND password = SHA2(@password,256)", Info.cnn);
            Info.cnn.Open();
            cmd.Parameters.AddWithValue("@user", TbxUser.Text);
            cmd.Parameters.AddWithValue("@password",TbxPass.Text );
            MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Info.cnn.Close();
                    Home hm = new Home();
                    this.Hide();
                    hm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Info.cnn.Close();
                }
            }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblPass_Click(object sender, EventArgs e)
        {

        }

        private void CbxUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblUser_Click(object sender, EventArgs e)
        {

        }

        private void CkbSeePass_CheckedChanged(object sender, EventArgs e)
        {
            if (TbxPass.Text == "Password") { }
            else if (CkbSeePass.Checked)
            {
                TbxPass.UseSystemPasswordChar = false;
                CkbSeePass.Image = Properties.Resources.Unsee2;
               
            }
            else
            {
                TbxPass.UseSystemPasswordChar = true;
                CkbSeePass.Image = Properties.Resources.seepass22;
            }
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd3 = new MySqlCommand("CREATE TABLE IF NOT EXISTS user_login (user varchar(100), password varchar(100))", Info.cnn);
            Info.cnn.Open();
            cmd3.ExecuteNonQuery();
            MySqlCommand cmdd2 = new MySqlCommand("SELECT count(*) from user_login;", Info.cnn);
            long rowCount = (long)cmdd2.ExecuteScalar();
            
            if (rowCount == 0)
            {
                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO user_login(user, password) VALUES('admin',SHA2('admin123',256))", Info.cnn);
                cmd1.ExecuteNonQuery();
                Info.cnn.Close();

            }
            else
            {
                Info.cnn.Close();
            }

            TbxUser.ForeColor = Color.Gray;
            TbxPass.ForeColor = Color.Gray;
        }

        private void TbxUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (TbxUser.Text != "User")
            {
            }
            else
            {
                TbxUser.ForeColor = Color.Black;
                TbxUser.Text = "";
            }
        }

        private void TbxUser_MouseLeave(object sender, EventArgs e)
        {
            if (TbxUser.Text == "") 
            {
                TbxUser.ForeColor = Color.Gray;
                TbxUser.Text = "User";
            }
        }

        private void TbxPass_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void TbxPass_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void TbxPass_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (TbxPass.Text != "Password")
            {
            }
            else
            {
                TbxPass.ForeColor = Color.Black;
                TbxPass.Text = "";
                TbxPass.UseSystemPasswordChar = true;
            }
        }

        private void TbxPass_MouseLeave_1(object sender, EventArgs e)
        {
            if (TbxPass.Text == "")
            {
                TbxPass.ForeColor = Color.Gray;
                TbxPass.Text = "Password";
                TbxPass.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void TbxPass_TextChanged(object sender, EventArgs e)
        {
        }

        private void TbxUser_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
