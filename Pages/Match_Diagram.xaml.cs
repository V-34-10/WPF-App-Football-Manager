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
using System.Windows.Shapes;

namespace Football_Manager_2023.Pages
{
    /// <summary>
    /// Логика взаимодействия для Match_Diagram.xaml
    /// </summary>
    public partial class Match_Diagram : Window
    {
        string[] labelsAllTeam = {"02.10.2021", "24.09.2021", "05.12.2021", "21.11.2021", "29.10.2021", "21.08.2021", "29.08.2021", "30.10.2021", "21.09.2021",
            "20.03.2023", "14.02.2023", "03.03.2023", "08.03.2023", "15.03.2023", "30.10.2021" };
        double[] valuesAllTeamPass = { 2, 3, 1, 3, 2, 4, 4, 4, 1, 1, 4, 5, 3, 3, 6 };
        double[] valuesAllTeamGols = { 2, 6, 2, 4, 4, 4, 4, 5, 3, 2, 6, 6, 5, 4, 8 };

        double[] positionsAllTeam = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        double[] positionsDinamoVeres = { 0, 1 };
        double[] positionsDesnaKarpaty = { 0, 1, 2 };
        double[] positionsShahtarSezon23 = { 0, 1, 2, 3, 4 };
        double[] positionsSezon21 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        string[] labelsDinamo = {"02.10.2021", "21.08.2021" };
        double[] valuesDinamoPass = { 2, 4 };
        double[] valuesDinamoGols = { 2, 4 };
        string[] labelsShahtar = {"24.09.2021", "29.10.2021", "30.10.2021", "21.09.2021", "03.03.2023" };
        double[] valuesShahtarPass = { 3, 2, 4, 1, 5 };
        double[] valuesShahtarGols = { 6, 4, 5, 3, 6 };
        string[] labelsDesna = { "21.11.2021", "29.08.2021", "20.03.2023" };
        double[] valuesDesnaPass = { 3, 1, 1 };
        double[] valuesDesnaGols = { 4, 4, 2 };
        string[] labelsVeres = {"05.12.2021", "14.02.2023" };
        double[] valuesVeresPass = { 1, 4 };
        double[] valuesVeresGols = { 2, 6 };
        string[] labelsKarpaty = {"08.03.2023", "15.03.2023", "30.10.2021" };
        double[] valuesKarpatyPass = { 3, 3, 6 };
        double[] valuesKarpatyGols = { 5, 4, 8 };
        
        public Match_Diagram()
        {
            InitializeComponent();
        }

        private void Button_Pass(object sender, RoutedEventArgs e)
        {
            var plt = new ScottPlot.Plot(600, 400);
            MyReultsMatch.Plot.AddBar(valuesAllTeamPass, positionsAllTeam);
            MyReultsMatch.Plot.XTicks(positionsAllTeam, labelsAllTeam);
            MyReultsMatch.Plot.SetAxisLimits(yMin: 0);
            plt.SaveFig("Pass.png");
            MyReultsMatch.Refresh();
        }

        private void Button_Gols(object sender, RoutedEventArgs e)
        {
            var plt = new ScottPlot.Plot(600, 400);
            MyReultsMatch.Plot.AddBar(valuesAllTeamGols, positionsAllTeam);
            MyReultsMatch.Plot.XTicks(positionsAllTeam, labelsAllTeam);
            MyReultsMatch.Plot.SetAxisLimits(yMin: 0);
            plt.SaveFig("Gols.png");
            MyReultsMatch.Refresh();
        }

        private void TeamComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedItem = 0;
            double[][] positions = { positionsAllTeam, positionsDinamoVeres, positionsShahtarSezon23, positionsDesnaKarpaty, positionsDinamoVeres, positionsDesnaKarpaty };
            string[][] labelsList = { labelsAllTeam, labelsDinamo, labelsShahtar, labelsDesna, labelsVeres, labelsKarpaty };
            double[][] valuesGols = { valuesAllTeamGols, valuesDinamoGols, valuesShahtarGols, valuesDesnaGols, valuesVeresGols, valuesKarpatyGols };
            double[][] valuesPass = { valuesAllTeamPass, valuesDinamoPass, valuesShahtarPass, valuesDesnaPass, valuesVeresPass, valuesKarpatyPass };
            for (int i = 0; i < labelsList.Length; i++)
            {
                if (TeamComboBox.SelectedIndex == selectedItem)
                {
                    var plt = new ScottPlot.Plot(600, 400);                 
                    MyReultsMatch.Plot.AddBar(valuesGols[i], positions[i]);
                    MyReultsMatch.Plot.AddBar(valuesPass[i], positions[i]);
                    MyReultsMatch.Plot.XTicks(positions[i], labelsList[i]);
                    MyReultsMatch.Plot.SetAxisLimits(yMin: 0);
                    plt.SaveFig("Result.png");
                    MyReultsMatch.Refresh();
                }
                selectedItem++;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Player.OpenHelpFile("Football_Manager_2023.chm", "vikno_analiz_rezultativ.htm");
        }

        private void TeamComboBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            FrameworkElement clickedElement = sender as FrameworkElement;
            string componentName = clickedElement.Name;
            Player.OpenHelpFileToKey("Football_Manager_2023.chm", "vikno_analiz_rezultativ.htm", componentName);
        }
    }
}
