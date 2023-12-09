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
    public partial class Viewbaby : Form
    {
        public Viewbaby()
        {
            InitializeComponent();
        }
        public void load()
        {
            MySqlCommand cmd = new MySqlCommand("select * from baby_info", Info.cnn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Info.cnn.Open();
            // Bind the DataTable to the DataGridView
            DgvViewBaby.DataSource = dataTable;
            Info.cnn.Close();
        }
        private void Viewbaby_Load(object sender, EventArgs e)
        {
            load();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM baby_info where id like '%" + TbxSearch.Text + "%' or first_name like '%" + TbxSearch.Text + "%' or last_name like '%" + TbxSearch.Text + "%' or middle_name like '%" + TbxSearch.Text + "%' or gender like '%" + TbxSearch.Text + "%' or birthdate like '%" +TbxSearch.Text + "%'", Info.cnn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                try
                {

                    Info.cnn.Open();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    DgvViewBaby.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Info.cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectRow = DgvViewBaby.Rows[e.RowIndex];
                int id = int.Parse(selectRow.Cells["id"].Value.ToString());
                string firstName = selectRow.Cells["first_name"].Value.ToString();
                string midName = selectRow.Cells["middle_name"].Value.ToString();
                string lastName = selectRow.Cells["last_name"].Value.ToString();
                string gender = selectRow.Cells["gender"].Value.ToString();
                DateTime birth = DateTime.Parse(selectRow.Cells["birthdate"].Value.ToString());

                Update up = new Update(id, firstName, midName, lastName, gender, birth);
                this.Hide();
                up.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Hide();
            hm.Show();
        }

        private void TbxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM baby_info where id like '%" + TbxSearch.Text + "%' or first_name like '%" + TbxSearch.Text + "%' or last_name like '%" + TbxSearch.Text + "%' or middle_name like '%" + TbxSearch.Text + "%' or gender like '%" + TbxSearch.Text + "%' or birthdate like '%" + TbxSearch.Text + "%'", Info.cnn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    try
                    {
                        Info.cnn.Open();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        DgvViewBaby.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        Info.cnn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAddBaby_Click(object sender, EventArgs e)
        {
            AddBaby ab = new AddBaby();
            this.Hide();
            ab.Show();
        }
    }
}
