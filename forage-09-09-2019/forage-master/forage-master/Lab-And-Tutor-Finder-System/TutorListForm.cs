using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_And_Tutor_Finder_System
{
    /// <summary>
    /// Programmer: Emandleni Moyo
    /// Date: 2019/07/17
    /// Description: This class generates a form to display tutors grouped by modules.
    ///
    public partial class TutorListForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\WRR301.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public TutorListForm()
        {
            InitializeComponent();
        }

        private void TutorListForm_Load(object sender, EventArgs e)
        {
            populateTutors();
        }
        private void populateTutors()
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
    }
}
