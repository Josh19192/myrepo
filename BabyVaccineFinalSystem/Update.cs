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
    public partial class Update : Form
    {
        int idb;
        string fName;
        string mName;
        string lName;
        string gend;
        DateTime born;
        public Update(int id, string firstName, string midName, string lastName, string gender, DateTime birth)
        {
            InitializeComponent();
            LblID.Text = id.ToString();
            LblName.Text = firstName + " " + midName + " " + lastName;

        }
        public void load()
        {
            MySqlCommand cmd = new MySqlCommand("select * from Baby_" + int.Parse(LblID.Text), Info.cnn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Info.cnn.Open();
            // Bind the DataTable to the DataGridView
            DgvInjectInfo.DataSource = dataTable;
            Info.cnn.Close();
        }
        private void BtnEditProfile_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("select * from baby_info where id = " + int.Parse(LblID.Text), Info.cnn);
            Info.cnn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                idb = Convert.ToInt32(reader["id"]);
                fName = reader["first_name"].ToString();
                mName = reader["middle_name"].ToString();
                lName = reader["last_name"].ToString();
                gend = reader["gender"].ToString();
                born = Convert.ToDateTime(reader["birthdate"]);
                Info.cnn.Close();
                EditProfile ep = new EditProfile(idb, fName, mName, lName, gend, born);
                this.Hide();
                ep.Show();
            }
        }

        private void BtnAddInject_Click(object sender, EventArgs e)
        {
            object v1 = DgvInjectInfo.Rows[0].Cells[3].Value;

            object v2 = DgvInjectInfo.Rows[2].Cells[3].Value;
            object v3 = DgvInjectInfo.Rows[2].Cells[4].Value;
            object v4 = DgvInjectInfo.Rows[2].Cells[5].Value;

            object v5 = DgvInjectInfo.Rows[6].Cells[3].Value;
            object v6 = DgvInjectInfo.Rows[6].Cells[4].Value;

            string w1 = v1.ToString();
            string w2 = v2.ToString();
            string w3 = v3.ToString();
            string w4 = v4.ToString();
            string w5 = v5.ToString();
            string w6 = v6.ToString();


            AddInject av = new AddInject(int.Parse(LblID.Text), LblName.Text, w1, w2, w3, w4, w5, w6);
            this.Hide();
            av.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Viewbaby vb = new Viewbaby();
            this.Hide();
            vb.Show();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
