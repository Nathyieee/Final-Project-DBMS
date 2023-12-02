using MySql.Data.MySqlClient;
using Org.BouncyCastle.Security.Certificates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pediatrics
{
    public partial class appointment : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1; user=root; database=pediatrics; password=");
        public appointment()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            patientidtextbox.Text = "";
            appointmentdatetextbox.Text = "";
            appointmenttimetextbox.Text = "";
            doctoridtextbox.Text = "";
            appointmenttextbox.Text = "";
            purposetextbox.Text = "";
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

        private void appointment_Load(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            int appointment_id = int.Parse(appointmenttextbox.Text);
            int patient_id = int.Parse(patientidtextbox.Text);
            int doctor_id = int.Parse(doctoridtextbox.Text);
            string appointment_date = appointmentdatetextbox.Text;
            string appointment_time = appointmenttimetextbox.Text;
            string purpose = purposetextbox.Text;



            InsertData(appointment_id, patient_id, doctor_id, appointment_date, appointment_time, purpose);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            dashboardcs back = new dashboardcs();
            back.Show();
        }

        private void purposetextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
