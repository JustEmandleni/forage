﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Lab_And_Tutor_Finder_System
{
    public partial class StudentRegistrationForm : Form
    {
        /// <summary>
        /// Project: Forage
        /// Programmer: Emandleni Moyo s216673380@mandela.ac.za
        /// Date: 2019/07/11
        /// Description: This class defines the behavior of the student registration form.
        /// </summary>
        ///
        public StudentRegistrationForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        /**
         * Registers user onto system.
         * If the user does not have an existing account, creates a new account and shows them the student dashboard.
         **/
        private void registerButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project-Information-System;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            if (!isExisting(userNameTextBox.Text, connection))
            {
                SqlCommand command = new SqlCommand(@"INSERT INTO Student VALUES ('" + userNameTextBox.Text + "', '" + passwordTextBox.Text + "', '" + firstNameTextBox.Text + "', '" + lastNameTextBox.Text + "')",connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Successfully registered "+firstNameTextBox.Text+"!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new StudentDashboardForm().Show();
            }
            else //If the user has an existing account 
            {
                MessageBox.Show("We already know you here "+firstNameTextBox.Text+"! Rather log in.", "Account already exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /**
         *  Verifies that the student user does not have an existing account on the system
         **/
        private bool isExisting(string str1, SqlConnection connection)
        {
            string selectQuery = "SELECT * FROM Student WHERE studentUsername = '" + str1 + "'";
            //Gets hold of the result set generated by the SQL query
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            //Iterates through the result set, if there is a row matching
            if (dataTable.Rows.Count > 0)
                return true;
            else return false;
        }

        /**
         *  Redirects user to log in window
         **/
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
