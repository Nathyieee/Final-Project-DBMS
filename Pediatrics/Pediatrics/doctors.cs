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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pediatrics
{
    public partial class doctors : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1; user=root; database=pediatrics; password=");
        MySqlDataAdapter adapt;
        MySqlCommand cmd;
        DataTable dt;


        public doctors()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from pediatrics.doctor", connection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void ClearData()
        {
            doctoridtextbox.Text = "";
            firstnametextbox.Text = "";
            lastnametextbox.Text = "";
            specialtytextbox.Text = "";
            contactnumbertextbox.Text = "";
            emailtextbox.Text = "";
            scheduletextbox.Text = "";
        }

        private void InsertData(int Doctor_Id, string firstname, string lastname, string specialty, string contact, string email, string schedule)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO doctor (Doctor_Id, firstname, lastname, specialty, contact, email, schedule) " +
                               $"VALUES ('{Doctor_Id}', '{firstname}', '{lastname}', '{specialty}', '{contact}', '{email}', '{schedule}')";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            int Doctor_Id = int.Parse(doctoridtextbox.Text);
            string firstname = firstnametextbox.Text;
            string lastname = lastnametextbox.Text;
            string specialty = specialtytextbox.Text;
            string contact = contactnumbertextbox.Text;
            string email = emailtextbox.Text;
            string schedule = scheduletextbox.Text;

            InsertData(Doctor_Id, firstname, lastname, specialty, contact, email, schedule);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            dashboardcs back = new dashboardcs();
            back.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            doctoridtextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            firstnametextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            lastnametextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            specialtytextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            contactnumbertextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            emailtextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            scheduletextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void doctors_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (doctoridtextbox.Text != "" && firstnametextbox.Text != "" && lastnametextbox.Text != "" && specialtytextbox.Text != "" && emailtextbox.Text != "" && doctoridtextbox.Text != "" && scheduletextbox.Text != "")
            {
                cmd = new MySqlCommand("update pediatrics.doctor set firstname=@firstname, lastname=@lastname, specialty=@specialty, contact=@contact, email=@email, schedule=@schedule where Doctor_Id=@Doctor_Id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@Doctor_Id", doctoridtextbox.Text);
                cmd.Parameters.AddWithValue("@firstname", firstnametextbox.Text);
                cmd.Parameters.AddWithValue("@lastname", lastnametextbox.Text);
                cmd.Parameters.AddWithValue("@specialty", specialtytextbox.Text);
                cmd.Parameters.AddWithValue("@contact", contactnumbertextbox.Text);
                cmd.Parameters.AddWithValue("@email", emailtextbox.Text);
                cmd.Parameters.AddWithValue("@schedule", scheduletextbox.Text);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (doctoridtextbox.Text != "" && firstnametextbox.Text != "" && lastnametextbox.Text != "" && specialtytextbox.Text != "" && emailtextbox.Text != "" && doctoridtextbox.Text != "" && scheduletextbox.Text != "")
            {
                cmd = new MySqlCommand("delete from pediatrics.doctor where Doctor_Id=@Doctor_Id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@Doctor_Id", doctoridtextbox.Text);
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

        private void scheduletextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
