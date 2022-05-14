
using Library.Presentation.UserViews;

namespace Library.Presentation.Helpers
{
    public class FormManager
    {
        public static void OpenLoginForm()
        {
            var login = new Login();
            login.Show();
        }
        public static void OpenRegistrationForm()
        {
            var registration = new Registration();
            registration.Show();
        }
        public static void OpenChangePassForm()
        {
            var showPass = new ChangePassword();
            showPass.Show();
        }
        public static void OpenAdminHomeForm()
        {
            var adminHomeForm = new AdminHome();
            adminHomeForm.Show();
        }
        public static void OpenUserHomeForm()
        {
            var userHomeForm = new UserHome();
            userHomeForm.Show();
        }
        public static void OpenReservationDateForm()
        {
            var reservationDateForm = new ReservationDate();
            reservationDateForm.Show();
        }
    }
}
