using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Football_Manager_2023.Pages
{
    /// <summary>
    /// Логика взаимодействия для Transfer_Add.xaml
    /// </summary>
    public partial class Transfer_Add : Window
    {
        string[] PlayersTransfers =
        {
           "Микола Шапаренко",
            "Георгій Бущан",
            "Сергій Сидорчук", 
            "Марлос Ромеро", 
            "Євген Коноплянка", 
            "Андрій П'ятов",
            "Олексій Ковтун", 
            "Дмитро Сидоренко", 
            "Денис Безбородько", 
            "Роберт Гегедош", 
            "Віталій Дахновський", 
            "Богдан Когут", 
            "Крістіан Бако", 
            "Гонсалвес Ісмаїлі", 
            "Дуглас Майкон", 
            "Феррейра Дентіньо", 
            "Степаненко Тарас",
            "Алан Патрік", 
            "Жуніор Мораєс", 
            "Лассіна Траоре", 
            "Бурда Микита", 
            "Тимчик Олександр", 
            "Гармаш Денис", 
            "Де Пена Карлос", 
            "Бесєдін Артем", 
            "Жук Вадим", 
            "Арвеладзе Леван", 
            "Болбат Сергій", 
            "Волошин Вікентій", 
            "Білич Євген", 
            "Солдат Ігор", 
            "Махнєв Дмитро", 
            "Петько Сергій", 
            "Гєчов Михайло", 
            "Напівлях Микита", 
            "Максим Кучинський", 
            "Володимир Заставний",
            "Ілля Повалій", 
            "Олександр Єрмаченко", 
            "Євген Буднік", 
            "Буяльський Віталій", 
            "Кедзьора Томаш", 
            "Сирота Олександр", 
            "Пусь Даниїл", 
            "Завійський Тарас", 
            "Домбровський Андрій", 
            "Гончаренко Роман", 
            "Гук Ігор", 
            "Панасенко Сергій", 
            "Дударенко Олександр", 
            "Маткобожик Олександр", 
            "Лобай Іван", 
            "Чачуа Амбросій", 
            "Тітунін Анатолій", 
            "Гуменюк Максим"
        };
        Regex inputTermin = new Regex(@"^[0-9]+");
        Regex inputPrice = new Regex(@"^[1-9][0-9]?$|^100$");
        Regex inputDate = new Regex(@"^(0?[1-9]|1[012])[- /.] (0?[1-9]|[12] [0-9]|3[01])[- /.] (19|20)?[0-9]{2}$");
        public Transfer_Add()
        {
            InitializeComponent();
            textboxTermin.PreviewTextInput += new TextCompositionEventHandler(textboxTermin_PreviewTextInput);
            textboxPrice.PreviewTextInput += new TextCompositionEventHandler(textboxPrice_PreviewTextInput);
            PlayersTransferComboBox.ItemsSource = PlayersTransfers;
        }

        private void addTranfer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Додано: \n" + textboxTermin.Text + "; \n" + BeginDate.SelectedDate.ToString() + "; \n" + EndDate.SelectedDate.ToString() + "; \n" + textboxPrice.Text + "; \n"
                + TeamComboBox.SelectedItem.ToString() + "; \n" + PlayersTransferComboBox.SelectedItem.ToString(), "Football Manager", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }

        private void textboxPrice_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !inputPrice.IsMatch(e.Text);
        }

        private void textboxTermin_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Match regexMatch = inputTermin.Match(e.Text);
            if ((sender as TextBox).Text.Length >= 1 || !regexMatch.Success)
            {
                e.Handled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Player.OpenHelpFile("Football_Manager_2023.chm", "vikno_dodati_transfer.htm");
        }

        private void TeamComboBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            FrameworkElement clickedElement = sender as FrameworkElement;
            string componentName = clickedElement.Name;
            Player.OpenHelpFileToKey("Football_Manager_2023.chm", "vikno_dodati_transfer.htm", componentName);
        }
    }
}
