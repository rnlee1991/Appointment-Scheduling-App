using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;



namespace C969___PA
{
    public partial class MainScreen : Form // MainScreen and all other Screens inherit from Windows Forms class.
    {
        string connString = "server = wgudb.ucertify.com; database = U07xPr; uid = U07xPr; pwd = 53689162285;";
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DateTime currentDate;
        public static int currentSelectedCustomerIndex;
        public static int currentCustomerID;
        public static string currentCustomerName;
        public static int currentCustomerActive;
        public static int currentCustomerAddressID;
        public static int currentSelectedCustomerColumn;
        public static int currentSelectedAppointmentIndex;
        public static int currentSelectedAppointmentID;
        public static int currentSelectedType;
        public static string currentSelectedApptType;


        Action moveToAddAppt = () => { AddAppointment newAdd = new AddAppointment(); newAdd.ShowDialog(); }; // Lambda expression #1 to make page navigation easier to read and yield faster execution times
        Action moveToModAppt = () => { ModAppointment newMod = new ModAppointment(); newMod.ShowDialog(); }; // Lambda expression #2 as above for more concise code
        Action moveToAddCust = () => { AddCust newCust = new AddCust(); newCust.ShowDialog(); }; // Lambda expression #3 used as in #1 and #2 for code readability and faster execution times
        Action moveToModCust = () => { ModCust modCust = new ModCust(); modCust.ShowDialog(); }; // Lambda expression #4 used as in #1, #2, and #3 for clarity and to ensure faster page-to-page navigation
        private void getData(string s) // encapsulated method to fill a data table.
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand cmd = new MySqlCommand(s, conn);
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
              
            }
        }

        public MainScreen() // Records current date, highlights calendar, shows all appointments
        {
            InitializeComponent();
            currentDate = DateTime.Now;
            calendar.AddBoldedDate(currentDate);
            appts.DataSource = dt;
            alltimeRB.Checked = true;
            custs.DataSource = dt2;

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM appointment;", conn);
                conn.Open();
                dt.Load(cmd.ExecuteReader());
                cmd.CommandText = "SELECT * FROM customer;";
                dt2.Load(cmd.ExecuteReader());
            }
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                dt.Rows[index]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[index]["start"], TimeZoneInfo.Local).ToString();
                dt.Rows[index]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[index]["end"], TimeZoneInfo.Local).ToString();
            }


            DateTime now = DateTime.Now;

            foreach (DataGridViewRow dataRow in appts.Rows) // 15-Minute Appointment Reminder
            {
                DateTime apptStart = (DateTime)dataRow.Cells[2].Value;
                TimeSpan difference = now - apptStart;
                if (difference.TotalMinutes >= -15 && difference.TotalMinutes <= 1)
                {
                    MessageBox.Show("There is an appointment scheduled with Customer number " + dataRow.Cells[0].Value + " beginning in 15 minutes or less");
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void handleWeek() // Show appointments by the week
        {
            calendar.RemoveAllBoldedDates();
            dt.Clear();
            int dow = (int)currentDate.DayOfWeek;
            string start = currentDate.AddDays(-dow).ToString();
            DateTime tempDate = Convert.ToDateTime(start);

            for (int i = 0; i < 7; i++)
            {
                calendar.AddBoldedDate(tempDate.AddDays(i));
            }
            calendar.UpdateBoldedDates();
            string startDate = currentDate.AddDays(-dow).ToString("yyyy/MM/dd hh:mm:00");
            string endDate = currentDate.AddDays(7 - dow).ToString("yyyy/MM/dd hh:mm:00");
            getData("SELECT * FROM appointment WHERE start BETWEEN '" + startDate + "' AND '" + endDate + "'");
            appts.DataSource = dt;
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                dt.Rows[index]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[index]["start"], TimeZoneInfo.Local).ToString();
                dt.Rows[index]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[index]["end"], TimeZoneInfo.Local).ToString();
            }
        }

        private void handleMonth() // Show appointments by the month
        {
            calendar.RemoveAllBoldedDates();
            dt.Clear();
            int mo = currentDate.Month;
            int yr = currentDate.Year;

            getData("SELECT * FROM appointment " +
                "WHERE  MONTH(start) = " + mo + " AND YEAR(start) = " + yr + ";");
            appts.DataSource = dt;
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                dt.Rows[index]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[index]["start"], TimeZoneInfo.Local).ToString();
                dt.Rows[index]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[index]["end"], TimeZoneInfo.Local).ToString();
            }
        }

        private void appointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.appointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.u07xPrDataSet);

        }

        private void closeButton_Click(object sender, EventArgs e) // Close program
        {
            Application.Exit();
        }

        private void addAppt_Click(object sender, EventArgs e) 
        {   
            this.Hide();
            moveToAddAppt();
        }

        private void modAppt_Click(object sender, EventArgs e) // Polymorphism Implementation
        {
            this.Hide();
            moveToModAppt();
        }

        private void calendar_DateSelected(object sender, DateRangeEventArgs e) // Selects a Calendar Date for Appointment View
        {
            dt.Clear();
            currentDate = e.Start;
            if (weekRadio.Checked)
            {
                handleWeek();
            }
            else if (alltimeRB.Checked)
            {
                getData("SELECT * FROM appointment");
                appts.DataSource = dt;
            }
            else
            {
                handleMonth();
            }

        }

        private void monthRadio_CheckedChanged(object sender, EventArgs e) // Executes Month handler
        {
            dt.Clear();
            handleMonth();
        }

        private void weekRadio_CheckedChanged(object sender, EventArgs e) // Executes week handler
        {
            dt.Clear();
            handleWeek();
        }

        private void alltimeRB_CheckedChanged(object sender, EventArgs e) // Shows all appointments
        {
             dt.Clear();
                getData("SELECT * FROM appointment");
                appts.DataSource = dt;
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                dt.Rows[index]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[index]["start"], TimeZoneInfo.Local).ToString();
                dt.Rows[index]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[index]["end"], TimeZoneInfo.Local).ToString();
            }
        }

        private void appts_CellClick(object sender, DataGridViewCellEventArgs e) // Select an appointment
        {
            currentSelectedAppointmentIndex = appts.CurrentCell.RowIndex;
            currentSelectedAppointmentID = (int)dt.Rows[currentSelectedAppointmentIndex][0];
        }

        private void addCust_Click(object sender, EventArgs e) // Polymorphism Implementation
        {
            this.Hide();
            moveToAddCust();
        }

        private void modCust_Click(object sender, EventArgs e) // Polymorphism implementation
        {
            this.Hide();
            moveToModCust();
        }

        private void custs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentSelectedCustomerIndex = custs.CurrentCell.RowIndex;
            currentCustomerID = (int)dt2.Rows[currentSelectedCustomerIndex][0];
            currentCustomerName = dt2.Rows[currentSelectedCustomerIndex][1].ToString();
            currentCustomerAddressID = (int)dt2.Rows[currentSelectedCustomerIndex][2];
            currentCustomerActive = Convert.ToInt32(dt2.Rows[currentSelectedCustomerIndex][3]);
        }

        private void deleteCust_Click(object sender, EventArgs e) // Delete customer record 
        {
                DialogResult deleteCustomer = MessageBox.Show("Are you sure you wish to delete this customer?", "Delete Customer?", MessageBoxButtons.YesNo);
                if (deleteCustomer == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        try
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = "DELETE FROM customer WHERE customerId = '" + currentCustomerID + "';";
                            cmd.Connection = conn;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = "DELETE FROM address WHERE addressId = '" + currentCustomerAddressID + "';";
                            cmd.ExecuteNonQuery();
                            dt2.Clear();
                            cmd.CommandText = "SELECT * FROM customer;";
                            dt2.Load(cmd.ExecuteReader());

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Exception: " + ex, "Warning");
                        }

                    }
                }
                else
                {
                    //do nothing
                }
            }

        private void deleteAppt_Click(object sender, EventArgs e)
        {
            DialogResult deleteAppt = MessageBox.Show("Are you sure you wish to delete this appointment?", "Delete Appointment?", MessageBoxButtons.YesNo);
            if (deleteAppt == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM appointment WHERE appointmentId = '" + currentSelectedAppointmentID + "'");
                        cmd.Connection = conn;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        dt.Clear();
                        cmd.CommandText = "SELECT * FROM appointment";
                        dt.Load(cmd.ExecuteReader());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex, "Warning");
                    }
                }
            }
            else
            {
                //do nothing
            }
        }

        private void typeByMonth_CheckedChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
            
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT MONTH(start) AS month, type, COUNT(type) FROM appointment GROUP BY MONTH(start), type;";
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable apptTypeReport = new DataTable();
                cmd.Connection = conn;
                conn.Open();
                adp.Fill(apptTypeReport);
               



            } 


        }

        private void apptsByCustomer_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void apptTypebyMonth_Click(object sender, EventArgs e)
        {
            AppointmentTypes appt = new AppointmentTypes();
            this.Hide();
            appt.Show();
        }

        private void userScheduleReport_Click(object sender, EventArgs e)
        {
            UserSchedule userReport = new UserSchedule();
            this.Hide();
            userReport.Show();
        }

        private void apptsByCustomer_Click(object sender, EventArgs e)
        {
            ApptsByCustomer custReport = new ApptsByCustomer();
            this.Hide();
            custReport.Show();
        }

        private void searchBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox1.Text))
            {
                searchButton1.Enabled = false;
                searchBox1.BackColor = Color.Salmon;
            }

            else
            {
                searchButton1.Enabled = true;
                searchBox1.BackColor = Color.White;
            }
        }

        private void searchButton1_Click(object sender, EventArgs e) // Search functionality for Appointment Types
        {
            appts.ClearSelection();
            appts.DefaultCellStyle.SelectionBackColor = Color.Green;
            bool found = false;
            if (searchBox1.Text != "")
            {
                foreach (DataGridViewRow row in appts.Rows)
                {
                    if (row.Cells[1].Value.ToString().ToUpper().Contains(searchBox1.Text.ToUpper()))
                    {
                        row.Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing Found.");
            }
        }

        private void searchBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox2.Text))
            {
                searchButton2.Enabled = false;
                searchBox2.BackColor = Color.Salmon;
            }

            else
            {
                searchButton2.Enabled = true;
                searchBox2.BackColor = Color.White;
            }
        }

        private void searchButton2_Click(object sender, EventArgs e) // Search Functionality for Customer Names
        {
            custs.ClearSelection();
            custs.DefaultCellStyle.SelectionBackColor = Color.Green;
            bool found = false;
            if (searchBox2.Text != "")
            {
                foreach (DataGridViewRow row in custs.Rows)
                {
                    if (row.Cells[1].Value.ToString().ToUpper().Contains(searchBox2.Text.ToUpper()))
                    {
                        row.Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing Found.");
            }
        }
    }
}
