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
    public partial class AddAppointment : Form
    {
        string connString = "server = wgudb.ucertify.com; database = U07xPr; uid = U07xPr; pwd = 53689162285;";
        DataTable dt = new DataTable();
        public TimeSpan open = new TimeSpan(08, 0, 0);
        public TimeSpan close = new TimeSpan(17, 0 , 0);
        public DateTime suggestedStart = new DateTime();
        public DateTime suggestedEnd = new DateTime();

        private void getData(string s)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand cmd = new MySqlCommand(s, conn);
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
        }
        public AddAppointment()
        {
            InitializeComponent();
            getData("Select * from customer");
            custIDCombo.DataSource = dt;
            custIDCombo.DisplayMember = "customerName";
            custIDCombo.ValueMember = "customerId";
            saveButton.Enabled = false;
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainScreen main = new MainScreen();
            this.Hide();
            main.Show();
        }
        private void typeTB_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (typeTB.SelectedItem == null)
            {
                typeTB.BackColor = Color.Salmon;
                saveButton.Enabled = false;
                MessageBox.Show("Appointment Type cannot be left blank, please enter an appointment type.", "Error.");
            }
            else
            {
                typeTB.BackColor = Color.White;
                saveButton.Enabled = true;
            }

        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan startTime = startDatePicker.Value.TimeOfDay;
            if (TimeSpan.Compare(startTime, open) == -1)
            {
                MessageBox.Show("Appointments cannot be scheduled before opening time of 8:00 AM, please choose another time.", "Error");
            }
            else
            {
                //do nothing
            }

            if (TimeSpan.Compare(startTime, close) == 1)
            {
                MessageBox.Show("Appointments cannot be scheduled after closing time of 5:00 PM, please choose another time.", "Error");
            }
           
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan endTime = endDatePicker.Value.TimeOfDay;
            if(TimeSpan.Compare(endTime, open) == -1)
            {
                MessageBox.Show("Appointments cannot be scheduled before opening time of 8:00 AM, please choose another time.", "Error");
            }
            else
            {
                //do nothing
            }

            if(TimeSpan.Compare(endTime, close) == 1)
            {
                MessageBox.Show("Appointments cannot end past closing time of 5:00 PM. Please choose another time.", "Error");
            }
            else
            {
                //do nothing
            }

            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int scheduleConflict;
            suggestedStart = TimeZoneInfo.ConvertTimeToUtc(startDatePicker.Value);
            suggestedEnd = TimeZoneInfo.ConvertTimeToUtc(endDatePicker.Value);
           
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT COUNT(appointmentId) " +
                        "FROM appointment " +
                        "WHERE (start <= '" + suggestedStart.ToString("yyyy-MM-dd HH:mm:00") + "' AND '" + suggestedStart.ToString("yyyy-MM-dd HH:mm:00") + "' <= end) " +
                        "OR (start <= '" + suggestedEnd.ToString("yyyy-MM-dd HH:mm:00") + "' AND '" + suggestedEnd.ToString("yyyy-MM-dd HH:mm:00") + "' <= end);", conn);
                    scheduleConflict = Convert.ToInt32(cmd.ExecuteScalar());

                    if (scheduleConflict != 0)
                    {
                        MessageBox.Show("Appointment Start or End times cannot overlap with existing appointments. Please choose another time.", "Error");
                    }
                    else
                    {

                            cmd.CommandText = "INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES " +
                            "('" + custIDCombo.SelectedValue + "', '1', 'not needed', 'not needed', 'not needed', 'not needed', '" + typeTB.SelectedItem.ToString() + "', 'not needed', '" + suggestedStart.ToString("yyyy-MM-dd HH:mm:00") + "', '" + suggestedEnd.ToString("yyyy-MM-dd HH:mm:00") + "', CURRENT_DATE()," +
                            "'test', CURRENT_DATE(), 'test');";
                            cmd.ExecuteNonQuery();

                    }
                    MainScreen main = new MainScreen();
                    this.Hide();
                    main.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex, "Warning");
            }
            
            
        }


    }
}
