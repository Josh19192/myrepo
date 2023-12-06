using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            if (TbxPass.Text == "brgyworker")
            {
                MessageBox.Show("Succesfully Login!");
                Home hm = new Home();
                this.Hide();
                hm.Show();
            }
            else {
                MessageBox.Show("Invalid Password, Try again!");
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
            if (CkbSeePass.Checked)
            {
                TbxPass.UseSystemPasswordChar = false;
            }
            else 
            {
                TbxPass.UseSystemPasswordChar = true;
            }
        }
    }
}
