using MySql.Data.MySqlClient;
using System.DirectoryServices;

namespace Pediatrics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string mysqlCon = "server=127.0.0.1; user=root; database=pediatrics; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
                MessageBox.Show("Connection Success!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string username = usernametextbox.Text;
            string password = passwordtextbox.Text;

            if (username == "nath" && password == "pogi")
            {
                this.Hide();

                dashboardcs ds = new dashboardcs();
                ds.Show();
            }
            else
            {
                MessageBox.Show("Wrong username and password!");
            }      
        }

        private void passwordtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usernametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordtextbox.UseSystemPasswordChar = true;
            }
            else
            {
                passwordtextbox.UseSystemPasswordChar = false;
            }
        }
    }
}