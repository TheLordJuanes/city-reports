/**
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * @Authors: Juan Pablo Ramos and Juan Esteban Caicedo
 * @Date: August, 30th 2021
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*/
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Data.OleDb;
using Microsoft.VisualBasic.FileIO;
using Taller2.model;
using LiveCharts;
using LiveCharts.Wpf;

namespace Taller2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        // -----------------------------------------------------------------
        // Relations
        // -----------------------------------------------------------------

        private Dane dane;

        // -----------------------------------------------------------------
        // Methods
        // -----------------------------------------------------------------


        public MainWindow() {
            InitializeComponent();
            dane = new Dane();
        }

        private void btnImportar_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV Files | *.csv;";
            ofd.Title = "Importar datos";
            if (ofd.ShowDialog() == true) {
                DataTable dt = dane.ImportCVSFile(ofd.FileName);
                dataGrid.ItemsSource = dt.DefaultView;
                dataGrid.GridLinesVisibility = DataGridGridLinesVisibility.All;
                generatePieChart();
            }
        }

        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P)", chartpoint.Y, chartpoint.Participation);
        private void generatePieChart() {
            SeriesCollection series = new SeriesCollection();
            foreach (Department dep in dane.getDepartments()) {
                series.Add(new PieSeries() { Title = dep.getName(), Values = new ChartValues<int> { dep.getMunicipalities().Count }, DataLabels = true, LabelPoint = labelPoint });
            }
            pieChart.Series = series;
        }
    }
}