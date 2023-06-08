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
    /// Логика взаимодействия для Plan.xaml
    /// </summary>
    /// 
    
    public partial class Plan : Page
    {
        static string image_path = "file:///D:/Teaching_materials/LMV_DNU/Football_Manager_2023/";
        private Plans[] Plans_Dinamo = new Plans[]
        {
            new Plans(1, "Микола Шапаренко", "АПЗ", 10, "4-3-3"),
            new Plans(2,"Георгій Бущан", "ВР",1 , "4-3-3"),
            new Plans(3,"Сергій Сидорчук", "ЦПЗ",5 , "4-3-3"),
            new Plans(21,"Бурда Микита", "ЦЗ", 6,"4-3-3"),
            new Plans(22,"Тимчик Олександр", "ЛЗ", 24,"4-3-3"),
            new Plans(23,"Гармаш Денис", "ППЗ", 19,"4-3-3"),
            new Plans(24,"Де Пена Карлос", "ЛПЗ", 14,"4-3-3"),
            new Plans(25,"Бесєдін Артем", "НП", 41,"4-3-3"),
            new Plans(41,"Буяльський Віталій","АПЗ", 29, "4-3-3"),
            new Plans(42,"Кедзьора Томаш","ПЗ", 94, "4-3-3"),
            new Plans(43,"Сирота Олександр","ЦЗ", 34, "4-3-3"),
        };
        private Plans[] Plans_Shahtar = new Plans[]
        {
            new Plans(4,"Марлос Ромеро", "АПЗ",11, "4-3-2-1"),
            new Plans(5,"Євген Коноплянка", "ЛПЗ", 70, "4-3-2-1"),
            new Plans(6,"Андрій П'ятов", "ВР", 30, "4-3-2-1"),
            new Plans(13,"Крістіан Бако", "НП", 0,"4-3-2-1"),
            new Plans(14,"Гонсалвес Ісмаїлі", "ЦЗ", 31,"4-3-2-1"),
            new Plans(15,"Майкон", "АПЗ", 7,"4-3-2-1"),
            new Plans(16,"Дентіньо", "АПЗ", 9,"4-3-2-1"),
            new Plans(17,"Степаненко Тарас","ЦПЗ", 6,"4-3-2-1"),
            new Plans(18,"Алан Патрік", "ППЗ", 21,"4-3-2-1"),
            new Plans(19,"Мораєс", "НП", 10,"4-3-2-1"),
            new Plans(20,"Траоре", "НП", 23,"4-3-2-1"),
        };
        private Plans[] Plans_Desna = new Plans[]
        {
            new Plans(7,"Олексій Ковтун", "ЦЗ", 6, "4-1-2-1-2"),
            new Plans(8,"Дмитро Сидоренко", "ВР", 1,"4-1-2-1-2"),
            new Plans(9,"Денис Безбородько", "НП", 20,"4-1-2-1-2"),
            new Plans(26,"Жук Вадим", "ЛЗ", 2,"4-1-2-1-2"),
            new Plans(27,"Арвеладзе Леван", "ЦПЗ", 9,"4-1-2-1-2"),
            new Plans(28,"Болбат Сергій", "ППЗ", 7,"4-1-2-1-2"),
            new Plans(29,"Волошин Вікентій", "ЛПЗ", 15,"4-1-2-1-2"),
            new Plans(30,"Білич Євген", "ПЗ", 10,"4-1-2-1-2"),
            new Plans(44,"Пусь Даниїл","ЦЗ", 23, "4-1-2-1-2"),
            new Plans(45,"Завійський Тарас","АПЗ", 7,"4-1-2-1-2"),
            new Plans(46,"Домбровський Андрій","ОПЗ", 8, "4-1-2-1-2"),
        };
        private Plans[] Plans_Veres = new Plans[]
        {
            new Plans(10,"Роберт Гегедош", "НП", 88,"4-4-2"),
            new Plans(11,"Віталій Дахновський", "ЦПЗ" , 11,"4-4-2"),
            new Plans(12,"Богдан Когут", "ВР", 47,"4-4-2"),
            new Plans(31,"Солдат Ігор", "ЦЗ" , 4,"4-4-2"),
            new Plans(32,"Махнєв Дмитро", "ПЗ" ,14 ,"4-4-2"),
            new Plans(33,"Петько Сергій", "ППЗ" , 32,"4-4-2"),
            new Plans(34,"Гєчов Михайло", "АПЗ" , 97,"4-4-2"),
            new Plans(35,"Напівлях Микита", "ЛПЗ" , 77,"4-4-2"),
            new Plans(47,"Гончаренко Роман","ЛЗ", 8,"4-4-2"),
            new Plans(48,"Гук Ігор","ЦЗ", 24, "4-4-2"),
            new Plans(49,"Панасенко Сергій","ОПЗ", 21,"4-4-2"),
        };
        private Plans[] Plans_Karpaty = new Plans[]
        {
            new Plans(36,"Максим Кучинський", "ВР" , 1,"4-5-1"),
            new Plans(37,"Володимир Заставний", "ЦЗ" , 90,"4-5-1"),
            new Plans(38,"Ілля Повалій", "ППЗ" , 18,"4-5-1"),
            new Plans(39,"Олександр Єрмаченко", "ЛПЗ" , 10,"4-5-1"),
            new Plans(40,"Євген Буднік", "НП" , 99 ,"4-5-1"),
            new Plans(50,"Дударенко Олександр","ЦЗ", 21, "4-5-1"),
            new Plans(51,"Маткобожик Олександр","ЛЗ", 15,"4-5-1"),
            new Plans(52,"Лобай Іван","ПЗ", 5, "4-5-1"),
            new Plans(53,"Чачуа Амбросій","ЦПЗ", 8, "4-5-1"),
            new Plans(54,"Тітунін Анатолій","ОПЗ", 17, "4-5-1"),
            new Plans(55,"Гуменюк Максим","АПЗ", 74, "4-5-1"),
        };
        public Plan()
        {
            InitializeComponent();
            list_players_plan.ItemsSource = Plans_Dinamo;
        }

        private void PlanComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedItem = 0;
            Plans[][] sourceList = { Plans_Dinamo, Plans_Shahtar, Plans_Desna, Plans_Veres, Plans_Karpaty };
            string[] selectedTeam = { "ФК Динамо", "ФК Шахтар", "ФК Десна", "ФК Верес", "ФК Карпати"};
            string[] imagePlan = { image_path + "image/plan/4-3-3.png", image_path + "image/plan/4-5-1.png", image_path + "image/plan/4-4-2.png", 
                image_path + "image/plan/4-3-2-1.png", image_path + "image/plan/4-1-2-1-2.png" };
            for (int i = 0; i < imagePlan.Length; i++)
            {
                if (PlanComboBox.SelectedIndex == selectedItem)
                {
                    image_plan.Source = new BitmapImage(new Uri(imagePlan[i]));
                    labl_team.Content = selectedTeam[i];
                    list_players_plan.ItemsSource = sourceList[i];
                }
                selectedItem++;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Player.OpenHelpFile("Football_Manager_2023.chm", "vikno_plan.htm");
        }

        private void TeamComboBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Player.OpenHelpFile("Football_Manager_2023.chm", "glosarij.htm");
        }
    }
}
