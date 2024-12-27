using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();
            UserNameTb.Text += ", " + App.loggedUser.Login;
            Id.Text = App.loggedUser.Id_User.ToString();
            Login.Text = App.loggedUser.Login;
            Contacts.Text = App.loggedUser.Player.Phone_Player.ToString();
            MatchPlayer matchPlayer = App.ggDb.MatchPlayer.FirstOrDefault(x => x.Id_Player == App.loggedUser.Id_User);
            Matches.Text = App.ggDb.MatchPlayer.Where(x=>x.Id_Player == matchPlayer.Id_Player).Count().ToString();
            Wins.Text = App.ggDb.Tournament.Where(x => x.Winner == matchPlayer.Id_Player).Count().ToString();
            Falls.Text = App.ggDb.Tournament.Where(x => x.Winner != matchPlayer.Id_Player).Count().ToString();
            
        }

        private void achiveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void titulBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
