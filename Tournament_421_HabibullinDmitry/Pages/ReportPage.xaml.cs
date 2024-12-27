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
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace Tournament_421_HabibullinDmitry.Pages
{
    /// <summary>
    /// Логика взаимодействия для ReportPage.xaml
    /// </summary>
    public partial class ReportPage : Page
    {
        public ReportPage()
        {
            InitializeComponent();
        }

        private void EndToBtn_Click(object sender, RoutedEventArgs e)
        {
            int index = App.ggDb.TournamentReport.Count() + 1;
            string newPath = "C:\\Users\\User\\Desktop\\EndTournaments-" + index + ".docx";
            using (DocX document = DocX.Create(newPath))
            {
                var heading = document.InsertParagraph("Заголовок документа");
                heading.FontSize(18); // Размер шрифта
                heading.Bold(); // Жирный шрифт
                heading.Alignment = Alignment.center; // Выравнивание по центру
                heading.SpacingAfter(10); // Отступ после заголовка

                // Добавляем строку текста
                var paragraph = document.InsertParagraph("Это пример строки текста в документе.");
                paragraph.FontSize(12); // Размер шрифта
                paragraph.SpacingAfter(10); // Отступ после строки

                // Сохраняем документ
                document.Save();
            }
            foreach ()
            {

            }
        }

        private void FutureToBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
