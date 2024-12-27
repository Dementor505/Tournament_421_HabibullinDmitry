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


            foreach (Tournament tournament in App.ggDb.Tournament)
            {
                TControls.Children.Add(new TournamentControl(tournament));
            }
        }
        public void Refresh()
        {

        }
    }
}
