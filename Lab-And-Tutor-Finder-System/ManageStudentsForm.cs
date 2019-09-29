using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab_And_Tutor_Finder_System
{
    /// <summary>
    /// Programmer: Emandleni Moyo
    /// Date: 2019/07/11
    /// Date: 2019/09/08
    /// Date: 2019/09/25
    /// Description: This class defines the behavior of the form that manages tutor information. Administrators have the ability to maintain tutor information. Administrators have the authority to create, view, alter and/or delete tutor information.
    /// </summary>
    public partial class ManageStudentsForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\TEAM_12_ULTRON_3_FORAGE_DATABASE.mdf;Integrated Security=True;Connect Timeout=30");

        private void populateDataGridView()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            string selectQuery = "SELECT * FROM Student";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
            dataAdapter.SelectCommand.CommandType = CommandType.Text;
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns[0].Visible = false;

            connection.Close();
        }

        public ManageStudentsForm()
        {
            InitializeComponent();
        }

        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void reload()
        {
            reset();
            populateDataGridView();
            deleteButton.Enabled = false;
        }

        private void reset()
        {
            userNameTextBox.Focus();
            saveButton.Text = "Save";
            deleteButton.Enabled = false;
            userNameTextBox.Text =
            passwordTextBox.Text =
            firstNameTextBox.Text =
            lastNameTextBox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                if (saveButton.Text.Equals("Save"))
                {
                    SqlCommand command = new SqlCommand(@"INSERT INTO Student VALUES ('" + userNameTextBox.Text + "', '" + passwordTextBox.Text + "', '" + firstNameTextBox.Text + "', '" + lastNameTextBox.Text + "')", connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Success");
                }
                else
                {
                    SqlCommand command = new SqlCommand(@"UPDATE Student SET studentUsername='" + userNameTextBox.Text + "', studentPassword='" + passwordTextBox.Text + "', studentFName='" + firstNameTextBox.Text + "', studentLName='" + lastNameTextBox.Text, connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Updated");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error Message");
            }
            finally
            {
                connection.Close();
            }

            reload();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                saveButton.Text = "Update";
                deleteButton.Enabled = true;
                userNameTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                passwordTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                firstNameTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                lastNameTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                SqlCommand command = new SqlCommand(@"DELETE Student WHERE studentUsername='" + userNameTextBox.Text + "'", connection);
                command.ExecuteNonQuery();

                MessageBox.Show("Deleted");

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error Message");
            }
            finally
            {
                connection.Close();
            }

            reload();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            reload();
        }

        /**
         *  Event triggered by clicking the Search button
         *  Filters data grid view to display search result set
         **/
        private void searchButton_Click(object sender, EventArgs e)
        {
            #region TODO:
            //try
            //{
            //    
            //    
            //    
            //    
            //    
            //    
            //    
            //    
            //                                                                             
            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show(exception.Message, "Error Message");
            //}
            //finally
            //{
            //    connection.Close();
            //} 
            #endregion
        }
    }
}
