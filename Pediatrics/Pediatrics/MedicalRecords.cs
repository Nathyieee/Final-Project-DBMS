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
    public partial class MedicalRecords : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1; user=root; database=pediatrics; password=");
        MySqlDataAdapter adapt;
        MySqlCommand cmd;
        DataTable dt;
        public MedicalRecords()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from pediatrics.patient", connection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void ClearData()
        {
            idtextbox.Text = "";
            patienttextbox.Text = "";
            firstnametextbox.Text = "";
            lastnametextbox.Text = "";
            dateofbirthtextbox.Text = "";
            contacttextbox.Text = "";
            gendertextbox.Text = "";
            addresstextbox.Text = "";
        }

        private void MedicalRecords_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM pediatrics.patient WHERE Patient_Id = @id", connection);
            cmd1.Parameters.AddWithValue("@id", patienttextbox.Text);
            connection.Open();
            bool userExists = false;
            using (var dr1 = cmd1.ExecuteReader())
            {
                if (userExists = dr1.HasRows)
                    adapt = new MySqlDataAdapter("select * from pediatrics.patient where Patient_Id like '" + patienttextbox.Text + "%'", connection);
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

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayData();
            ClearData();
        }

        private void namebutton_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM pediatrics.patient WHERE fname = @UserName", connection);
            cmd1.Parameters.AddWithValue("@UserName", nametextbox.Text);
            connection.Open();
            bool userExists = false;
            using (var dr1 = cmd1.ExecuteReader())
                if (userExists = dr1.HasRows)
                    adapt = new MySqlDataAdapter("select * from pediatrics.patient where fname like '" + nametextbox.Text + "%'", connection);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            ClearData();
            connection.Close();

            if (!(userExists))
            {
                MessageBox.Show("Username not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
                ClearData();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();

            dashboardcs back = new dashboardcs();
            back.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idtextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            firstnametextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            lastnametextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateofbirthtextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            gendertextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            contacttextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            addresstextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idtextbox.Text != "" && firstnametextbox.Text != "" && lastnametextbox.Text != "" && dateofbirthtextbox.Text != "" && gendertextbox.Text != "" && contacttextbox.Text != "" && addresstextbox.Text != "")
            {
                cmd = new MySqlCommand("delete from pediatrics.patient where Patient_Id=@Patient_Id", connection);
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (idtextbox.Text != "" && firstnametextbox.Text != "" && lastnametextbox.Text != "" && dateofbirthtextbox.Text != "" && gendertextbox.Text != "" && contacttextbox.Text != "" && addresstextbox.Text != "")
            {
                cmd = new MySqlCommand("update pediatrics.patient set fname=@fname, lname=@lname, dob=@dob, gender=@gender, contact=@contact, address=@address where Patient_Id=@Patient_Id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@Patient_Id", idtextbox.Text);
                cmd.Parameters.AddWithValue("@fname", firstnametextbox.Text);
                cmd.Parameters.AddWithValue("@lname", lastnametextbox.Text);
                cmd.Parameters.AddWithValue("@dob", dateofbirthtextbox.Text);
                cmd.Parameters.AddWithValue("@gender", gendertextbox.Text);
                cmd.Parameters.AddWithValue("@contact", contacttextbox.Text);
                cmd.Parameters.AddWithValue("@address", addresstextbox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Successfully Updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Select the record you want to Update", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
