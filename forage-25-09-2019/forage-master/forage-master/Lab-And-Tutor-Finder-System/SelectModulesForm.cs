using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Lab_And_Tutor_Finder_System
{
    /// <summary>
    /// Project: Forage
    /// Programmer: Emandleni Moyo s216673380@mandela.ac.za
    /// Programmer: Lavhelesani MAmphwe s217055443@mandela.ac.za
    /// Date: 2019/09/19
    /// Date: 2019/09/25
    /// Description: Creates a dynamic list of modules and records a tutors appointment to facilitate tutorials for the chosen modules
    /// </summary>
    /// 
    public partial class SelectModulesForm : Form
    {
        SqlConnection CONNECTION;
         string CONNECTION_STRING  = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\TEAM_12_ULTRON_3_FORAGE_DATABASE.mdf;Integrated Security=True;Connect Timeout=30";
        public SelectModulesForm()
        {
            InitializeComponent();
           CONNECTION = new SqlConnection(CONNECTION_STRING);

        }

        private void SelectModulesForm_Load(object sender, EventArgs e)
        {
            if (CONNECTION.State == ConnectionState.Closed)
                CONNECTION.Open();

            string SQL_QUERY_1 = "SELECT moduleDescr FROM MODULE WHERE moduleLevel = 1;";
            string SQL_QUERY_2 = "SELECT moduleDescr FROM MODULE WHERE moduleLevel = 2;";
            string SQL_QUERY_3 = "SELECT moduleDescr FROM MODULE WHERE moduleLevel = 3;";

            DataTable DATA_TABLE_1 = new DataTable();
            SqlDataAdapter DATA_ADAPTER;
            DATA_ADAPTER = new SqlDataAdapter(SQL_QUERY_1, CONNECTION);
            DATA_ADAPTER.Fill(DATA_TABLE_1);

            foreach (DataRow row in DATA_TABLE_1.Rows)
            {
                string variable = row["moduleDescr"].ToString();
                checkedListBox1.Items.Add(variable);
            }
            
            
            DataTable DATA_TABLE_2 = new DataTable();
            DATA_ADAPTER = new SqlDataAdapter(SQL_QUERY_2, CONNECTION);
            DATA_ADAPTER.Fill(DATA_TABLE_2);

            foreach (DataRow row in DATA_TABLE_2.Rows)
            {
                string variable = row["moduleDescr"].ToString();
                checkedListBox2.Items.Add(variable);
            }

            DataTable DATA_TABLE_3 = new DataTable();
            DATA_ADAPTER = new SqlDataAdapter(SQL_QUERY_3, CONNECTION);
            DATA_ADAPTER.Fill(DATA_TABLE_3);

            foreach (DataRow row in DATA_TABLE_3.Rows)
            {
                string variable = row["moduleDescr"].ToString();
                checkedListBox3.Items.Add(variable);
            }

            CONNECTION.Close();
        }

        private void TutorSelfAppoint(CheckedListBox [] CHECK_LIST_BOX)
        {
            //CheckedListBox[] list = new CheckedListBox[3];
            //for (int i = 0; i < list.Length; i++)
            //{
            //    CheckedListBox box = list[i];
            //    for (int j = 0; j < box.Width; j++)
            //    {
            //        if(box[i].ch)
            //    }
            //}

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //TutorSelfAppoint(checkedListBox1);
            //TutorSelfAppoint(checkedListBox2);
            //TutorSelfAppoint(checkedListBox3);
            Hide();
            TutorDashboardForm TUTOR_DASHBOARD_FORM = new TutorDashboardForm();
            TUTOR_DASHBOARD_FORM.Show();
        }
    }
}
