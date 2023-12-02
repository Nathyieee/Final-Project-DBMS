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
    public partial class dashboardcs : Form
    {
        public dashboardcs()
        {
            InitializeComponent();
        }

        private void dashboardcs_Load(object sender, EventArgs e)
        {
            timer1.Start();

            datelabel.Text = DateTime.Now.ToLongDateString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            appointment ds = new appointment();
            ds.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addpatient ds = new addpatient();
            ds.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doctors ds = new doctors();
            ds.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewappointments ds = new viewappointments();
            ds.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MedicalRecords ds = new MedicalRecords();
            ds.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            invoicescs ds = new invoicescs();
            ds.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 back = new Form1();
            back.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerlabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            aboutus ds = new aboutus();
            ds.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dashboardcs ds = new dashboardcs();
            ds.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            contacts ds = new contacts();
            ds.Show();
            this.Hide();
        }
    }
}
