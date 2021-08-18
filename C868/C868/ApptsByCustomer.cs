using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969___PA
{
    public partial class ApptsByCustomer : Form
    {
        string connString = "server = wgudb.ucertify.com; database = U07xPr; uid = U07xPr; pwd = 53689162285;";

        public ApptsByCustomer()
        {
            InitializeComponent();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT customerName, customerId FROM customer";
                DataTable custCombo = new DataTable();
                cmd.Connection = conn;
                conn.Open();
                custCombo.Load(cmd.ExecuteReader());
                custApptsCB.DataSource = custCombo;
                custApptsCB.DisplayMember = "customerName";
                custApptsCB.ValueMember = "customerId";
            }

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            MainScreen main = new MainScreen();
            this.Hide();
            main.Show();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM appointment WHERE customerId = '" + custApptsCB.SelectedValue + "';";
                DataTable custReport = new DataTable();
                cmd.Connection = conn;
                conn.Open();
                custReport.Load(cmd.ExecuteReader());
                apptsByCust.DataSource = custReport;
            }
        }

        private void custApptsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
