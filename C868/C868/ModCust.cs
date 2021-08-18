using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace C969___PA
{

    public partial class ModCust : Form
    {

        string connString = "server = wgudb.ucertify.com; database = U07xPr; uid = U07xPr; pwd = 53689162285;";
        DataTable dt = new DataTable();
        DataTable countries = new DataTable();
        DataTable cities = new DataTable();
        public static string currentCustomerAddress;
        public static string currentAddress2;
        public static int currentCityID;
        public static int currentCountryID;
        public static string currentCustomerZIP;
        public static string currentCustomerPhone;


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
        public ModCust()
        {
            InitializeComponent();

            using (MySqlConnection conn = new MySqlConnection(connString)) //Populate ComboBoxes
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM country;", conn);
                conn.Open();
                countries.Load(cmd.ExecuteReader());
                countryCombo.DataSource = countries;
                countryCombo.DisplayMember = "country";
                countryCombo.ValueMember = "countryId";
            }

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM address WHERE addressId = " + MainScreen.currentCustomerAddressID + ";";
                cmd.Connection = conn;
                DataTable customerAddress = new DataTable();
                conn.Open();
                customerAddress.Load(cmd.ExecuteReader());
                currentCustomerAddress = customerAddress.Rows[0][1].ToString();
                currentAddress2 = customerAddress.Rows[0][2].ToString();
                currentCityID = (int)customerAddress.Rows[0][3];
                currentCustomerZIP = customerAddress.Rows[0][4].ToString();
                currentCustomerPhone = customerAddress.Rows[0][5].ToString();
                cmd.CommandText = "SELECT countryId FROM city WHERE cityId = " + currentCityID + ";";
                currentCountryID = Convert.ToInt32(cmd.ExecuteScalar());

            } // Address Reader
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM country;", conn);
                conn.Open();
                countries.Load(cmd.ExecuteReader());
                countryCombo.DataSource = countries;
                countryCombo.DisplayMember = "country";
                countryCombo.ValueMember = "countryId";
            }

            nameTB.Text = MainScreen.currentCustomerName;
            addressTB.Text = currentCustomerAddress;
            address2TB.Text = currentAddress2;
            postalTB.Text = currentCustomerZIP;
            phoneTB.Text = currentCustomerPhone;
            countryCombo.SelectedValue = currentCountryID;
            cityCombo.SelectedValue = currentCityID;
           
            if(MainScreen.currentCustomerActive == 1)
            {
                activeCB.Checked = true;
            }
            else
            {
                activeCB.Checked = false;
            }



        }

        private void countryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {

                switch (countryCombo.SelectedIndex)
                {
                    case 0:
                        dt.Clear();
                        getData("SELECT * FROM city WHERE countryID = 1;");
                        cityCombo.DataSource = dt;
                        cityCombo.DisplayMember = "city";
                        cityCombo.ValueMember = "cityId";
                        break;

                    case 1:
                        dt.Clear();
                        getData("SELECT * FROM city WHERE countryID = 2;");
                        cityCombo.DataSource = dt;
                        cityCombo.DisplayMember = "city";
                        cityCombo.ValueMember = "cityId";
                        break;

                    case 2:
                        dt.Clear();
                        getData("SELECT * FROM city WHERE countryId = 3;");
                        cityCombo.DataSource = dt;
                        cityCombo.DisplayMember = "city";
                        cityCombo.ValueMember = "cityId";
                        break;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainScreen main = new MainScreen();
            this.Hide();
            main.Show();
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTB.Text))
            {
                nameTB.BackColor = Color.Salmon;
                saveButton.Enabled = false;
            }
            else
            {
                nameTB.BackColor = Color.White;
            }
            if (nameTB.BackColor == Color.White && 
                addressTB.BackColor == Color.White &&
               postalTB.BackColor == Color.White &&
               phoneTB.BackColor == Color.White)
            {
                saveButton.Enabled = true;
            }
        }

        private void addressTB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressTB.Text))
            {
                addressTB.BackColor = Color.Salmon;
                saveButton.Enabled = false;
            }
            else
            {
                addressTB.BackColor = Color.White;
            }
            if (nameTB.BackColor == Color.White &&
                addressTB.BackColor == Color.White &&
                postalTB.BackColor == Color.White &&
                phoneTB.BackColor == Color.White)
            {
                saveButton.Enabled = true;
            }
        }

        private void postalTB_TextChanged(object sender, EventArgs e)
        {
            if (postalTB.Text.Length > 6)
            {
                postalTB.BackColor = Color.Salmon;
                saveButton.Enabled = false;
            }
            else if (string.IsNullOrWhiteSpace(postalTB.Text))
            {
                postalTB.BackColor = Color.Salmon;
                saveButton.Enabled = false;
            }
            else
            {
                postalTB.BackColor = Color.White;
            }
            if (nameTB.BackColor == Color.White &&
                addressTB.BackColor == Color.White &&
                postalTB.BackColor == Color.White &&
                phoneTB.BackColor == Color.White)
            {
                saveButton.Enabled = true;
            }
        }

        private void phoneTB_TextChanged(object sender, EventArgs e)
        {
            if (phoneTB.Text.Length > 12)
            {
                phoneTB.BackColor = Color.Salmon;
                saveButton.Enabled = false;
            }
            else if (string.IsNullOrWhiteSpace(phoneTB.Text))
            {
                phoneTB.BackColor = Color.Salmon;
                saveButton.Enabled = false;
            }
            else
            {
                phoneTB.BackColor = Color.White;
            }
            if (nameTB.BackColor == Color.White &&
                addressTB.BackColor == Color.White &&
                postalTB.BackColor == Color.White &&
                phoneTB.BackColor == Color.White)
            {
                saveButton.Enabled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                int v = activeCB.Checked ? 1 : 0;
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "UPDATE address SET address = '" + addressTB.Text + "', address2 = '" + address2TB.Text + "', cityId = " + cityCombo.SelectedValue + ", postalCode = '" + postalTB.Text + "'," +
                    " phone = '" + phoneTB.Text + "', lastUpdate = CURRENT_DATE(), lastUpdateBy = 'test' WHERE addressId = " + MainScreen.currentCustomerAddressID + ";";
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE customer SET customerName = '" + nameTB.Text + "', addressId = '" + MainScreen.currentCustomerAddressID + "', active = " + v + ", " +
                    "lastUpdate = CURRENT_DATE(), lastUpdateBy = 'test' WHERE customerId = " + MainScreen.currentCustomerID + ";";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex, "Warning");
                }

                MainScreen main = new MainScreen();
                this.Hide();
                main.Show();

            }
        }
    }
}
