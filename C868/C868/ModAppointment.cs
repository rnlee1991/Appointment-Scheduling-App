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
    public partial class ModAppointment : Form
    {
        string connString = "server = wgudb.ucertify.com; database = U07xPr; uid = U07xPr; pwd = 53689162285;";
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        public DateTime suggestedStart = new DateTime();
        public DateTime suggestedEnd = new DateTime();

        public ModAppointment()
        {
            InitializeComponent();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM appointment");
                cmd.Connection = conn;
                conn.Open();
                dt.Load(cmd.ExecuteReader());
                cmd.CommandText = "SELECT * FROM customer";
                dt2.Load(cmd.ExecuteReader());
            }

            custIDCombo.DataSource = dt;
            custIDCombo.DisplayMember = dt.Rows[MainScreen.currentSelectedAppointmentIndex]["customerId"].ToString();
            custIDCombo.ValueMember = "customerId";
            custIDCombo.SelectedValue = dt.Rows[MainScreen.currentSelectedAppointmentIndex]["customerId"];
            customerNameCombo.DataSource = dt2;
            customerNameCombo.DisplayMember = "customerName";
            customerNameCombo.ValueMember = "customerId";
            customerNameCombo.SelectedValue = dt.Rows[MainScreen.currentSelectedAppointmentIndex]["customerId"].ToString();
            typeTB.Text = dt.Rows[MainScreen.currentSelectedAppointmentIndex][7].ToString();
            startDatePicker.Value = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[MainScreen.currentSelectedAppointmentIndex][9], TimeZoneInfo.Local);
            endDatePicker.Value = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[MainScreen.currentSelectedAppointmentIndex][10], TimeZoneInfo.Local);
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainScreen main = new MainScreen();
            this.Hide();
            main.Show();
        }

        private void typeTB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(typeTB.Text))
            {
                typeTB.BackColor = Color.Salmon;
                saveButton.Enabled = false;
                MessageBox.Show("Appointment Type cannot be left blank, please enter an appointment type.", "Error.");
            }
            else
            {
                typeTB.BackColor = Color.White;
            }
            if (typeTB.BackColor == Color.White)
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
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
                        cmd.CommandText = ("UPDATE appointment SET customerID = '" + custIDCombo.SelectedValue + "', userId = ' 1 ', title = ' not needed ', description = ' not needed ', location = ' not needed ', " +
                        "contact = ' not needed ', type = '" + typeTB.SelectedItem.ToString() + "', url = ' not needed ', start = '" + suggestedStart.ToString("yyyy-MM-dd HH:mm:00") + "', end = '" + suggestedEnd.ToString("yyyy-MM-dd HH:mm:00") + "', " +
                        "createDate = CURRENT_DATE(), createdBy = ' test ', lastUpdate = CURRENT_DATE(), lastUpdateBy = ' test' WHERE appointmentId = " + MainScreen.currentSelectedAppointmentID + ";");
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
