using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab_And_Tutor_Finder_System
{
    /// <summary>
    /// Project: Forage
    /// Programmer: Emandleni Moyo s216673380@mandela.ac.za
    /// Programmer: Lavhelesani Mamphwe  s217055443@mandela.ac.za
    /// Description: This class defines the behavior of the tutor registration form.
    /// </summary>
    /// 

    [System.Runtime.InteropServices.Guid("1F9B47EF-9D7E-42B6-A429-F4F18F3A4AEA")]
    public partial class TutorRegistrationForm : Form
    {
        string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\TEAM_12_ULTRON_3_FORAGE_DATABASE.mdf;Integrated Security=True;Connect Timeout=30";

        SqlConnection CONNECTION;
        SqlDataAdapter DATA_ADAPTER;
        DataSet DATA_SET;

        public TutorRegistrationForm()
        {
            InitializeComponent();
            CONNECTION = new SqlConnection(CONNECTION_STRING);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            qualificationComboBox.SelectedIndex = 0;

            if (CONNECTION.State == ConnectionState.Closed)
                CONNECTION.Open();

            string SQL_QUERY_ = "SELECT * FROM TUTOR";
            DATA_ADAPTER = new SqlDataAdapter(SQL_QUERY_, CONNECTION);
            DATA_SET = new DataSet();
            DATA_ADAPTER.Fill(DATA_SET, "TUTOR");

            CONNECTION.Close();
        }

       
        private void nextButtonClick_(object sender, EventArgs e)
        {

            if (matchingPassword())
            {
                perfomRegistration();
                Hide();
                SelectModulesForm SMF = new SelectModulesForm(userNameTextBox.Text);
                SMF.Show();
            }
            else
            {
                MessageBox.Show("Passwords Do Not Match", "Re-enter Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordTextBox.Clear();
                retypePasswordTextBox.Clear();
            }
            
        }

        private void perfomRegistration()
        {
            if (CONNECTION.State == ConnectionState.Closed)
                CONNECTION.Open();

            if (!isExisting(userNameTextBox.Text, CONNECTION))
            {
                
                SqlCommand COMMAND = new SqlCommand(@"INSERT INTO TUTOR "+
                    "(tutorUsername, tutorPassword, tutorFName, tutorLName, tutorQualif, tutorYear)"+
                    "VALUES (@tutorUsername, @tutorPassword, @tutorFName, @tutorLName, @tutorQualif, @tutorYear)", CONNECTION);

                COMMAND.Parameters.Add("@tutorUsername", SqlDbType.NVarChar);
                COMMAND.Parameters.Add("@tutorPassword", SqlDbType.NVarChar);
                COMMAND.Parameters.Add("@tutorFName", SqlDbType.NVarChar);
                COMMAND.Parameters.Add("@tutorLName", SqlDbType.NVarChar);
                COMMAND.Parameters.Add("@tutorQualif", SqlDbType.Int);
                COMMAND.Parameters.Add("@tutorYear", SqlDbType.Int);

                COMMAND.Parameters["@tutorUsername"].Value = userNameTextBox.Text;
                COMMAND.Parameters["@tutorPassword"].Value = passwordTextBox.Text;
                COMMAND.Parameters["@tutorFName"].Value = firstNameTextBox.Text;
                COMMAND.Parameters["@tutorLName"].Value = lastNameTextBox.Text;
                COMMAND.Parameters["@tutorQualif"].Value = qualificationComboBox.SelectedIndex;
                COMMAND.Parameters["@tutorYear"].Value = numericUpDown1.Value;

                COMMAND.ExecuteNonQuery();
                Hide();
            }
            else
            {
                MessageBox.Show("We already know you here " + firstNameTextBox.Text + "! Rather log in.", "Account already exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CONNECTION.Close();
        }

        private bool isExisting(string str1, SqlConnection connection)
        {
            string selectQuery = "SELECT * FROM Tutor WHERE tutorUsername = '" + str1 + "'";
         
            DATA_ADAPTER = new SqlDataAdapter(selectQuery, connection);
            DataTable DATA_TABLE = new DataTable();
            DATA_ADAPTER.Fill(DATA_TABLE);

            
            if (DATA_TABLE.Rows.Count > 0)
                return true;
            else return false;
        }

        
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            new LoginForm().Show();
        }

        private bool matchingPassword()
        {
            if (passwordTextBox.Text.Equals(retypePasswordTextBox.Text))
                return true;
            else return false;
        }

    }
}
