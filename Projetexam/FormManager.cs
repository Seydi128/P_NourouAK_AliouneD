using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetexam
{
    internal class FormManager
    {
        public static Form1 loginForm { get; set; }
        public static DashboardGestionnaire DashboardGestionnaire { get; set; }
        public static DashboardAdmin DashboardAdmin { get; set; }
        public static DashboardProf DashboardProfesseur { get; set; }
        public static void ShowLoginForm()
        {
            if (loginForm == null || loginForm.IsDisposed)
            {
                loginForm = new Form1();
            }
            DashboardAdmin?.Hide();
            DashboardGestionnaire?.Hide();
            DashboardProfesseur?.Hide();

            loginForm.Show();
        }
        public static void ShowDashboardAdmin()
        {
            if (DashboardAdmin == null || DashboardAdmin.IsDisposed)
            {
                DashboardAdmin = new DashboardAdmin();
            }
            loginForm?.Hide();
            DashboardAdmin.Show();
        }

        public static void ShowDashboardGestionnaire()
        {
            if (DashboardGestionnaire == null || DashboardGestionnaire.IsDisposed)
            {
                DashboardGestionnaire = new DashboardGestionnaire();
            }
            loginForm?.Hide();
            DashboardGestionnaire.Show();
        }
        public static void ShowDashboardProfesseur(int userId)
        {
            if (DashboardProfesseur == null || DashboardProfesseur.IsDisposed)
            {
                DashboardProfesseur = new DashboardProf(userId);
            }
            loginForm?.Hide();
            DashboardProfesseur.Show();
        }

    }
}
