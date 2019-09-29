using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab_And_Tutor_Finder_System
{
    /// <summary>
    /// Project: Forage
    /// Programmer: Emandleni Moyo s216673380@mandela.ac.za
    /// Date: 2019/07/11
    /// Date: 2019/09/29
    /// Description: This class defines the behavior of the student registration form.
    /// </summary>
    /// 
    public partial class StudentRegistrationForm : Form
    {
        string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\TEAM_12_ULTRON_3_FORAGE_DATABASE.mdf;Integrated Security=True;Connect Timeout=30";

        SqlConnection CONNECTION;

        public StudentRegistrationForm()
        {
            InitializeComponent();
            CONNECTION = new SqlConnection(CONNECTION_STRING);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private bool isMatch(string a, string b)
        {
            if (a.Equals(b))
                return true;
            else return false;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (CONNECTION.State == ConnectionState.Closed)
                CONNECTION.Open();

            if (!isMatch(passwordTextBox.Text, retypePasswordTextBox.Text))
            {
                MessageBox.Show("Passwords do not match", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                passwordTextBox.Clear();
                retypePasswordTextBox.Clear();
                return;
            }

            if (!isExisting(userNameTextBox.Text, CONNECTION))
            {
                SqlCommand command = new SqlCommand(@"INSERT INTO Student VALUES ('" + userNameTextBox.Text + "', '" + passwordTextBox.Text + "', '" + firstNameTextBox.Text + "', '" + lastNameTextBox.Text + "')", CONNECTION);
                command.ExecuteNonQuery();
                CONNECTION.Close();
                MessageBox.Show("Successfully registered " + firstNameTextBox.Text + "!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                new StudentEntryForm().Show();
            }
            else
            {
                MessageBox.Show("We already know you here "+firstNameTextBox.Text+"! Rather log in.", "Account already exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CONNECTION.Close();
        }

        private bool isExisting(string str1, SqlConnection connection)
        {
            string SQL_SELECT_STMNT = "SELECT * FROM Student WHERE studentUsername = '" + str1 + "'";
          
            SqlDataAdapter DATA_ADAPTER = new SqlDataAdapter(SQL_SELECT_STMNT, connection);
            DataTable DATA_TABLE = new DataTable();
            DATA_ADAPTER.Fill(DATA_TABLE);
            
            if (DATA_TABLE.Rows.Count > 0)
                return true;
            else return false;
        }

    
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            new LoginForm().Show();
        }
    }
}
