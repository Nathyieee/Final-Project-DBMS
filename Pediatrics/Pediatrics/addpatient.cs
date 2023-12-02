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
    public partial class addpatient : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1; user=root; database=pediatrics; password=");
        public addpatient()
        {
            InitializeComponent();
        }
        private void ClearData()
        {
            patientidtextbox.Text = "";
            firstnametextbox.Text = "";
            lastnametextbox.Text = "";
            dateofbirthtextbox.Text = "";
            contactnumbertextbox.Text = "";
            gendertextbox.Text = "";
            addresstextbox.Text = "";
            parentsfirstnametextbox.Text = "";
            parentslastnametextbox.Text = "";
        }

        private void InsertData(int Patient_Id, string fname, string lname, string dob, string gender, string contact, string address, string ParentsFirstName, string ParentsLastName)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO patient (Patient_Id, fname, lname, dob, Gender, ParentsFirstName, ParentsLastName, contact, address) " +
                               $"VALUES ('{Patient_Id}', '{fname}', '{lname}', '{dob}', '{gender}', '{ParentsFirstName}', '{ParentsLastName}', '{contact}', '{address}')";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Patient information Added!");
                ClearData();
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

        private void addpatient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Patient_Id = int.Parse(patientidtextbox.Text);
            string fname = firstnametextbox.Text;
            string lname = lastnametextbox.Text;
            string dob = dateofbirthtextbox.Text;
            string gender = gendertextbox.Text;
            string contact = contactnumbertextbox.Text;
            string address = addresstextbox.Text;
            string parentsfirstname = parentsfirstnametextbox.Text;
            string parentslastname = parentslastnametextbox.Text;

            InsertData(Patient_Id, fname, lname, dob, gender, contact, address, parentsfirstname, parentslastname);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            dashboardcs back = new dashboardcs();
            back.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

            appointment back = new appointment();
            back.Show();

        }

        private void parentsfirstnametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastnametextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
