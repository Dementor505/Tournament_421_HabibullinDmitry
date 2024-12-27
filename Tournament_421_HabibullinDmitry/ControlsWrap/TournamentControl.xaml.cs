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

namespace Tournament_421_HabibullinDmitry.ControlsWrap
{
    /// <summary>
    /// Логика взаимодействия для TournamentControl.xaml
    /// </summary>
    public partial class TournamentControl : UserControl
    {
        public TournamentControl(Tournament tournament)
        {
            InitializeComponent();
            NameT.Text = tournament.Name_Tournament;
            MoneyT.Text = tournament.MoneyPrize.ToString();
            PlayersT.Text = tournament.PlayerCount.ToString();
            StartT.Text = tournament.StartTournament.ToString();
            EndT.Text = tournament.EndTournament.ToString();
        }
    }
}
