using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Tournament_421_HabibullinDmitry.TournamentBase;

namespace Tournament_421_HabibullinDmitry
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Frame mainFrame;
        public static User loggedUser;
        public static TournamentDB_421_HabibuLLinEntities ggDb = new TournamentDB_421_HabibuLLinEntities();
    }
}
