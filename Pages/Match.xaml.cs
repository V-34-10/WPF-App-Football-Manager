using Football_Manager_2023.Model;
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

namespace Football_Manager_2023.Pages
{
    /// <summary>
    /// Логика взаимодействия для Match.xaml
    /// </summary>
    public partial class Match : Page
    {
        static string image_path = "file:///D:/Teaching_materials/LMV_DNU/Football_Manager_2023/";
        Matchs[] Matchs = new Matchs[]
        {
            new Matchs(1,"ФК Динамо", "ФК Шахтар", "02.10.2021", "4-3-3", 2, 2, "0:2", "21/22", image_path + "image/match/Dinamo-Shahtar.png"),
            new Matchs(2,"ФК Шахтар", "ФК Верес", "24.09.2021", "4-1-2-1-2", 6, 3, "6:0", "21/22", image_path + "image/match/Shahtar-Veres.png"),
            new Matchs(3,"ФК Верес", "ФК Десна", "05.12.2021", "4-3-2-1", 2, 1, "1:1", "21/22", image_path + "image/match/Veres-Desna.png"),
            new Matchs(4,"ФК Десна", "ФК Динамо", "21.11.2021", "4-4-2", 4, 3, "0:4", "21/22", image_path + "image/match/Desna-Dinamo.png"),
            new Matchs(5,"ФК Шахтар", "ФК Десна", "29.10.2021", "4-3-3", 4, 2, "4:0", "21/22", image_path + "image/match/Shahtar-Desna.png"),
            new Matchs(6,"ФК Динамо", "ФК Десна", "21.08.2021", "4-3-3", 4, 4, "4:0", "21/22", image_path + "image/match/Dinamo-Desna.png"),
            new Matchs(7,"ФК Десна", "ФК Верес", "29.08.2021", "4-1-2-1-2", 4, 1, "0:4", "21/22", image_path + "image/match/Desna-Veres.png"),
            new Matchs(8,"ФК Шахтар", "ФК Десна", "30.10.2021", "4-3-2-1", 5, 4, "4:1", "21/22", image_path + "image/match/Shahtar-Desna.png"),
            new Matchs(9,"ФК Шахтар", "ФК Динамо", "21.09.2021", "4-3-2-1", 3, 1, "3:0", "21/22", image_path + "image/match/Shahtar-Dinamo.png"),
            new Matchs(10,"ФК Десна", "ФК Динамо", "20.03.2023", "4-4-2", 2, 1, "1:1", "23/24", image_path + "image/match/Desna-Dinamo.png"),
            new Matchs(11,"ФК Верес", "ФК Десна", "14.02.2023", "4-3-3", 6, 4, "4:2", "23/24", image_path + "image/match/Veres-Desna.png"),
            new Matchs(12,"ФК Шахтар", "ФК Динамо", "03.03.2023", "4-4-2", 6, 5, "3:3", "23/24", image_path + "image/match/Shahtar-Dinamo.png"),
            new Matchs(13,"ФК Карпати", "ФК Десна", "08.03.2023", "4-1-2-1-2", 5, 3, "3:2", "23/24", image_path + "image/match/Karpaty-Desna.png"),
            new Matchs(14,"ФК Карпати", "ФК Верес", "15.03.2023", "4-1-2-1-2", 4, 3, "2:2", "23/24", image_path + "image/match/Karpaty-Veres.png"),
            new Matchs(15,"ФК Карпати", "ФК Шахтар", "30.10.2021", "4-3-2-1", 8, 6, "4:4", "23/24", image_path + "image/match/Karpaty-Shahtar.png")
        };
        public Match()
        {
            InitializeComponent();
            list_match.ItemsSource = Matchs;
        }

        private void Button_Click_Save_Result(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Результати матчів збережено в файл!", "Football Manager", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click_Add_Match(object sender, RoutedEventArgs e)
        {
            Match_Add add = new Match_Add();
            add.ShowDialog();
        }

        private void Button_Click_Diagram_Match(object sender, RoutedEventArgs e)
        {
            Match_Diagram diagram = new Match_Diagram();
            diagram.ShowDialog();
        }

        private void list_match_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int selectedItem = 1;
            var item = ((FrameworkElement)e.OriginalSource).DataContext as Matchs;
            for (int i = 0; i < Matchs.Length; i++)
            {
                if (item == null) { break; }
                if (item.IdMatch == selectedItem)
                {
                    image_match.Source = new BitmapImage(new Uri(item.ImageMatch));
                }
                selectedItem++;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Player.OpenHelpFile("Football_Manager_2023.chm", "vikno_match.htm");
        }

        private void TeamComboBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Player.OpenHelpFile("Football_Manager_2023.chm", "glosarij.htm");
        }
    }
}
