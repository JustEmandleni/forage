using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace Lab_And_Tutor_Finder_System
{
    /// <summary>
    /// Project: Forage
    /// Programmer: Emandleni Moyo s216673380@mandela.ac.za
    /// Date: 2019/09/25
    /// Date: 2019/09/28
    /// Description: This class defines the behavior of the display machines form. 
    /// </summary>
    /// 

    [System.Runtime.InteropServices.Guid("5083B185-8A1E-4059-AD4D-1CF60A244506")]
    public partial class DisplayMachinesForm : Form
    {
        string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\TEAM_12_ULTRON_3_FORAGE_DATABASE.mdf;Integrated Security=True;Connect Timeout=30";

        SqlConnection CONNECTION;
        ArrayList MACHINE_REGISTER;
        List<Button> BUTTONS;

        public DisplayMachinesForm()
        {
            InitializeComponent();
            ConfigureButtons();
            CONNECTION = new SqlConnection(CONNECTION_STRING);
        }

        private void MachinesForm_Load(object sender, EventArgs e)
        {
            if (CONNECTION.State == ConnectionState.Closed)
                CONNECTION.Open();

            string SELECT_SQL_QUERY = "SELECT * FROM MACHINE;";

            DataTable DATA_TABLE_1 = new DataTable();
            SqlDataAdapter DATA_ADAPTER;
            DATA_ADAPTER = new SqlDataAdapter(SELECT_SQL_QUERY, CONNECTION);
            DATA_ADAPTER.Fill(DATA_TABLE_1);

            MACHINE_REGISTER = new ArrayList();

            foreach (DataRow row in DATA_TABLE_1.Rows)
            {
                int computerNo = int.Parse(row["computerNo"].ToString());
                int labNo = int.Parse(row["labNo"].ToString());
                string computerDescr = row["computerDescr"].ToString();
                int computerStatus = int.Parse(row["computerStatus"].ToString());

                Machine CURRENT_MACHINE = new Machine(computerNo, labNo, computerDescr, computerStatus);
                MACHINE_REGISTER.Add(CURRENT_MACHINE);              
            }

            CONNECTION.Close();

            StatusStream();
        }

        private void StatusStream()
        {
            for (int x = 0; x < MACHINE_REGISTER.Count; x++)
            {
                Machine CURRENT_MACHINE = (Machine)MACHINE_REGISTER[x];
                switch (CURRENT_MACHINE.getComputerStatus())
                {
                    case -1:
                        BUTTONS[x].BackColor = Color.Red;
                        break;
                    case 0:
                        BUTTONS[x].BackColor = Color.Lime;
                        break;
                    case 1:
                        BUTTONS[x].BackColor = Color.Yellow;
                        break;
                }
            }        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ConfigureButtons()
        {
            BUTTONS = new List<Button>();

            BUTTONS.Add(L1M1);
            BUTTONS.Add(L1M2);
            BUTTONS.Add(L1M3);
            BUTTONS.Add(L1M4);
            BUTTONS.Add(L1M5);
            BUTTONS.Add(L1M6);
            BUTTONS.Add(L1M7);
            BUTTONS.Add(L1M8);
            BUTTONS.Add(L1M9);
            BUTTONS.Add(L1M10);
            BUTTONS.Add(L1M11);
            BUTTONS.Add(L1M12);
            BUTTONS.Add(L1M13);
            BUTTONS.Add(L1M14);
            BUTTONS.Add(L1M15);
            BUTTONS.Add(L1M16);
            BUTTONS.Add(L1M17);
            BUTTONS.Add(L1M18);
            BUTTONS.Add(L1M19);
            BUTTONS.Add(L1M20);
            BUTTONS.Add(L1M21);
            BUTTONS.Add(L1M22);
            BUTTONS.Add(L1M23);
            BUTTONS.Add(L1M24);
            BUTTONS.Add(L1M25);
            BUTTONS.Add(L1M26);
            BUTTONS.Add(L1M27);
            BUTTONS.Add(L1M28);
            BUTTONS.Add(L1M29);
            BUTTONS.Add(L1M30);
            BUTTONS.Add(L1M31);
            BUTTONS.Add(L1M32);
            BUTTONS.Add(L1M33);
            BUTTONS.Add(L1M34);
            BUTTONS.Add(L1M35);
            BUTTONS.Add(L1M36);
            BUTTONS.Add(L1M37);
            BUTTONS.Add(L1M38);
            BUTTONS.Add(L1M39);
            BUTTONS.Add(L1M40);
            BUTTONS.Add(L1M41);
            BUTTONS.Add(L1M42);
            BUTTONS.Add(L1M43);
            BUTTONS.Add(L1M44);
            BUTTONS.Add(L1M45);
            BUTTONS.Add(L1M46);
        }
    }
}
