
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

        private string name;
        private string code;

        // -----------------------------------------------------------------
        // Relations
        // -----------------------------------------------------------------

        private List<Municipality> municipalities;

        // -----------------------------------------------------------------
        // Methods
        // -----------------------------------------------------------------

        public Department(string name, string code) {
            this.name = name;
            this.code = code;
            municipalities = new List<Municipality>();
        }

        public string getName() {
            return name;
        }

        public string getCode() {
            return code;
        }

        public List<Municipality> getMunicipalities() {
            return municipalities;
        }

        public void addMunicipality(Municipality mun) {
            if (!existMunicipality(mun.getCode()))
                municipalities.Add(mun);
        }

        private bool existMunicipality(string id) {
            for (int i = 0; i < municipalities.Count; i++) {
                if (id.Equals(municipalities.ElementAt(i).getCode()))
                    return true;
            }
            return false;
        }
    }
}