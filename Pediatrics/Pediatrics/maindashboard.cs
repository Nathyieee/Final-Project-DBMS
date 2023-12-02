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
    public partial class maindashboard : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1; user=root; database=pediatrics; password=");
        public maindashboard()
        {
            InitializeComponent();
        }

        private void InsertData(int Patient_Id, string fname, string lname, string dob, string gender, string contact, string address)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO patient (Patient_Id, fname, lname, dob, Gender, contact, address) " +
                               $"VALUES ('{Patient_Id}', '{fname}', '{lname}', '{dob}', '{gender}', '{contact}', '{address}')";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Patient information Added!");
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addpatientpanel.Visible = true;
        }

        private void maindashboard_Load(object sender, EventArgs e)
        {
            addpatientpanel.Visible = false;
            appointmentpanel.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int Patient_Id = int.Parse(patientidtextbox.Text);
            string fname = firstnametextbox.Text;
            string lname = lastnametextbox.Text;
            string dob = dateofbirthtextbox.Text;
            string gender = sextextbox.Text;
            string contact = contacttextbox.Text;
            string address = addresstextbox.Text;

            InsertData(Patient_Id, fname, lname, dob, gender, contact, address);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            appointmentpanel.Visible = true;
        }

        private void appointmentpanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void InsertData(int appointment_id, int Patient_Id, int Doctor_Id, string AppointmentDate, string AppointmentTime, string Purpose)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO appointmented (appointment_id, Patient_Id, Doctor_Id, AppointmentDate, AppointmentTime, Purpose) " +
                               $"VALUES ('{appointment_id}', '{Patient_Id}', '{Doctor_Id}', '{AppointmentDate}', '{AppointmentTime}', '{Purpose}')";

                MySqlCommand command = new MySqlCommand(query, connection);

                command.ExecuteNonQuery();

                MessageBox.Show("Appointment Added!");
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

        private void button8_Click(object sender, EventArgs e)
        {
            int appointment_id = int.Parse(appointmentidtextbox.Text);
            int patient_id = int.Parse(patientidtextbox.Text);
            int doctor_id = int.Parse(doctoridtextbox.Text);
            string appointment_date = appointmentdatetextbox.Text;
            string appointment_time = appointmenttimetextbox.Text;
            string purpose = purposetextbox.Text;



            InsertData(appointment_id, patient_id, doctor_id, appointment_date, appointment_time, purpose);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            appointmentpanel.Visible = false;
        }
    }
}

