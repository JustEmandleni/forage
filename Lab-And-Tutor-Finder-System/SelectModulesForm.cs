using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace Lab_And_Tutor_Finder_System
{
    /// <summary>
    /// Project: Forage
    /// Programmer: Emandleni Moyo s216673380@mandela.ac.za
    /// Programmer: Lavhelesani MAmphwe s217055443@mandela.ac.za
    /// Date: 2019/09/19
    /// Date: 2019/09/25
    /// Description: Displays a dynamic list of modules and creates record of tutor appointments to facilitate tutorials for the chosen modules
    /// </summary>
    /// 
    [System.Runtime.InteropServices.Guid("F6E1E954-6692-4024-B169-8C48FB14F4AB")]
    public partial class SelectModulesForm : Form
    {
        string CONNECTION_STRING  = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\TEAM_12_ULTRON_3_FORAGE_DATABASE.mdf;Integrated Security=True;Connect Timeout=30";
        static string TUTOR_IDENTIFIER;
        SqlConnection CONNECTION;
        ArrayList CHOSEN_MODULES;

        public SelectModulesForm(string tutorUsername)
        {
            InitializeComponent();
            CONNECTION = new SqlConnection(CONNECTION_STRING);
            TUTOR_IDENTIFIER = tutorUsername; 
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
                checkedListBox1.Items.Add(row["moduleDescr"].ToString());
            }
            
            
            DataTable DATA_TABLE_2 = new DataTable();
            DATA_ADAPTER = new SqlDataAdapter(SQL_QUERY_2, CONNECTION);
            DATA_ADAPTER.Fill(DATA_TABLE_2);

            foreach (DataRow row in DATA_TABLE_2.Rows)
            {
                checkedListBox2.Items.Add(row["moduleDescr"].ToString());
            }

            DataTable DATA_TABLE_3 = new DataTable();
            DATA_ADAPTER = new SqlDataAdapter(SQL_QUERY_3, CONNECTION);
            DATA_ADAPTER.Fill(DATA_TABLE_3);

            foreach (DataRow row in DATA_TABLE_3.Rows)
            {
                checkedListBox3.Items.Add(row["moduleDescr"].ToString());
            }

            CONNECTION.Close();
        }

        private void populateSelectionfrom(CheckedListBox LIST)
        {
            CHOSEN_MODULES = new ArrayList();
            foreach (string moduleDescr in LIST.CheckedItems)
                CHOSEN_MODULES.Add(moduleDescr);

            //for (int x = 0; x < LIST.Items.Count; x++)
            //{
            //    CheckBox CURRENT_BOX = (CheckBox)LIST.Items[x];
            //    if (CURRENT_BOX.Checked)
            //        CHOSEN_MODULES.Add(CURRENT_BOX.Text);
            //}

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            populateSelectionfrom(checkedListBox1);
            populateSelectionfrom(checkedListBox2);
            populateSelectionfrom(checkedListBox3);


            for (int x = 0; x < CHOSEN_MODULES.Count; x++)
            {
                SqlCommand COMMAND = new SqlCommand(@"INSERT INTO APPOINTMENT " +
                   "(tutorUsername, moduleDescr, appointmentDateTime)" +
                   "VALUES (@tutorUsername, @moduleDescr, @appointmentDateTime)", CONNECTION);

                COMMAND.Parameters.Add("@tutorUsername", SqlDbType.NVarChar);
                COMMAND.Parameters.Add("@moduleDescr", SqlDbType.NVarChar);
                COMMAND.Parameters.Add("@appointmentDateTime", SqlDbType.DateTime);

                COMMAND.Parameters["@tutorUsername"].Value = TUTOR_IDENTIFIER;
                COMMAND.Parameters["@moduleDescr"].Value = (string)CHOSEN_MODULES[x];
                COMMAND.Parameters["@appointmentDateTime"].Value = DateTime.Now;

                if (CONNECTION.State == ConnectionState.Closed)
                    CONNECTION.Open();
                COMMAND.ExecuteNonQuery();
                CONNECTION.Close();
            }

            Hide();
            TutorDashboardForm PERSONALISED = new TutorDashboardForm(TUTOR_IDENTIFIER);
            PERSONALISED.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
