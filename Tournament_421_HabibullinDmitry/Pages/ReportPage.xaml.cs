using EasyMCK;
using Microsoft.Office.Interop.Word;
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
using System.Xml.Linq;
using Tournament_421_HabibullinDmitry.TournamentBase;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace Tournament_421_HabibullinDmitry.Pages
{
    /// <summary>
    /// Логика взаимодействия для ReportPage.xaml
    /// </summary>
    public partial class ReportPage : System.Windows.Controls.Page
    {
        public ReportPage()
        {
            InitializeComponent();
        }

        private void EndToBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int index = App.ggDb.TournamentReport.Count() + 1;
                string newPath = "C:\\Users\\User\\Desktop\\EndTournaments-" + index + ".docx";
                string newPath2 = "C:\\Users\\User\\Desktop\\EndTournaments-" + index + ".pdf";

                using (var document = DocX.Create(newPath))
                {
                    var heading = document.InsertParagraph("ПРОШЕДШИЕ ТУРНИРЫ");
                    heading.FontSize(30);
                    heading.Bold();
                    heading.Alignment = Alignment.center;
                    heading.SpacingAfter(10);

                    foreach (Tournament tournament in App.ggDb.Tournament)
                    {
                        if (tournament.EndTournament.HasValue && tournament.EndTournament < DateTime.Now)
                        {
                            Player player = App.ggDb.Player.FirstOrDefault(x => x.Id_Player == tournament.Winner);
                            string tournamentInfo = $"{tournament.Name_Tournament} --- {tournament.TournamentType.Name_Tournament} --- игроков:{tournament.PlayerCount} --- {(player != null ? player.NickName : "Победитель не найден")} --- {tournament.MoneyPrize}.р";

                            var paragraph = document.InsertParagraph(tournamentInfo);
                            string space = "-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+";
                            var paragraph2 = document.InsertParagraph(space);
                            paragraph.FontSize(12);
                            paragraph.SpacingAfter(10);
                        }
                    }
                    document.Save();
                    Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                    Microsoft.Office.Interop.Word.Document wordDoc = null;
                    wordDoc = wordApp.Documents.Open(newPath);
                    wordDoc.SaveAs2(newPath2, WdSaveFormat.wdFormatPDF);

                    TournamentReport tournamentReport = new TournamentReport()
                    {
                        Id_TReport = App.ggDb.TournamentReport.Count() + 1,
                    };
                    App.ggDb.TournamentReport.Add(tournamentReport);
                    App.ggDb.SaveChanges();
                }

                MessageBox.Show("Отчёт сформирован");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при формировании отчёта: {ex.Message}");
            }
        }

        private void FutureToBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int index = App.ggDb.TournamentReport.Count() + 1;
                string newPath = "C:\\Users\\User\\Desktop\\FutureTournaments-" + index + ".docx";
                string newPath2 = "C:\\Users\\User\\Desktop\\FutureTournaments-" + index + ".pdf";

                using (var document = DocX.Create(newPath))
                {
                    var heading = document.InsertParagraph("ПРЕДСТОЯЩИЕ ТУРНИРЫ");
                    heading.FontSize(30);
                    heading.Bold();
                    heading.Alignment = Alignment.center;
                    heading.SpacingAfter(10);

                    foreach (Tournament tournament in App.ggDb.Tournament)
                    {
                        if (tournament.EndTournament.HasValue && tournament.StartTournament > DateTime.Now)
                        {
                            Player player = App.ggDb.Player.FirstOrDefault(x => x.Id_Player == tournament.Winner);
                            string tournamentInfo = $"{tournament.Name_Tournament} --- {tournament.TournamentType.Name_Tournament} --- игроков:{tournament.PlayerCount} --- {(player != null ? player.NickName : "Победителя пока нет")} --- {tournament.MoneyPrize}.р";

                            var paragraph = document.InsertParagraph(tournamentInfo);
                            string space = "-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+";
                            var paragraph2 = document.InsertParagraph(space);

                            paragraph.FontSize(12);
                            paragraph.SpacingAfter(10);
                        }
                    }
                    document.Save();
                    Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                    Microsoft.Office.Interop.Word.Document wordDoc = null;
                    wordDoc = wordApp.Documents.Open(newPath);
                    wordDoc.SaveAs2(newPath2, WdSaveFormat.wdFormatPDF);

                    TournamentReport tournamentReport = new TournamentReport()
                    {
                        Id_TReport = App.ggDb.TournamentReport.Count() + 1,
                    };
                    App.ggDb.TournamentReport.Add(tournamentReport);
                    App.ggDb.SaveChanges();
                }

                MessageBox.Show("Отчёт сформирован");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при формировании отчёта: {ex.Message}");
            }
        }
    }
}
