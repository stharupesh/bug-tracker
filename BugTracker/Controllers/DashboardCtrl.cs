using System.Windows.Forms;
using BugTracker.Services;
using BugTracker.Views;

namespace BugTracker.Controllers
{
    class DashboardCtrl
    {
        public void logoutUser() // logout currently logged in user
        {
            Auth.logout();

            Form.ActiveForm.Hide(); // hide the dashboard

            foreach (Form f in Application.OpenForms)
            {
                f.Hide();
            }

            new HomeView().Show(); // show the home page
        }
    }
}
