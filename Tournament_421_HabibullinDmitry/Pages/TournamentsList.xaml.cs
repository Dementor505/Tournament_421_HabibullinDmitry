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
using Tournament_421_HabibullinDmitry.ControlsWrap;

namespace Tournament_421_HabibullinDmitry.Pages
{
    /// <summary>
    /// Логика взаимодействия для TournamentsList.xaml
    /// </summary>
    public partial class TournamentsList : Page
    {
        public TournamentsList()
        {
            InitializeComponent();


            Refresh();
            filtrCb.SelectedIndex = 2;
        }
        public void Refresh()
        {
            TControls.Children.Clear();
            List<Tournament> tournaments = App.ggDb.Tournament.ToList();

            if (filtrCb.SelectedIndex == 1) tournaments = tournaments.Where(x => x.StartTournament > DateTime.Now).ToList();
            if (filtrCb.SelectedIndex == 0) tournaments = tournaments.Where(x => x.StartTournament < DateTime.Now).ToList();
            if (filtrCb.SelectedIndex == 2) tournaments = tournaments;
            foreach (Tournament tournament in tournaments)
            {
                TControls.Children.Add(new TournamentControl(tournament));
            }
        }

        private void filtrCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }
    }
}
