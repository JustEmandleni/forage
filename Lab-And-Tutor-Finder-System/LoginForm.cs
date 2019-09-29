using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab_And_Tutor_Finder_System
{
    /// <summary>
    /// Project: Forage
    /// Programmer: Emandleni Moyo s216673380@mandela.ac.za
    /// Programmer: Lavhelesani Mamphwe s217055443@mandela.ac.za
    /// Date: 2019/07/11
    /// Date: 2019/09/19
    /// Date: 2019/09/25
    /// Description: This class defines the behavior of the login form.
    /// </summary>
    /// 
    public partial class LoginForm : Form
    {
        string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\TEAM_12_ULTRON_3_FORAGE_DATABASE.mdf;Integrated Security=True;Connect Timeout=30";

        SqlConnection CONNECTION;
        public LoginForm()
        {
            InitializeComponent();
            CONNECTION = new SqlConnection(CONNECTION_STRING);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            roleComboBox.SelectedIndex = 0;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (CONNECTION.State == ConnectionState.Closed)
                CONNECTION.Open();

            //0 = STUDENT 1 = TUTOR 2 = ADMIN
            int ROLE = roleComboBox.SelectedIndex;
           
            string SQL_SELECT_STMNT = "";
            switch (ROLE)
            {
                case 0: SQL_SELECT_STMNT = "SELECT * FROM Student WHERE studentUsername = '" + usernameTextBox.Text + "' AND studentPassword = '" + passwordTextBox.Text + "';";
                    break;
                case 1: SQL_SELECT_STMNT = SQL_SELECT_STMNT = "SELECT * FROM Tutor WHERE tutorUsername = '" + usernameTextBox.Text + "' AND tutorPassword = '" + passwordTextBox.Text + "';";
                    break;
                default:
                    SQL_SELECT_STMNT = SQL_SELECT_STMNT = "SELECT * FROM Admin WHERE adminUsername = '" + usernameTextBox.Text + "' AND adminPassword = '" + passwordTextBox.Text + "';";
                    break;
            }

        
                SqlDataAdapter DATA_ADAPTER = new SqlDataAdapter(SQL_SELECT_STMNT, CONNECTION);

                DataTable DATA_TABLE = new DataTable();
                DATA_ADAPTER.Fill(DATA_TABLE);

                
              if (DATA_TABLE.Rows.Count > 0)
          {   
             
              Hide();
              switch (ROLE)
              {   
                  case 0: new StudentEntryForm().Show();
                      break;
                  case 1: new TutorDashboardForm(usernameTextBox.Text).Show();
                      break;
                  default: new ManageTutorsForm().Show();
                      break;
              }
          }
          else
          {
              MessageBox.Show("If you don't have an account consider registering.", "Incorrect credentials", MessageBoxButtons.OK, MessageBoxIcon.Information); 
          }
              
            CONNECTION.Close();
        }
      
        private void registerButton_Click(object sender, EventArgs e)
        {   
            Hide();

            if (roleComboBox.SelectedIndex == 0)
                new StudentRegistrationForm().Show();
            else new TutorRegistrationForm().Show();
        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleComboBox.SelectedIndex == 2)
            {
                noAccountPromptLabel.Visible = false;
                registerButton.Visible = false;
            }
            else
            {
                noAccountPromptLabel.Visible = true;
                registerButton.Visible = true;
            }
        }

        private void forageLabel_Click(object sender, EventArgs e)
        {

        }
    }
}