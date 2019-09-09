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
    /// Description: This class defines the behavior of the form that manages tutor information. Administrators have the ability to maintain tutor information. Administrators have the authority to create, view, alter and/or delete tutor information.
    /// </summary>
    public partial class ManageTutorsForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\WRR301.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public ManageTutorsForm()
        {
            InitializeComponent();
        }

        private void ManageTutorsForm_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void populateDataGridView()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            string selectQuery = "SELECT * FROM Tutor";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
            dataAdapter.SelectCommand.CommandType = CommandType.Text;
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns[0].Visible = false; //Hide primary key column
        }
        
        private void saveButton_Click(object sender, EventArgs e)
        { 
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                if (saveButton.Text.Equals("Save"))
                {
                    SqlCommand command = new SqlCommand(@"INSERT INTO Tutor VALUES ('" + userNameTextBox.Text + "', '" + passwordTextBox.Text + "', '" + firstNameTextBox.Text + "', '" + lastNameTextBox.Text + "', '" + qualificationComboBox.SelectedIndex + "', " + rateTextBox.Text + ", " + yearNumericUpDown.Value + ", '" + bioTextBox.Text + "')", connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Success");
                }
                else
                {
                    SqlCommand command = new SqlCommand(@"UPDATE Tutor SET tutorUsername='" + userNameTextBox.Text + "', tutorPassword='" + passwordTextBox.Text + "', tutorFName='" + firstNameTextBox.Text + "', tutorLName='" + lastNameTextBox.Text + "', tutorQualiCode='" + qualificationComboBox.SelectedIndex + "', tutorChargingRate=" + rateTextBox.Text + ", tutorYearOfStudy=" + yearNumericUpDown.Value + ", tutorBioDescr='" + bioTextBox.Text + "'", connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Updated");
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error Message");
            }
            finally
            {
                connection.Close();
            }

            reload();
        }

        private void reload()
        {
            reset();
            populateDataGridView();
            deleteButton.Enabled = false;
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
            //    if (connection.State == ConnectionState.Closed)
            //        connection.Open();
            //    string selectQuery = "SELECT * FROM Tutor WHERE tutorFName LIKE '" + firstNameTextBox.Text + "%'";
            //    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
            //    dataAdapter.SelectCommand.CommandType = CommandType.Text;
            //    DataTable dataTable = new DataTable();
            //    dataAdapter.Fill(dataTable);

            //    dataGridView1.DataSource = dataTable;
            //    deleteButton.Enabled = true;
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {            
            //dataGridView1.CurrentRow.Index != -1
            if (dataGridView1.RowCount > 0)
            {
                saveButton.Text = "Update";
                deleteButton.Enabled = true;
                userNameTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                passwordTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                firstNameTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                lastNameTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                #region TODO:

                //RESET TAB INDEX WHEN FORM LOADS
                //GET THE CORRECT TAB INDEX WHEN DOUBLE CLICKED ON A RECORD
                qualificationComboBox.TabIndex = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()); 

                #endregion

                rateTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                yearNumericUpDown.Value = int.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                bioTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            saveButton.Text = "Save";
            deleteButton.Enabled = false;
            userNameTextBox.Text =
            passwordTextBox.Text =
            firstNameTextBox.Text =
            lastNameTextBox.Text =
            rateTextBox.Text =
            bioTextBox.Text = "";
            yearNumericUpDown.Value = 1;
            userNameTextBox.Focus();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                SqlCommand command = new SqlCommand(@"DELETE Tutor WHERE tutorUsername='" + userNameTextBox.Text + "'", connection);
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
    }
}
