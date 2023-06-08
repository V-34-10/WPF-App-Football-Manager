using Football_Manager_2023.Pages;
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

namespace Football_Manager_2023
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sidebar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = sidebar.SelectedItem as NavigationPanel;
            navframe.Navigate(selected.Navlink);
        }

        private void NavigationPanel_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Player.OpenHelpFile("Football_Manager_2023.chm", "golovne_vikno.htm");
        }

        private void sidebar_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Player.OpenHelpFile("Football_Manager_2023.chm", "glosarij.htm");
        }
    }
}
