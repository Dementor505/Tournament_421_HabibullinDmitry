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
    /// Логика взаимодействия для AddEditTournament.xaml
    /// </summary>
    public partial class AddEditTournament : Page
    {
        public AddEditTournament()
        {
            InitializeComponent();
            GameTb.ItemsSource = App.ggDb.TournamentGame.Select(x=>x.Name_TGame).ToList();
            TypeTb.ItemsSource = App.ggDb.TournamentType.Select(x=>x.Name_Tournament).ToList();
            StatusTb.ItemsSource = App.ggDb.TournamentStatys.Select(x=>x.Name_TStatys).ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            TournamentLimits tournamentLimits = new TournamentLimits()
            {
                Id_TLimits = App.ggDb.Tournament.Count() + 1,
            };
            App.ggDb.TournamentLimits.Add(tournamentLimits);
            App.ggDb.SaveChanges();
            Tournament newTournament = new Tournament()
            {
                Id_Tournament = App.ggDb.Tournament.Count() + 1,
                Name_Tournament = NameTb.Text,
                Id_TournamentType = TypeTb.SelectedIndex+1,
                StartTournament = Convert.ToDateTime(StartTb.Text),
                EndTournament = Convert.ToDateTime(EndTb.Text),
                Winner = null,
                MoneyPrize = Convert.ToDecimal(MoneyTb.Text),
                PlayerCount = Convert.ToInt32(PlayersTb.Text),
                TGame_Id = GameTb.SelectedIndex + 1,
                Id_TStatus = StatusTb.SelectedIndex + 1,
            };
            App.ggDb.Tournament.Add(newTournament);
            App.ggDb.SaveChanges();
            MessageBox.Show("Добавлено");
        }
    }
}
