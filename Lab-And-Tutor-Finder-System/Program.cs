using System;
using System.Windows.Forms;

namespace Lab_And_Tutor_Finder_System
{
    /// <summary>
    /// Programmer: Emandleni Moyo
    /// Date: 2019/07/11
    /// Description: This program is used to locate vacant machines in computer labs and pair students with tutors.
    /// </summary>
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Launch();            
        }
        private static void Launch()
        {
            //Application.Run(new TutorRegistrationForm());
            //Application.Run(new LoginForm());
            //Application.Run(new StudentRegistrationForm());
            //Application.Run(new StudentDashboardForm());
            //Application.Run(new AdminDashboardForm());
            //Application.Run(new DisplayMachinesForm());
            //Application.Run(new TutorListForm());
            Application.Run(new DisplayTutorProfileForm());
            //Application.Run(new ManageTutorsForm());
            //Application.Run(new ManageStudentsForm());
            //Application.Run(new SelectModulesForm("TEST"));
            //Application.Run(new DisplayTutors());
        }
    }
}
