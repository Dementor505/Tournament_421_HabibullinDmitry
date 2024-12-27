using System;
using System.Collections.Generic;
using EasyMCK;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tournament_421_HabibullinDmitry.TournamentBase;

namespace Tournament_421_HabibullinDmitry.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            App.mainFrame.Navigate(new StartPage());
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            App.loggedUser = UserManager.Authorization<User>(App.ggDb,LoginTb.Text,PasswordTb.Text,l=>l.Login,p=>p.Password);
            if (App.loggedUser != null)
            {
                App.mainFrame.Navigate(new ProfilePage());
            }
            else
            {
                MessageBox.Show("Такой пользователь не найден");
            }
        }
    }
}
