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

namespace Taller2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV Files | *.csv;";
            ofd.Title = "Importar datos";
            if (ofd.ShowDialog() == true) {
                DataTable dt = importarArchivoCVS(ofd.FileName);
                dataGrid.ItemsSource = dt.DefaultView;
                dataGrid.GridLinesVisibility = DataGridGridLinesVisibility.All;
            }
        }

        private DataTable importarArchivoCVS(string csv_file_path) {
            DataTable csvData = new DataTable();
            try {
                using (TextFieldParser csvReader = new TextFieldParser(csv_file_path)) {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields) {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }
                    while (!csvReader.EndOfData) {
                        string[] fieldData = csvReader.ReadFields();
                        for (int i = 0; i < fieldData.Length; i++) {
                            if (fieldData[i] == "")
                                fieldData[i] = null;
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }
            } catch (Exception) {
            }
            return csvData;
        }
    }
}
