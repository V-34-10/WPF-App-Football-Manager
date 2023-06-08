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
    /// Логика взаимодействия для Transfers.xaml
    /// </summary>
    public partial class Transfers : Page
    {
        static string image_path = "file:///D:/Teaching_materials/LMV_DNU/Football_Manager_2023/";
        Transfer[] Transfer = new Transfer[]
        {
            new Transfer("Микола Шапаренко", 1, 24, "01.01.2021", "01.01.2023", 25, "ФК Динамо", "          АПЗ          ", "       Мірча Луческу       ", 10, image_path + "image/transfers/Shaparenko.png"),
            new Transfer("Георгій Бущан", 2, 36, "01.01.2021", "01.01.2024", 30, "    ФК Динамо    ", "          АПЗ          ", "       Мірча Луческу       ", 1, image_path + "image/transfers/Bushchan.png"),
            new Transfer("Ромеро Марлос", 3, 48, "01.01.2021", "01.01.2025", 35, "    ФК Шахтар    ", "          АПЗ          ", "       Де Дзерби, Роберто       ", 11, image_path + "image/transfers/Marlos.png"),
            new Transfer("Артем Бесєдін", 4, 24, "01.01.2019", "01.01.2021", 25, "    ФК Динамо    ", "          АПЗ          ", "       Мірча Луческу       ", 41, image_path + "image/transfers/Besedin.png"),
            new Transfer("Олександр Тимчик", 5, 36, "01.01.2020", "01.01.2023", 18, "    ФК Динамо    ", "          АПЗ          ", "       Мірча Луческу       ", 24, image_path + "image/transfers/Timchuk.png"),
            new Transfer("Дуглас Мораєс", 6, 60, "01.01.2020", "01.01.2025", 40, "    ФК Шахтар    ", "          АПЗ          ", "       Де Дзерби, Роберто       ", 10, image_path + "image/transfers/Moraes.png"),
            new Transfer("Крістіан Бако", 7, 12, "01.01.2020", "01.01.2021", 21, "    ФК Шахтар    ", "          АПЗ          ", "       Де Дзерби, Роберто       ", 0, image_path + "image/transfers/Bako.png"),
            new Transfer("Євген Коноплянка", 8, 24, "01.01.2020", "01.01.2022", 29, "    ФК Шахтар    ", "          АПЗ          ", "       Де Дзерби, Роберто       ",70, image_path + "image/transfers/Konoplyanka.png"),
            new Transfer("Андрій П'ятов", 9, 36, "01.01.2019", "01.01.2022", 35, "    ФК Шахтар    ", "          АПЗ          ", "       Де Дзерби, Роберто       ", 30, image_path + "image/transfers/Pyatov.png"),
            new Transfer("Денис Безбородько", 10, 12, "01.01.2020", "01.01.2021", 15, "    ФК Десна    ", "          АПЗ          ", "       Мірча Луческу       ", 20, image_path + "image/transfers/Bezborodyko.png"),
            new Transfer("Де-Пена Карлос", 11, 24, "28.10.2021", "28.10.2023", 22, "    ФК Динамо    ", "          АПЗ          ", "       Мірча Луческу       ", 14, image_path + "image/transfers/DePena.png"),
            new Transfer("Роберт Гегедош", 12, 24, "28.10.2021", "28.10.2024", 36, "    ФК Верес    ", "          АПЗ          ", "       Юрій Вірт       ", 88, image_path + "image/transfers/Gegedosh.png")
        };
        Transfer[] Transfer_Dinamo = new Transfer[]
        {
            new Transfer("Микола Шапаренко", 1, 24, "01.01.2021", "01.01.2023", 25, "ФК Динамо", "          АПЗ          ", "       Мірча Луческу       ", 10, image_path + "image/transfers/Shaparenko.png"),
            new Transfer("Георгій Бущан", 2, 36, "01.01.2021", "01.01.2024", 30, "    ФК Динамо    ", "          АПЗ          ", "       Мірча Луческу       ", 1, image_path + "image/transfers/Bushchan.png"),
            new Transfer("Артем Бесєдін", 4, 24, "01.01.2019", "01.01.2021", 25, "    ФК Динамо    ", "          АПЗ          ", "       Мірча Луческу       ", 41, image_path + "image/transfers/Besedin.png"),
            new Transfer("Олександр Тимчик", 5, 36, "01.01.2020", "01.01.2023", 18, "    ФК Динамо    ", "          АПЗ          ", "       Мірча Луческу       ", 24, image_path + "image/transfers/Timchuk.png"),
            new Transfer("Де-Пена Карлос", 11, 24, "28.10.2021", "28.10.2023", 22, "    ФК Динамо    ", "          АПЗ          ", "       Мірча Луческу       ", 14, image_path + "image/transfers/DePena.png"),
        };
        Transfer[] Transfer_Shahtar = new Transfer[]
        {
            new Transfer("Ромеро Марлос", 3, 48, "01.01.2021", "01.01.2025", 35, "    ФК Шахтар    ", "          АПЗ          ", "       Де Дзерби, Роберто       ", 11, image_path + "image/transfers/Marlos.png"),
            new Transfer("Дуглас Мораєс", 6, 60, "01.01.2020", "01.01.2025", 40, "    ФК Шахтар    ", "          АПЗ          ", "       Де Дзерби, Роберто       ", 10, image_path + "image/transfers/Moraes.png"),
            new Transfer("Крістіан Бако", 7, 12, "01.01.2020", "01.01.2021", 21, "    ФК Шахтар    ", "          АПЗ          ", "       Де Дзерби, Роберто       ", 0, image_path + "image/transfers/Bako.png"),
            new Transfer("Євген Коноплянка", 8, 24, "01.01.2020", "01.01.2022", 29, "    ФК Шахтар    ", "          АПЗ          ", "       Де Дзерби, Роберто       ",70, image_path + "image/transfers/Konoplyanka.png"),
            new Transfer("Андрій П'ятов", 9, 36, "01.01.2019", "01.01.2022", 35, "    ФК Шахтар    ", "          АПЗ          ", "       Де Дзерби, Роберто       ", 30, image_path + "image/transfers/Pyatov.png"),
        };
        Transfer[] Transfer_Desna = new Transfer[]
        {
            new Transfer("Денис Безбородько", 10, 12, "01.01.2020", "01.01.2021", 15, "    ФК Десна    ", "          АПЗ          ", "       Мірча Луческу       ", 20, image_path + "image/transfers/Bezborodyko.png"),
        };
        Transfer[] Transfer_Veres = new Transfer[]
        {
            new Transfer("Роберт Гегедош", 12, 24, "28.10.2021", "28.10.2024", 36, "    ФК Верес    ", "          АПЗ          ", "       Юрій Вірт       ", 88, image_path + "image/transfers/Gegedosh.png")
        };
        public Transfers()
        {
            InitializeComponent();
            list_transfers.ItemsSource = Transfer;
        }

        private void Button_Click_Add_Tranfer(object sender, RoutedEventArgs e)
        {
            Transfer_Add add = new Transfer_Add();
            add.ShowDialog();
        }

        private void list_transfers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int selectedItem = 1;
            var item = ((FrameworkElement)e.OriginalSource).DataContext as Transfer;
            for (int i = 0; i < Transfer.Length; i++)
            {
                if (item == null) { break; }
                if (item.IdTransfer == selectedItem)
                {
                    string name = item.PibTransfer;
                    string[] splitName = name.Split(' ');
                    second_name_transfer.Content = splitName[1];
                    first_name_transfer.Content = splitName[0];
                    num_transfer.Content = item.NumberPlayer;
                    player_position.Content = item.Position;
                    begin_contract.Content = item.DateBegin;
                    end_contract.Content = item.DateEnd;
                    player_price.Content = item.Price;
                    player_term.Content = item.Term;
                    player_team.Content = item.Team;
                    image_transfer.Source = new BitmapImage(new Uri(item.ImageTransfer));
                    coach_name.Content = item.Coach;
                }
                selectedItem++;
            }
        }

        private void TeamComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedItem = 0;
            Transfer[][] sourceList = { Transfer, Transfer_Dinamo, Transfer_Shahtar, Transfer_Desna, Transfer_Veres };
            for (int i = 0; i < sourceList.Length; i++)
            {
                if (TeamComboBox.SelectedIndex == selectedItem)
                {
                    list_transfers.ItemsSource = sourceList[i];
                }
                selectedItem++;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Player.OpenHelpFile("Football_Manager_2023.chm", "vikno_transferi.htm");
        }

        private void TeamComboBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Player.OpenHelpFile("Football_Manager_2023.chm", "glosarij.htm");
        }
    }
}
