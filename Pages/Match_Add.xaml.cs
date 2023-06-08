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
    /// Логика взаимодействия для Match_Add.xaml
    /// </summary>
    public partial class Match_Add : Window
    {
        string[] TeamMatch = 
            {"ФК Динамо", "ФК Шахтар", "ФК Десна", "ФК Верес", "ФК Карпати" };
        string[] PlanMatch =
           {"4-3-3", "4-3-2-1", "4-1-2-1-2", "4-4-2", "4-5-1" };
        string[] SezonMatch =
           {"20/21", "21/22", "22/23", "23/24", "24/25" };
        Regex input = new Regex(@"^[0-9]+");
        Regex inputResult = new Regex(@"[^0-9-\/]");
        public Match_Add()
        {
            InitializeComponent();
            HomeTeamMatchComboBox.ItemsSource = TeamMatch;
            GeustTeamMatchComboBox.ItemsSource = TeamMatch;
            PlanMatchComboBox.ItemsSource = PlanMatch;
            SezonMatchComboBox.ItemsSource = SezonMatch;
        }

        private void addMatch_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Додано: \n" + HomeTeamMatchComboBox.SelectedItem.ToString() + "; \n" + GeustTeamMatchComboBox.SelectedItem.ToString() + "; \n" + MatchDate.SelectedDate.ToString() + "; \n" + 
                PlanMatchComboBox.SelectedItem.ToString() + "; \n" + textboxCountGoals.Text + "; \n" + textboxCountPass.Text + "; \n" + textboxResult.Text + "; \n" + SezonMatchComboBox.SelectedItem.ToString(), "Football Manager", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }

        private static void Text_Changed(object sender, EventArgs args)
        {
            var tb = sender as TextBox;
            if (tb == null) return;
            var actual = tb.Text;
            var disallowed = @"[^0-9-\/]";
            var newText = Regex.Replace(actual, disallowed, string.Empty);
            if (string.CompareOrdinal(tb.Text, newText) != 0)
            {
                var sstart = tb.SelectionStart;
                tb.Text = newText;
                tb.SelectionStart = sstart - 1;
            }
        }

        private void textboxCountGoals_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !input.IsMatch(e.Text);
        }

        private void textboxCountPass_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !input.IsMatch(e.Text);
        }

        private void textboxResult_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = inputResult.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Player.OpenHelpFile("Football_Manager_2023.chm", "vikno_dodati_rezultati_matchiv.htm");
        }

        private void TeamComboBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            FrameworkElement clickedElement = sender as FrameworkElement;
            string componentName = clickedElement.Name;
            Player.OpenHelpFileToKey("Football_Manager_2023.chm", "vikno_dodati_rezultati_matchiv.htm", componentName);
        }
    }
}
