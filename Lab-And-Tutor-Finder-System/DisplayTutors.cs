using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Lab_And_Tutor_Finder_System
{
    /// <summary>
    /// Project: Forage
    /// Programmer: Emandleni Moyo s216673380@mandela.ac.za
    /// Date: 2019/09/29
    /// Description: Displays a dynamic list of modules and also displays tutors appointed to facilitate tutorials for the specified module
    /// </summary>
    /// 

    public partial class DisplayTutors : Form
    {
        string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\TEAM_12_ULTRON_3_FORAGE_DATABASE.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection CONNECTION;


        public DisplayTutors()
        {
            InitializeComponent();
            CONNECTION = new SqlConnection(CONNECTION_STRING);
            populateModules();
            populateAppointments();
        }

        private void populateModules()
        {
            if (CONNECTION.State == ConnectionState.Closed)
                CONNECTION.Open();

            string SQL_QUERY = "SELECT * FROM MODULE;";
            DataTable DATA_TABLE = new DataTable();
            SqlDataAdapter DATA_ADAPTER;
            DATA_ADAPTER = new SqlDataAdapter(SQL_QUERY, CONNECTION);
            DATA_ADAPTER.Fill(DATA_TABLE);

            foreach (DataRow row in DATA_TABLE.Rows)
            {
                comboBox1.Items.Add(row["moduleCode"].ToString());
            }

            CONNECTION.Close();
        }

        private void populateAppointments()
        {
            if (CONNECTION.State == ConnectionState.Closed)
                CONNECTION.Open();

            string SQL_QUERY = "SELECT * FROM APPOINTMENT";
            SqlDataAdapter DATA_ADAPTER = new SqlDataAdapter(SQL_QUERY, CONNECTION);
            DATA_ADAPTER.SelectCommand.CommandType = CommandType.Text;
            DataTable DATA_TABLE = new DataTable();
            DATA_ADAPTER.Fill(DATA_TABLE);

            dataGridView1.DataSource = DATA_TABLE;
            //dataGridView1.Columns[0].Visible = false;

            CONNECTION.Close();
        }

        private void DisplayTutors_Load(object sender, System.EventArgs e)
        {

        }
    }
}
