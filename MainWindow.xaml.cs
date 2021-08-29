/**
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * @Authors: Juan Pablo Ramos and Juan Esteban Caicedo
 * @Date: August, 30th 2021
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*/
using Microsoft.Win32;
using System.Data;
using System.Windows;
using System.Windows.Controls;
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

        private void btnImportData_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV Files | *.csv;";
            ofd.Title = "Importar datos";
            if (ofd.ShowDialog() == true) {
                DataTable dt = dane.importCVSFile(ofd.FileName);
                dataGrid.ItemsSource = dt.DefaultView;
                dataGrid.GridLinesVisibility = DataGridGridLinesVisibility.All;
                generatePieChart();
            }
        }

        private void generatePieChart() {
            SeriesCollection series = new SeriesCollection();
            foreach (Department dep in dane.getDepartments()) {
                series.Add(new PieSeries() {
                    Title = dep.getName(),
                    Values = new ChartValues<int> { dep.getMunicipalities().Count },
                    DataLabels = true, 
                });
            }
            pieChart.Series = series;
            
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e) {
            string id = tbId.Text;
            string info = dane.searchMunicipalities(id);
            tbInfo.Text = info;
        }
    }
}