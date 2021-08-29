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

namespace Taller2.model
{

    public class Dane
    {

        // -----------------------------------------------------------------
        // Constants
        // -----------------------------------------------------------------

        public static string SEPARATOR = ",";

        // -----------------------------------------------------------------
        // Relations
        // -----------------------------------------------------------------

        private List<Municipality> municipalities;
        private List<Department> departments;

        // -----------------------------------------------------------------
        // Methods
        // -----------------------------------------------------------------

        public Dane()
        {
            municipalities = new List<Municipality>();
            departments = new List<Department>();
        }

        public List<Department> getDepartments()
        {
            return departments;
        }

        public DataTable ImportCVSFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();
            using (StreamReader csvReader = new StreamReader(csv_file_path))
            {
                string[] colFields = csvReader.ReadLine().Split(SEPARATOR);
                foreach (string column in colFields)
                {
                    DataColumn dataColumn = new DataColumn(column);
                    dataColumn.AllowDBNull = true;
                    csvData.Columns.Add(dataColumn);
                }
                while (!csvReader.EndOfStream)
                {
                    string[] fieldData = csvReader.ReadLine().Split(SEPARATOR);
                    for (int i = 0; i < fieldData.Length; i++)
                    {
                        if (fieldData[i] == "")
                            fieldData[i] = null;
                    }
                    csvData.Rows.Add(fieldData);
                    Department depTemp = new Department(fieldData[2], fieldData[0]);
                    Municipality munTemp = new Municipality(fieldData[3], fieldData[1], fieldData[4], fieldData[2], fieldData[0]);
                    municipalities.Add(munTemp);
                    Department temp = exist(fieldData[0]);
                    if (temp == null)
                    {
                        departments.Add(depTemp);
                        departments.ElementAt(departments.Count-1).addMun(munTemp);
                    }
                    else {
                        temp.addMun(munTemp);
                    }
                }
                return csvData;
            }
        }

        public Department exist(string depCode)
        {
            for (int i = 0; i < departments.Count; i++)
            {
                if (depCode.Equals(departments.ElementAt(i).getCode()))
                {
                    return departments.ElementAt(i);
                }
            }
            return null;
        }

        public string SearchMunicipalities(string id)
        {
            string temp = "El municipio no fue encontrado";
            for (int i = 0; i < municipalities.Count; i++)
            {
                if (municipalities.ElementAt(i).getCode().Equals(id))
                {
                    temp = municipalities.ElementAt(i).ToString();
                }
            }
            return temp;
        }
    }
}