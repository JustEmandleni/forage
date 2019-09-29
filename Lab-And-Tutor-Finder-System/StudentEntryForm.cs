using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_And_Tutor_Finder_System
{
    public partial class StudentEntryForm : Form
    {
        public StudentEntryForm()
        {
            InitializeComponent();
        }

        private void findMachineButton_Click(object sender, EventArgs e)
        {
            Hide();
            new DisplayMachinesForm().Show();
        }

        private void StudentDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
