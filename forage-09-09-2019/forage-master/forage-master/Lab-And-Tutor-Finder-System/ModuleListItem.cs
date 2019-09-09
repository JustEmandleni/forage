using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_And_Tutor_Finder_System
{
    /// <summary>
    /// Programmer: Emandleni Moyo
    /// Date: 2019/07/17
    /// Description: This class creates a module list element control.
    ///
    public partial class ModuleListItem : UserControl
    {
        private string _moduleCode;

        public ModuleListItem()
        {
            InitializeComponent();
        }

        [Category("Custom Property")]
        public string ModuleCode
        {
            get { return _moduleCode; }
            set { _moduleCode = value; moduleCodeLabel.Text = value; }
        }

        private void ModuleListItem_Load(object sender, EventArgs e)
        {

        }
    }
}
