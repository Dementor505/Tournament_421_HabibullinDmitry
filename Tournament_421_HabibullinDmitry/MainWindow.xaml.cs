﻿using System;
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
using Tournament_421_HabibullinDmitry.Pages;

namespace Tournament_421_HabibullinDmitry
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            App.mainFrame = mainFrame;
            mainFrame.Navigate(new StartPage());
        }

        private void ReportBtn_Click(object sender, RoutedEventArgs e)
        {
            App.mainFrame.Navigate(new ReportPage());
        }

        private void TournamentsBtn_Click(object sender, RoutedEventArgs e)
        {
            App.mainFrame.Navigate(new TournamentsList());
        }

        private void AddTournamentsBtn_Click(object sender, RoutedEventArgs e)
        {
            App.mainFrame.Navigate(new AddEditTournament());
        }
    }
}
