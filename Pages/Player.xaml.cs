using Football_Manager_2023.Model;
using Google.Rpc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
    /// Логика взаимодействия для Player.xaml
    /// </summary>
    public partial class Player : Page
    {
        static string image_path = "file:///D:/Teaching_materials/LMV_DNU/Football_Manager_2023/";
        Players[] Players = new Players[]
        {
            new Players(1, "Микола Шапаренко", "ФК Динамо", 10, "  1998-10-04  ", "  АПЗ  ", "Мірча Луческу", image_path + "image/players/Shaparenko.png", image_path + "image/team/Dinamo-1.png"),
            new Players(2, "Георгій Бущан", "ФК Динамо", 1, "  1994-05-31  ", "  ВР  ", "Мірча Луческу", image_path + "image/players/Bushchan.png", image_path + "image/team/Dinamo-1.png"),
            new Players(3, "Сергій Сидорчук", "ФК Динамо", 5, "  1991-05-02  ", "  ЦПЗ  ", "Мірча Луческу", image_path + "image/players/Sydorchuk.png", image_path + "image/team/Dinamo-1.png"),

            new Players(4, "Марлос Ромеро", "ФК Шахтар", 11, "  1988-06-07  ", "  АПЗ  ", "Де Дзерби, Роберто", image_path + "image/players/Marlos.png", image_path + "image/team/FC_Shakhtar-1.png"),
            new Players(5, "Євген Коноплянка", "ФК Шахтар", 70, "  1989-09-29  ", "  ЛПЗ  ", "Де Дзерби, Роберто", image_path + "image/players/Konoplyanka.png", image_path + "image/team/FC_Shakhtar-1.png"),
            new Players(6, "Андрій П'ятов", "ФК Шахтар", 30, "  1984-06-28  ", "  ВР  ", "Де Дзерби, Роберто", image_path + "image/players/Pyatov.png", image_path + "image/team/FC_Shakhtar-1.png"),

            new Players(7, "Олексій Ковтун", "ФК Десна", 6, "  1995-02-05  ", "  ЦЗ  ", "Рябоконь Олександр", image_path + "image/players/Kovtun.png", image_path + "image/team/Desna-1.png"),
            new Players(8, "Дмитро Сидоренко", "ФК Десна", 1, "  2002-11-12  ", "  ВР  ", "Рябоконь Олександр", image_path + "image/players/Sudorenko.png", image_path + "image/team/Desna-1.png"),
            new Players(9, "Денис Безбородько", "ФК Десна", 20, "  1994-05-31  ", "  НП  ", "Рябоконь Олександр", image_path + "image/players/Bezborodyko.png", image_path + "image/team/Desna-1.png"),

            new Players(10, "Роберт Гегедош", "ФК Верес", 88, "  1993-05-02  ", "  НП  ", "Юрій Вірт", image_path + "image/players/Gegedosh.png", image_path + "image/team/Veres-1.png"),
            new Players(11, "Віталій Дахновський", "ФК Верес", 11, "  1999-02-10  ", "  ЦПЗ  ", "Юрій Вірт", image_path + "image/players/Dahnovskiy.png", image_path + "image/team/Veres-1.png"),
            new Players(12, "Богдан Когут", "ФК Верес", 47, "  1987-10-10  ", "  ВР  ", "Юрій Вірт", image_path + "image/players/Kogut.png", image_path + "image/team/Veres-1.png"),

            new Players(13, "Крістіан Бако", "ФК Шахтар", 0, "  2003-01-07  ", "  НП  ", "Де Дзерби, Роберто", image_path + "image/players/Bako.png", image_path + "image/team/FC_Shakhtar-1.png"),
            new Players(14, "Гонсалвес Ісмаїлі", "ФК Шахтар",31, "  1990-01-11  ", "  ЦЗ  ", "Де Дзерби, Роберто", image_path + "image/players/Ismaili.png", image_path + "image/team/FC_Shakhtar-1.png"),
            new Players(15, "Дуглас Майкон", "ФК Шахтар", 7, "  1997-07-15  ", "  АПЗ  ", "Де Дзерби, Роберто", image_path + "image/players/Maikon.png", image_path + "image/team/FC_Shakhtar-1.png"),
            new Players(16, "Феррейра Дентіньо", "ФК Шахтар", 9, "  1989-01-19  ", "  АПЗ  ", "Де Дзерби, Роберто", image_path + "image/players/Dentinio.png", image_path + "image/team/FC_Shakhtar-1.png"),
            new Players(17, "Степаненко Тарас","ФК Шахтар", 6, "  1989-08-08  ", "  ЦПЗ  ", "Де Дзерби, Роберто", image_path + "image/players/Stepanenko.png", image_path + "image/team/FC_Shakhtar-1.png"),
            new Players(18, "Алан Патрік", "ФК Шахтар", 21, "  1991-05-13  ", "  ППЗ  ", "Де Дзерби, Роберто", image_path + "image/players/Patrik.png", image_path + "image/team/FC_Shakhtar-1.png"),
            new Players(19, "Жуніор Мораєс", "ФК Шахтар", 10, "  1987-04-04  ", "  НП  ", "Де Дзерби, Роберто", image_path + "image/players/Moraes.png", image_path + "image/team/FC_Shakhtar-1.png"),
            new Players(20, "Лассіна Траоре", "ФК Шахтар", 23, "  2001-01-12", "  НП  ", "Де Дзерби, Роберто", image_path + "image/players/Traore.png", image_path + "image/team/FC_Shakhtar-1.png"),

            new Players(21, "Бурда Микита", "ФК Динамо", 6, "  1995-03-21  ", "  ЦЗ  ", "Мірча Луческу", image_path + "image/players/Burda.png", image_path + "image/team/Dinamo-1.png"),
            new Players(22, "Тимчик Олександр", "ФК Динамо", 24, "  1997-01-20  ", "  ЛЗ  ", "Мірча Луческу", image_path + "image/players/Timchuk.png", image_path + "image/team/Dinamo-1.png"),
            new Players(23, "Гармаш Денис", "ФК Динамо", 19, "  1990-04-19  ", "  ППЗ  ", "Мірча Луческу", image_path + "image/players/Garmash.png", image_path + "image/team/Dinamo-1.png"),
            new Players(24, "Де Пена Карлос", "ФК Динамо", 14, "  1992-03-11  ", "  ЛПЗ  ", "Мірча Луческу", image_path + "image/players/DePena.png", image_path + "image/team/Dinamo-1.png"),
            new Players(25, "Бесєдін Артем", "ФК Динамо", 41, "  1996-03-31  ", "  НП  ", "Мірча Луческу", image_path + "image/players/Besedin.png", image_path + "image/team/Dinamo-1.png"),

            new Players(26, "Жук Вадим", "ФК Десна", 2, "  1991-04-15  ", "  ЛЗ  ", "Рябоконь Олександр", image_path + "image/players/Juk.png", image_path + "image/team/Desna-1.png"),
            new Players(27, "Арвеладзе Леван", "ФК Десна", 9, "  1993-04-06  ", "  ЦПЗ  ", "Рябоконь Олександр", image_path + "image/players/Arveladze.png", image_path + "image/team/Desna-1.png"),
            new Players(28, "Болбат Сергій", "ФК Десна", 7, "  1993-06-13  ", "  ППЗ  ", "Рябоконь Олександр", image_path + "image/players/Bolbat.png", image_path + "image/team/Desna-1.png"),
            new Players(29, "Волошин Вікентій", "ФК Десна", 15, "  2001-04-17  ", "  ЛПЗ  ", "Рябоконь Олександр", image_path + "image/players/Voloshun.png", image_path + "image/team/Desna-1.png"),
            new Players(30, "Білич Євген", "ФК Десна", 10, "  2001-01-10  ", "  ПЗ  ", "Рябоконь Олександр", image_path + "image/players/Marlos.png", image_path + "image/team/Desna-1.png"),

            new Players(31, "Солдат Ігор", "ФК Верес", 4, "  1991-03-10  ", "  ЦЗ  ", "Юрій Вірт", image_path + "image/players/Soldat.png", image_path + "image/team/Veres-1.png"),
            new Players(32, "Махнєв Дмитро", "ФК Верес", 14, "  1996-03-02  ", "  ПЗ  ", "Юрій Вірт", image_path + "image/players/Makhnyev.png", image_path + "image/team/Veres-1.png"),
            new Players(33, "Петько Сергій", "ФК Верес", 32, "  1994-01-23  ", "  ППЗ  ", "Юрій Вірт", image_path + "image/players/Petko.png", image_path + "image/team/Veres-1.png"),
            new Players(34, "Гєчов Михайло", "ФК Верес", 97, "  1997-11-05  ", "  АПЗ  ", "Юрій Вірт", image_path + "image/players/Hyechov.png", image_path + "image/team/Veres-1.png"),
            new Players(35, "Напівлях Микита", "ФК Верес", 77, "  1993-03-15  ", "  ЛПЗ  ", "Юрій Вірт", image_path + "image/players/Napivlyakh.png", image_path + "image/team/Veres-1.png"),

            new Players(36, "Максим Кучинський", "ФК Карпати", 1, "  1988-06-28  ", "  ВР  ", "Андрій Тлумак", image_path + "image/players/Kuchinskiy.png", image_path + "image/team/Karpaty-1.png"),
            new Players(37, "Володимир Заставний", "ФК Карпати", 90, "  1990-09-02  ", "  ЦЗ  ", "Андрій Тлумак", image_path + "image/players/Zastavniy.png", image_path + "image/team/Karpaty-1.png"),
            new Players(38, "Ілля Повалій", "ФК Карпати", 18, "  1998-06-08  ", "  ППЗ  ", "Андрій Тлумак", image_path + "image/players/Povaliy.png", image_path + "image/team/Karpaty-1.png"),
            new Players(39, "Олександр Єрмаченко", "ФК Карпати", 10, "  1993-01-29  ", "  ЛПЗ  ", "Андрій Тлумак", image_path + "image/players/Iermachenko.png", image_path + "image/team/Karpaty-1.png"),
            new Players(40, "Євген Буднік", "ФК Карпати", 99, "  1990-09-04  ", "  НП  ", "Андрій Тлумак", image_path + "image/players/Budnik.png", image_path + "image/team/Karpaty-1.png"),

            new Players(41, "Буяльський Віталій", "ФК Динамо", 29, "  1993-01-06  ", "  АПЗ  ", "Мірча Луческу", image_path + "image/players/Buyalskiy.png", image_path + "image/team/Dinamo-1.png"),
            new Players(42, "Кедзьора Томаш", "ФК Динамо", 94, "  1994-06-11  ", "  ПЗ  ", "Мірча Луческу", image_path + "image/players/Kedjora.png", image_path + "image/team/Dinamo-1.png"),
            new Players(43, "Сирота Олександр", "ФК Динамо", 34, "  2000-06-11  ", "  ЦЗ  ", "Мірча Луческу", image_path + "image/players/Sirota.png", image_path + "image/team/Dinamo-1.png"),

            new Players(44, "Пусь Даниїл", "ФК Десна", 23, "  2003-01-02  ", "  ЦЗ  ", "Рябоконь Олександр", image_path + "image/players/Pus.png", image_path + "image/team/Desna-1.png"),
            new Players(45, "Завійський Тарас", "ФК Десна", 7, "  1995-04-12  ", "  АПЗ  ", "Рябоконь Олександр", image_path + "image/players/Zavoyskiy.png", image_path + "image/team/Desna-1.png"),
            new Players(46, "Домбровський Андрій", "ФК Десна", 8, "  1995-08-12  ", "  ОПЗ  ", "Рябоконь Олександр", image_path + "image/players/Dombrovskiy.png", image_path + "image/team/Desna-1.png"),

            new Players(47, "Гончаренко Роман", "ФК Верес", 8, "  1993-11-16  ", "  ЛЗ  ", "Юрій Вірт", image_path + "image/players/Goncharenko.png", image_path + "image/team/Veres-1.png"),
            new Players(48, "Гук Ігор", "ФК Верес", 24, "  2002-06-11  ", "  ЦЗ  ", "Юрій Вірт", image_path + "image/players/Guk.png", image_path + "image/team/Veres-1.png"),
            new Players(49, "Панасенко Сергій", "ФК Верес", 21, "  1992-03-09  ", "  ОПЗ  ", "Юрій Вірт", image_path + "image/players/Panasenko.png", image_path + "image/team/Veres-1.png"),

            new Players(50, "Дударенко Олександр", "ФК Карпати", 21, "  1995-04-10  ", "  ЦЗ  ", "Андрій Тлумак", image_path + "image/players/Dudarenko.png", image_path + "image/team/Karpaty-1.png"),
            new Players(51, "Маткобожик Олександр", "ФК Карпати", 15, "  1998-01-03  ", "  ЛЗ  ", "Андрій Тлумак", image_path + "image/players/Matkobaznik.png", image_path + "image/team/Karpaty-1.png"),
            new Players(52, "Лобай Іван", "ФК Карпати", 5, "  1996-05-21  ", "  ПЗ  ", "Андрій Тлумак", image_path + "image/players/Lobaj.png", image_path + "image/team/Karpaty-1.png"),
            new Players(53, "Чачуа Амбросій", "ФК Карпати", 8, "  1994-04-02  ", "  ЦПЗ  ", "Андрій Тлумак", image_path + "image/players/Chachua.png", image_path + "image/team/Karpaty-1.png"),
            new Players(54, "Тітунін Анатолій", "ФК Карпати", 17, "  1993-03-12  ", "  ОПЗ  ", "Андрій Тлумак", image_path + "image/players/Titunin.png", image_path + "image/team/Karpaty-1.png"),
            new Players(55, "Гуменюк Максим", "ФК Карпати", 74, "  1999-02-01  ", "  АПЗ  ", "Андрій Тлумак", image_path + "image/players/Gumenyuk.png", image_path + "image/team/Karpaty-1.png")
        };
        Players[] Players_Dinamo = new Players[]
        {
            new Players(1, "Микола Шапаренко", "ФК Динамо", 10, "  1998-10-04  ", "  АПЗ  ", "Мірча Луческу", image_path + "image/players/Shaparenko.png", image_path + "image/team/Dinamo-1.png"),
            new Players(2, "Георгій Бущан", "ФК Динамо", 1, "  1994-05-31  ", "  ВР  ", "Мірча Луческу", image_path + "image/players/Bushchan.png", image_path + "image/team/Dinamo-1.png"),
            new Players(3, "Сергій Сидорчук", "ФК Динамо", 5, "  1991-05-02  ", "  ЦПЗ  ", "Мірча Луческу", image_path + "image/players/Sydorchuk.png", image_path + "image/team/Dinamo-1.png"),
            new Players(21, "Бурда Микита", "ФК Динамо", 6, "  1995-03-21  ", "  ЦЗ  ", "Мірча Луческу", image_path + "image/players/Burda.png", image_path + "image/team/Dinamo-1.png"),
            new Players(22, "Тимчик Олександр", "ФК Динамо", 24, "  1997-01-20  ", "  ЛЗ  ", "Мірча Луческу", image_path + "image/players/Timchuk.png", image_path + "image/team/Dinamo-1.png"),
            new Players(23, "Гармаш Денис", "ФК Динамо", 19, "  1990-04-19  ", "  ППЗ  ", "Мірча Луческу", image_path + "image/players/Garmash.png", image_path + "image/team/Dinamo-1.png"),
            new Players(24, "Де Пена Карлос", "ФК Динамо", 14, "  1992-03-11  ", "  ЛПЗ  ", "Мірча Луческу", image_path + "image/players/DePena.png", image_path + "image/team/Dinamo-1.png"),
            new Players(25, "Бесєдін Артем", "ФК Динамо", 41, "  1996-03-31  ", "  НП  ", "Мірча Луческу", image_path + "image/players/Besedin.png", image_path + "image/team/Dinamo-1.png"),
            new Players(41, "Буяльський Віталій", "ФК Динамо", 29, "  1993-01-06  ", "  АПЗ  ", "Мірча Луческу", image_path + "image/players/Buyalskiy.png", image_path + "image/team/Dinamo-1.png"),
            new Players(42, "Кедзьора Томаш", "ФК Динамо", 94, "  1994-06-11  ", "  ПЗ  ", "Мірча Луческу", image_path + "image/players/Kedjora.png", image_path + "image/team/Dinamo-1.png"),
            new Players(43, "Сирота Олександр", "ФК Динамо", 34, "  2000-06-11  ", "  ЦЗ  ", "Мірча Луческу", image_path + "image/players/Sirota.png", image_path + "image/team/Dinamo-1.png"),
        };
        Players[] Players_Shahtar = new Players[]
        {
            new Players(4, "Марлос Ромеро", "ФК Шахтар", 11, "  1988-06-07  ", "  АПЗ  ", "Де Дзерби, Роберто", image_path + "image/players/Marlos.png", image_path + "image/team/FC_Shakhtar-1.png"),
            new Players(5, "Євген Коноплянка", "ФК Шахтар", 70, "  1989-09-29  ", "  ЛПЗ  ", "Де Дзерби, Роберто", image_path + "image/players/Konoplyanka.png", image_path + "image/team/FC_Shakhtar-1.png"),
            new Players(6, "Андрій П'ятов", "ФК Шахтар", 30, "  1984-06-28  ", "  ВР  ", "Де Дзерби, Роберто", image_path + "image/players/Pyatov.png", image_path + "image/team/FC_Shakhtar-1.png"),
            new Players(13, "Крістіан Бако", "ФК Шахтар", 0, "  2003-01-07  ", "  НП  ", "Де Дзерби, Роберто", image_path + "image/players/Bako.png", image_path + "image/team/FC_Shakhtar-1.png"),
            new Players(14, "Гонсалвес Ісмаїлі", "ФК Шахтар",31, "  1990-01-11  ", "  ЦЗ  ", "Де Дзерби, Роберто", image_path + "image/players/Ismaili.png", image_path + "image/team/FC_Shakhtar-1.png"),
            new Players(15, "Дуглас Майкон", "ФК Шахтар", 7, "  1997-07-15  ", "  АПЗ  ", "Де Дзерби, Роберто", image_path + "image/players/Maikon.png", image_path + "image/team/FC_Shakhtar-1.png"),
            new Players(16, "Феррейра Дентіньо", "ФК Шахтар", 9, "  1989-01-19  ", "  АПЗ  ", "Де Дзерби, Роберто", image_path + "image/players/Dentinio.png", image_path + "image/team/FC_Shakhtar-1.png"),
            new Players(17, "Степаненко Тарас","ФК Шахтар", 6, "  1989-08-08  ", "  ЦПЗ  ", "Де Дзерби, Роберто", image_path + "image/players/Stepanenko.png", image_path + "image/team/FC_Shakhtar-1.png"),
            new Players(18, "Алан Патрік", "ФК Шахтар", 21, "  1991-05-13  ", "  ППЗ  ", "Де Дзерби, Роберто", image_path + "image/players/Patrik.png", image_path + "image/team/FC_Shakhtar-1.png"),
            new Players(19, "Жуніор Мораєс", "ФК Шахтар", 10, "  1987-04-04  ", "  НП  ", "Де Дзерби, Роберто", image_path + "image/players/Moraes.png", image_path + "image/team/FC_Shakhtar-1.png"),
            new Players(20, "Лассіна Траоре", "ФК Шахтар", 23, "  2001-01-12", "  НП  ", "Де Дзерби, Роберто", image_path + "image/players/Traore.png", image_path + "image/team/FC_Shakhtar-1.png"),
        };
        Players[] Players_Desna = new Players[]
        {
            new Players(7, "Олексій Ковтун", "ФК Десна", 6, "  1995-02-05  ", "  ЦЗ  ", "Рябоконь Олександр", image_path + "image/players/Kovtun.png", image_path + "image/team/Desna-1.png"),
            new Players(8, "Дмитро Сидоренко", "ФК Десна", 1, "  2002-11-12  ", "  ВР  ", "Рябоконь Олександр", image_path + "image/players/Sudorenko.png", image_path + "image/team/Desna-1.png"),
            new Players(9, "Денис Безбородько", "ФК Десна", 20, "  1994-05-31  ", "  НП  ", "Рябоконь Олександр", image_path + "image/players/Bezborodyko.png", image_path + "image/team/Desna-1.png"),
            new Players(26, "Жук Вадим", "ФК Десна", 2, "  1991-04-15  ", "  ЛЗ  ", "Рябоконь Олександр", image_path + "image/players/Juk.png", image_path + "image/team/Desna-1.png"),
            new Players(27, "Арвеладзе Леван", "ФК Десна", 9, "  1993-04-06  ", "  ЦПЗ  ", "Рябоконь Олександр", image_path + "image/players/Arveladze.png", image_path + "image/team/Desna-1.png"),
            new Players(28, "Болбат Сергій", "ФК Десна", 7, "  1993-06-13  ", "  ППЗ  ", "Рябоконь Олександр", image_path + "image/players/Bolbat.png", image_path + "image/team/Desna-1.png"),
            new Players(29, "Волошин Вікентій", "ФК Десна", 15, "  2001-04-17  ", "  ЛПЗ  ", "Рябоконь Олександр", image_path + "image/players/Voloshun.png", image_path + "image/team/Desna-1.png"),
            new Players(30, "Білич Євген", "ФК Десна", 10, "  2001-01-10  ", "  ПЗ  ", "Рябоконь Олександр", image_path + "image/players/Marlos.png", image_path + "image/team/Desna-1.png"),
            new Players(44, "Пусь Даниїл", "ФК Десна", 23, "  2003-01-02  ", "  ЦЗ  ", "Рябоконь Олександр", image_path + "image/players/Pus.png", image_path + "image/team/Desna-1.png"),
            new Players(45, "Завійський Тарас", "ФК Десна", 7, "  1995-04-12  ", "  АПЗ  ", "Рябоконь Олександр", image_path + "image/players/Zavoyskiy.png", image_path + "image/team/Desna-1.png"),
            new Players(46, "Домбровський Андрій", "ФК Десна", 8, "  1995-08-12  ", "  ОПЗ  ", "Рябоконь Олександр", image_path + "image/players/Dombrovskiy.png", image_path + "image/team/Desna-1.png"),
        };
        Players[] Players_Veres = new Players[]
        {
            new Players(10, "Роберт Гегедош", "ФК Верес", 88, "  1993-05-02  ", "  НП  ", "Юрій Вірт", image_path + "image/players/Gegedosh.png", image_path + "image/team/Veres-1.png"),
            new Players(11, "Віталій Дахновський", "ФК Верес", 11, "  1999-02-10  ", "  ЦПЗ  ", "Юрій Вірт", image_path + "image/players/Dahnovskiy.png", image_path + "image/team/Veres-1.png"),
            new Players(12, "Богдан Когут", "ФК Верес", 47, "  1987-10-10  ", "  ВР  ", "Юрій Вірт", image_path + "image/players/Kogut.png", image_path + "image/team/Veres-1.png"),
            new Players(31, "Солдат Ігор", "ФК Верес", 4, "  1991-03-10  ", "  ЦЗ  ", "Юрій Вірт", image_path + "image/players/Soldat.png", image_path + "image/team/Veres-1.png"),
            new Players(32, "Махнєв Дмитро", "ФК Верес", 14, "  1996-03-02  ", "  ПЗ  ", "Юрій Вірт", image_path + "image/players/Makhnyev.png", image_path + "image/team/Veres-1.png"),
            new Players(33, "Петько Сергій", "ФК Верес", 32, "  1994-01-23  ", "  ППЗ  ", "Юрій Вірт", image_path + "image/players/Petko.png", image_path + "image/team/Veres-1.png"),
            new Players(34, "Гєчов Михайло", "ФК Верес", 97, "  1997-11-05  ", "  АПЗ  ", "Юрій Вірт", image_path + "image/players/Hyechov.png", image_path + "image/team/Veres-1.png"),
            new Players(35, "Напівлях Микита", "ФК Верес", 77, "  1993-03-15  ", "  ЛПЗ  ", "Юрій Вірт", image_path + "image/players/Napivlyakh.png", image_path + "image/team/Veres-1.png"),
            new Players(47, "Гончаренко Роман", "ФК Верес", 8, "  1993-11-16  ", "  ЛЗ  ", "Юрій Вірт", image_path + "image/players/Goncharenko.png", image_path + "image/team/Veres-1.png"),
            new Players(48, "Гук Ігор", "ФК Верес", 24, "  2002-06-11  ", "  ЦЗ  ", "Юрій Вірт", image_path + "image/players/Guk.png", image_path + "image/team/Veres-1.png"),
            new Players(49, "Панасенко Сергій", "ФК Верес", 21, "  1992-03-09  ", "  ОПЗ  ", "Юрій Вірт", image_path + "image/players/Panasenko.png", image_path + "image/team/Veres-1.png"),
        };
        Players[] Players_Karpaty = new Players[]
        {
            new Players(36, "Максим Кучинський", "ФК Карпати", 1, "  1988-06-28  ", "  ВР  ", "Андрій Тлумак", image_path + "image/players/Kuchinskiy.png", image_path + "image/team/Karpaty-1.png"),
            new Players(37, "Володимир Заставний", "ФК Карпати", 90, "  1990-09-02  ", "  ЦЗ  ", "Андрій Тлумак", image_path + "image/players/Zastavniy.png", image_path + "image/team/Karpaty-1.png"),
            new Players(38, "Ілля Повалій", "ФК Карпати", 18, "  1998-06-08  ", "  ППЗ  ", "Андрій Тлумак", image_path + "image/players/Povaliy.png", image_path + "image/team/Karpaty-1.png"),
            new Players(39, "Олександр Єрмаченко", "ФК Карпати", 10, "  1993-01-29  ", "  ЛПЗ  ", "Андрій Тлумак", image_path + "image/players/Iermachenko.png", image_path + "image/team/Karpaty-1.png"),
            new Players(40, "Євген Буднік", "ФК Карпати", 99, "  1990-09-04  ", "  НП  ", "Андрій Тлумак", image_path + "image/players/Budnik.png", image_path + "image/team/Karpaty-1.png"),
            new Players(50, "Дударенко Олександр", "ФК Карпати", 21, "  1995-04-10  ", "  ЦЗ  ", "Андрій Тлумак", image_path + "image/players/Dudarenko.png", image_path + "image/team/Karpaty-1.png"),
            new Players(51, "Маткобожик Олександр", "ФК Карпати", 15, "  1998-01-03  ", "  ЛЗ  ", "Андрій Тлумак", image_path + "image/players/Matkobaznik.png", image_path + "image/team/Karpaty-1.png"),
            new Players(52, "Лобай Іван", "ФК Карпати", 5, "  1996-05-21  ", "  ПЗ  ", "Андрій Тлумак", image_path + "image/players/Lobaj.png", image_path + "image/team/Karpaty-1.png"),
            new Players(53, "Чачуа Амбросій", "ФК Карпати", 8, "  1994-04-02  ", "  ЦПЗ  ", "Андрій Тлумак", image_path + "image/players/Chachua.png", image_path + "image/team/Karpaty-1.png"),
            new Players(54, "Тітунін Анатолій", "ФК Карпати", 17, "  1993-03-12  ", "  ОПЗ  ", "Андрій Тлумак", image_path + "image/players/Titunin.png", image_path + "image/team/Karpaty-1.png"),
            new Players(55, "Гуменюк Максим", "ФК Карпати", 74, "  1999-02-01  ", "  АПЗ  ", "Андрій Тлумак", image_path + "image/players/Gumenyuk.png", image_path + "image/team/Karpaty-1.png")
        };

        public Player()
        {
            InitializeComponent();
            list_players.ItemsSource = Players;

        }

        private void TeamComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedItem = 0;
            Players[][] sourceList = { Players, Players_Dinamo, Players_Shahtar, Players_Desna, Players_Veres, Players_Karpaty };
            for (int i = 0; i < sourceList.Length; i++)
            {
                if (TeamComboBox.SelectedIndex == selectedItem)
                {
                    list_players.ItemsSource = sourceList[i];
                }
                selectedItem++;
            }
        }

        private void list_players_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int selectedItem = 1;
            var item = ((FrameworkElement)e.OriginalSource).DataContext as Players;
            for (int i = 0; i < Players.Length; i++)
            {
                if (item == null) { break; }
                if (item.Id == selectedItem)
                {
                    string name = item.Pib;
                    string[] splitName = name.Split(' ');
                    player_second_name.Content = splitName[1];
                    player_first_name.Content = splitName[0];
                    player_number.Content = item.PlayerNumber;
                    player_position.Content = item.Position;
                    player_date_born.Content = item.DateBorn;
                    player_image.Source = new BitmapImage(new Uri(item.ImagePlayer));
                    team_image.Source = new BitmapImage(new Uri(item.ImageTeam));
                    coach_name.Content = item.Coach;

                }
                selectedItem++;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenHelpFile("Football_Manager_2023.chm", "vikno_gravtsi.htm");
        }

        public static void OpenHelpFile(string helpFilePath, string helpPage)
        {
            string combinedPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, helpFilePath);
            string helpUrl = "mk:@MSITStore:" + combinedPath + "::/" + helpPage;
            Process.Start("hh.exe", helpUrl);
        }

        public static void OpenHelpFileToKey(string helpFilePath, string helpPage, string keyword)
        {
            string combinedPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, helpFilePath);
            string helpUrl = "mk:@MSITStore:" + combinedPath + "::/" + helpPage + "#" + keyword;
            Process.Start(@"C:\Windows\hh.exe", helpUrl);
        }

        private void TeamComboBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            FrameworkElement clickedElement = sender as FrameworkElement;
            string componentName = clickedElement.Name;
            OpenHelpFileToKey("Football_Manager_2023.chm", "vikno_gravtsi.htm", componentName);
        }
    }
}
