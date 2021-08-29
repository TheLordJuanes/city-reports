/**
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * @Authors: Juan Pablo Ramos and Juan Esteban Caicedo
 * @Date: August, 30th 2021
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*/
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.model {

    public class Dane {

        // -----------------------------------------------------------------
        // Constants
        // -----------------------------------------------------------------

        public static string SEPARATOR = ",";

        // -----------------------------------------------------------------
        // Relations
        // -----------------------------------------------------------------

        private List<Department> departments;
        private List<Municipality> municipalities;

        // -----------------------------------------------------------------
        // Methods
        // -----------------------------------------------------------------

        public Dane() {
        }

        public List<Department> getDepartments() {
            return departments;
        }

        public DataTable ImportCVSFile(string csv_file_path) {
            DataTable csvData = new DataTable();
            using (StreamReader csvReader = new StreamReader(csv_file_path)) {
                string[] colFields = csvReader.ReadLine().Split(SEPARATOR);
                foreach (string column in colFields) {
                    DataColumn datecolumn = new DataColumn(column);
                    datecolumn.AllowDBNull = true;
                    csvData.Columns.Add(datecolumn);
                }
                while (!csvReader.EndOfStream) {
                    string[] fieldData = csvReader.ReadLine().Split(SEPARATOR);
                    for (int i = 0; i < fieldData.Length; i++) {
                        if (fieldData[i] == "") {
                            fieldData[i] = null;
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }
                return csvData;
            }
        }
    }
}