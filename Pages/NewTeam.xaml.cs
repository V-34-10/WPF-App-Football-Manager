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
    /// Логика взаимодействия для NewTeam.xaml
    /// </summary>
    public partial class NewTeam : Page
    {
        public NewTeam()
        {
            InitializeComponent();
        }

        private void TargetPanel_Drop(object sender, DragEventArgs e)
        {
            var obj = e.Data.GetData(typeof(PlayerBlock)) as PlayerBlock;
            ((WrapPanel)(obj.Parent)).Children.Remove(obj);
            TargetPanel.Children.Add(obj);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Player.OpenHelpFile("Football_Manager_2023.chm", "vikno_komanda_mrii.htm");
        }
    }
}