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
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.DarkBlue;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.DarkOrange;
        }
    }
}
