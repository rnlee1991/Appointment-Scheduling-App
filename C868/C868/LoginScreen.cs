using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;



namespace C969___PA
{
    public partial class LoginScreen : Form
    {

        ResourceManager rm = new ResourceManager("C969___PA.Resources.LoginScreen", Assembly.GetExecutingAssembly());
        public StreamWriter fileWriter;
        public string fileName = "logintracker.txt";


        public LoginScreen()
        {
            InitializeComponent();

            FileStream inp = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            fileWriter = new StreamWriter(inp);

            mainLabel.Text = rm.GetString("Main Label Text");
            loginLabel.Text = rm.GetString("Login Label Text");
            userName.Text = rm.GetString("User Name Label Text");
            passwordLabel.Text = rm.GetString("Password Label Text");
            signInButton.Text = rm.GetString("Sign In");
            closeButton.Text = rm.GetString("Close");

        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            switch (CultureInfo.CurrentCulture.TwoLetterISOLanguageName)
            {
                case "es":
                    
                    break;
                default:
                    //no changes
                    break;
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            

            MySqlConnection con = new MySqlConnection("server = wgudb.ucertify.com; database = U07xPr; uid = U07xPr; pwd = 53689162285;");
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT COUNT(*) FROM user WHERE userName = '" + userNameTB.Text + "' AND password = '" + passwordTB.Text + "'", con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                fileWriter.WriteLine("Successful login attempt made on: " + DateTime.Now);
                fileWriter.Close();
                MainScreen main = new MainScreen();
                this.Hide();
                main.Show();
            }
            else
            {
                fileWriter.WriteLine("Unsuccessful login attempt made on: " + DateTime.Now);
                MessageBox.Show(rm.GetString("Invalid Username/Password Body"));
            }
        }
    }
}
