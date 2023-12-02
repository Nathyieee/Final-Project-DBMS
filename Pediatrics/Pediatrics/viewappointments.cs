using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pediatrics
{
    public partial class viewappointments : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1; user=root; database=pediatrics; password=");
        MySqlDataAdapter adapt;
        MySqlCommand cmd;
        DataTable dt;
        public viewappointments()
        {
            InitializeComponent();
            DisplayData();
        }
        private void DisplayData()
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from pediatrics.appointmented", connection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void ClearData()
        {
            idtextbox.Text = "";
        }

        private void viewappointments_Load(object sender, EventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM pediatrics.appointmented WHERE appointment_Id = @id", connection);
            cmd1.Parameters.AddWithValue("@id", idtextbox.Text);
            connection.Open();
            bool userExists = false;
            using (var dr1 = cmd1.ExecuteReader())
            {
                if (userExists = dr1.HasRows)
                    adapt = new MySqlDataAdapter("select * from pediatrics.appointmented where appointment_Id like '" + idtextbox.Text + "%'", connection);
            }

            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            ClearData();
            connection.Close();

            if (!(userExists))
            {
                MessageBox.Show("ID not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
                ClearData();
            }
        }

        private void showalltextbox_Click(object sender, EventArgs e)
        {
            DisplayData();
            ClearData();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();

            dashboardcs back = new dashboardcs();
            back.Show();
        }

        private void search2textbox_Click(object sender, EventArgs e)
        {

        }

        private void nametextbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idtextbox.Text != "")
            {
                cmd = new MySqlCommand("delete from pediatrics.appointmented where Patient_Id=@Patient_Id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@Patient_Id", idtextbox.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Record Successfully Deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Select the record you want to Delete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idtextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
