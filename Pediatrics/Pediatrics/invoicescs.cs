using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.IsisMtt;
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
    public partial class invoicescs : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1; user=root; database=pediatrics; password=");
        MySqlDataAdapter adapt;
        MySqlCommand cmd;
        DataTable dt;
        public invoicescs()
        {
            InitializeComponent();
            DisplayData();
        }
        private void DisplayData()
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from pediatrics.invoices", connection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void ClearData()
        {
            invoiceidtextbox.Text = "";
            patientidtextbox.Text = "";
            appointmentidtextbox.Text = "";
            doctoridtextbox.Text = "";
            datetextbox.Text = "";
            totalamounttextbox.Text = "";
            paymentstatustextbox.Text = "";
        }
        private void InsertData(int invoiceid, int patientid, int doctorid, int appointmentid, string date, string totalamount, string paymentstatus)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO invoices (invoiceid, patientid, doctorid, appointmentid, date, totalamount, paymentstatus) " +
                               $"VALUES ('{invoiceid}', '{patientid}', '{doctorid}', '{appointmentid}', '{date}', '{totalamount}', '{paymentstatus}')";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Invoices Added!");
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

        private void invoicescs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int voiceid = int.Parse(invoiceidtextbox.Text);
            int patientid = int.Parse(patientidtextbox.Text);
            int doctorid = int.Parse(doctoridtextbox.Text);
            int appointmentid = int.Parse(appointmentidtextbox.Text);
            string date = datetextbox.Text;
            string totalamount = totalamounttextbox.Text;
            string paymentstatus = paymentstatustextbox.Text;

            InsertData(voiceid, patientid, doctorid, appointmentid, date, totalamount, paymentstatus);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            dashboardcs back = new dashboardcs();
            back.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (invoiceidtextbox.Text != "" && patientidtextbox.Text != "" && doctoridtextbox.Text != "" && appointmentidtextbox.Text != "" && datetextbox.Text != "" && totalamounttextbox.Text != "" && paymentstatustextbox.Text != "")
            {
                cmd = new MySqlCommand("delete from pediatrics.invoices where invoiceid=@invoiceid", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@invoiceid", invoiceidtextbox.Text);
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
            invoiceidtextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            appointmentidtextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            patientidtextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            doctoridtextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            datetextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            totalamounttextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            paymentstatustextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void appointmentidtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientidtextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
