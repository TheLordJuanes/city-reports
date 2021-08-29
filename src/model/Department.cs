
using System.Collections.Generic;
using System.Linq;
/**
* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
* @Authors: Juan Pablo Ramos and Juan Esteban Caicedo
* @Date: August, 30th 2021
* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*/
namespace Taller2.model {
    public class Department {

        // -----------------------------------------------------------------
        // Attributes
        // -----------------------------------------------------------------

        private string Name;
        private string Code;

        // -----------------------------------------------------------------
        // Relations
        // -----------------------------------------------------------------

        private List<Municipality> municipalities;

        // -----------------------------------------------------------------
        // Methods
        // -----------------------------------------------------------------

        public Department(string Name, string Code) {
            this.Name = Name;
            this.Code = Code;
            municipalities = new List<Municipality>();
        }

        public void addMun(Municipality mun)
        {
            if (!existMun(mun.getCode()))
                municipalities.Add(mun);
        }

        private bool existMun(string id)
        {
            if (id.Equals(""))
            {
            }
            for (int i = 0; i < municipalities.Count; i++)
            {
                if (id.Equals(municipalities.ElementAt(i).getCode()))
                {
                    return true;
                }
            }
            return false;
        }

        public string getName() {
            return Name;
        }

        public string getCode() {
            return Code;
        }

        public List<Municipality> getMunicipalities() {
            return municipalities;
        }
    }
}