using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969___PA
{
    public partial class AppointmentTypes : Form
    {
        public int month;

        string connString = "server = wgudb.ucertify.com; database = U07xPr; uid = U07xPr; pwd = 53689162285;";
        public AppointmentTypes()
        {
            InitializeComponent();
        }

        private void monthReportCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMonth = monthReportCB.SelectedItem.ToString();
            switch (selectedMonth)
            {
                case "January": month = 1;
                    break;
                case "February": month = 2;
                    break;
                case "March": month = 3;
                    break;
                case "April": month = 4;
                    break;
                case "May": month = 5;
                    break;
                case "June": month = 6;
                    break;
                case "July": month = 7;
                    break;
                case "August": month = 8;
                    break;
                case "September": month = 9;
                    break;
                case "October": month = 10;
                    break;
                case "November": month = 11;
                    break;
                case "December": month = 12;
                    break;
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT type, COUNT(type) FROM appointment WHERE MONTH(start) = " + month + " GROUP BY type;";
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable apptTypeReport = new DataTable();
                cmd.Connection = conn;
                conn.Open();
                adp.Fill(apptTypeReport);
                apptTypeByMonthReport.DataSource = apptTypeReport;
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            MainScreen main = new MainScreen();
            this.Hide();
            main.Show();
        }


    }
}
