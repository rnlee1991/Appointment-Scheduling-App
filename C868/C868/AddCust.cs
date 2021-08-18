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
    public partial class AddCust : Form
    {
        string connString = "server = wgudb.ucertify.com; database = U07xPr; uid = U07xPr; pwd = 53689162285;";
        DataTable dt = new DataTable();
        DataTable countries = new DataTable();
        DataTable cities = new DataTable();


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

        public AddCust()
        {
            InitializeComponent();
            saveButton.Enabled = false;

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM country;", conn);
                conn.Open();
                countries.Load(cmd.ExecuteReader());
                countryCombo.DataSource = countries;
                countryCombo.DisplayMember = "country";
                countryCombo.ValueMember = "countryId";
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainScreen main = new MainScreen();
            this.Hide();
            main.Show();

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
        private void address2TB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(address2TB.Text))
            {
                address2TB.Text = "";
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
                int newID;
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                    "VALUES ('" + addressTB.Text + "', '" + address2TB.Text + "', '" + cityCombo.SelectedValue + "', '" + postalTB.Text + "', '" + phoneTB.Text + "', NOW(), ' test ', CURRENT_DATE() , ' test ');", conn);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT @@IDENTITY";
                    newID = Convert.ToInt32(cmd.ExecuteScalar());
                    getData("INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('" + nameTB.Text + "', '" + newID + "', '" + v + "', NOW(), ' test ', CURRENT_DATE(), ' test ');");
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
